//========================================================================
// Name : Heartbeat manager
// Authors : Mario Ferreira and Jean-Nicolas Thurre
// Description : The user must enter his age, then the program creates a
// line chart with the heartbeat read from the arduino and displays the
// current heart rate, the heart rate per minute, the user heart rate level and
// the time elapsed since the program started to read the data comming
// from the serial port.
//========================================================================

using System;
using System.Management; // checkArduinoConnection
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Serial port library
using System.Text.RegularExpressions;

namespace Heart_rate_monitor {
    public partial class frmMain : Form {
	const string programName = "Heart rate monitor";

	int seconds = 0;
	int maxHeartBeat = 0; // Needed to calculate heart rate level (Heskell and Fox's method)
	int userAge = 0;
	float currentHeartBeat = 0;
	float heartBeatPerMinute = 0;

	bool isArduinoPluggedIn = false;
	
	string serialPortName = "";
	string heartRateLevel = "";

	TimeSpan elapsedTime = TimeSpan.FromSeconds(0);
	Regex regex = new Regex(@"^([1-9]|[1-9][0-9]|[1][0-4][0-9]|150)$", RegexOptions.Compiled); // user age regex
	SerialPort serialPort = new SerialPort();

	public frmMain() {
	    InitializeComponent();

	    serialPort.BaudRate = 9600;
	    serialPort.Parity = Parity.None;
	    serialPort.StopBits = StopBits.One;
	    serialPort.DataBits = 8;
	    serialPort.Handshake = Handshake.None;
	    serialPort.RtsEnable = true;

	    // Checking arduino connection
	    if ((serialPortName = checkArduinoConnection()) == null) {
		lblInformation.Text = "Please connect your arduino";
	    } else {
		serialPort.PortName = serialPortName;
		isArduinoPluggedIn = true;
	    }

	    // Sets the chart's type
	    crtHeartBeat.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

	    // Alows the user to zoom
	    crtHeartBeat.ChartAreas[0].CursorX.IsUserEnabled = true;
	    crtHeartBeat.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
	    crtHeartBeat.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
	    // Removes background lines from the lines chart
	    crtHeartBeat.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
	    crtHeartBeat.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
	    // Setting line color
	    crtHeartBeat.Series["Heartbeats per second"].Color = Color.Red;
	    
	    // Centering the application window
	    this.StartPosition = FormStartPosition.CenterScreen;

	    // Improving user experience
	    this.ActiveControl = tbxUserAge; // The user age texbox is selected at the start of the application
	    this.AcceptButton = btnStart; // ENTER key = btnStart_click
	    this.CancelButton = btnEnd; // ESC key = btnEnd_click
	}

	private void btnStart_Click(object sender, EventArgs e) {
	    int amountPointsLineChart = 0;
	    MatchCollection matches = regex.Matches(tbxUserAge.Text);

	    amountPointsLineChart = crtHeartBeat.Series[0].Points.Count;

	    // Getting arduino serial port
	    if (isArduinoPluggedIn == true) {
		if (amountPointsLineChart > 0) { // Cleaning the line chart
		    foreach (var series in crtHeartBeat.Series) {
			series.Points.Clear();
		    }
		}
	    } else {
		if ((serialPortName = checkArduinoConnection()) == null) {
		    lblInformation.Text = "Please connect your arduino";
		    return;
		} else {
		    serialPort.PortName = serialPortName;
		    isArduinoPluggedIn = true;
		}
	    }

	    // Getting the user age
	    if (matches.Count != 0) { // If is a valid age
		if (lblInformation.Text.Length > 0) { // Removing any error message
		    lblInformation.Text = programName;
		}

		if (!int.TryParse(tbxUserAge.Text, out userAge)) {
		    lblInformation.Text = "Can't convert user age to int";
		    return;
		}

		maxHeartBeat = 220 - userAge;
	    } else {
		if (timer.Enabled == true) { // If the application is already running
		    timer.Enabled = false;
		    serialPort.Close();
		}

		lblInformation.Text = "Please enter a valid age (1-150)";
		return;
	    }

	    // Openning serial port
	    if (serialPort.IsOpen == false) {
		try {
		    serialPort.Open();
		    timer.Enabled = true; // timer tick = 1000 ms
		} catch (System.IO.IOException) {
		    lblInformation.Text = "Serial port " + serialPort.PortName + " does not exist";
		} catch (UnauthorizedAccessException) {
		    lblInformation.Text = "Access denied to " + serialPort.PortName + " serial port";
		} catch (System.InvalidOperationException) {
		    lblInformation.Text = "Serial port " + serialPort.PortName + " is already opened";
		}
	    }

	    // Cleaning label's messages
	    if (seconds != 0) {
		currentHeartBeat = 0;
		heartBeatPerMinute = 0;
		heartRateLevel = "none";
		seconds = 0;
		elapsedTime = TimeSpan.FromSeconds(seconds);

		lblCurrentlHeartRate.Text = Convert.ToString(currentHeartBeat);
		lblHeartRatePerMinute.Text = Convert.ToString(heartBeatPerMinute);
		lblHeartRateLevel.Text = heartRateLevel;
		lblElapsedTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
	    }
	}

	private void btnEnd_Click(object sender, EventArgs e) {
	    if ((timer.Enabled == true) || (serialPort.IsOpen == true)) {
		// Turn off first the timer to be sure that the program doesn't try to read data from
		// a serial port that is closed (the code is in the timer tick)
		timer.Enabled = false;
		serialPort.Close();
		seconds = 0;
	    }
	}

	private void timer_Tick(object sender, EventArgs e) {
	    seconds++;
	    elapsedTime = TimeSpan.FromSeconds(seconds);
	    
	    // Reading data from serial port
	    try {
		if (float.TryParse(serialPort.ReadLine(), out currentHeartBeat)) {
		    if (lblInformation.Text.Length > 0) { // Removing error messages
			    lblInformation.Text = programName;
		    }

		    crtHeartBeat.Series[0].Points.AddXY(seconds, currentHeartBeat); // Adding point to the line chart
		} else {
		    lblInformation.Text = "Error : can't convert current heart beat to float";
		    currentHeartBeat = 0; // currentHeartBeat = 0 because I need some value in order to calculate the heartBeatPerminute
		}
	    } catch (Exception ex) {
		    timer.Enabled = false;
		    serialPort.Close();
		    lblInformation.Text = "Error : serial port is closed";
	    }

	    heartBeatPerMinute += currentHeartBeat;

	    // If it is a minute
	    if ((seconds % 60) == 0) {
		    heartBeatPerMinute /= 60;

		    if (heartBeatPerMinute <= (0.5 * maxHeartBeat)) {
		        heartRateLevel = "none";
		    } else if ((heartBeatPerMinute > (0.5 * maxHeartBeat)) && (heartBeatPerMinute <= (0.6 * maxHeartBeat))) {
		        heartRateLevel = "very light";
		    } else if ((heartBeatPerMinute > (0.6 * maxHeartBeat)) && (heartBeatPerMinute <= (0.7 * maxHeartBeat))) {
		        heartRateLevel = "light";
		    } else if ((heartBeatPerMinute > (0.7 * maxHeartBeat)) && (heartBeatPerMinute <= (0.8 * maxHeartBeat))) {
		        heartRateLevel = "moderate";
		    } else if ((heartBeatPerMinute > (0.8 * maxHeartBeat)) && (heartBeatPerMinute <= (0.9 * maxHeartBeat))) {
		        heartRateLevel = "hard";
		    } else if ((heartBeatPerMinute > (0.9 * maxHeartBeat)) && (heartBeatPerMinute <= (1 * maxHeartBeat))) {
		        heartRateLevel = "maximum";
		    } else {
		        heartRateLevel = "error";
		    }

		    // Displaying the heart beat per minute with 2 digits after the decimal point
		    lblHeartRatePerMinute.Text = heartBeatPerMinute.ToString("F2");
		    lblHeartRateLevel.Text = heartRateLevel;

		    heartBeatPerMinute = 0;
	    }

	    lblElapsedTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
	    lblCurrentlHeartRate.Text = currentHeartBeat.ToString();
	}

	private void restartToolStripMenuItem_Click(object sender, EventArgs e) {
	    Application.Restart();
	}

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
	    if (serialPort.IsOpen == true) {
		    timer.Enabled = false;
		    serialPort.Close();
	    }
	}

	//==============================================================================================================
	// function checkArduinoConnection                  Request Win API for Arduino serial port
	// arguments : none
	// return : string deviceId			    Arduino's serial port in a success request, otherwise null
	private string checkArduinoConnection() {
	    ManagementScope connectionScope = new ManagementScope();
	    SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
	    ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

	    try {
		foreach (ManagementObject item in searcher.Get()) {
		    string desc = item["Description"].ToString();
		    string deviceId = item["DeviceID"].ToString();

		    if (desc.Contains("Arduino")) {
			return deviceId;
		    }
		}
	    } catch (ManagementException e) {
		/* Do Nothing */
	    }

	    return null;
	}
    }
}
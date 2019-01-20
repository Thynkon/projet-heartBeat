using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace Serial_port_read_tests
{
    public partial class frmMain : Form
    {
        SerialPort sp = new SerialPort();
        public frmMain()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();

            sp.BaudRate = 9600;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.DataBits = 8;
            sp.Handshake = Handshake.None;
            sp.RtsEnable = true;

            // Display each port name to the console.
            /*foreach (string port in ports)
            {
                if (port != "") {
                    sp.PortName = port;
                    lblSerialPortName.Text = "Serial port name : " + Convert.ToString(port);
                    break;
                }
            }*/
            sp.PortName = "COM4";

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            //try {
                sp.Open();
            //} catch (System.IO.IOException) {
                //lblSerialPortName.Text = "Port does not exist";
            //}
            
            timer.Enabled = true; // timer tick = 1000 ms
        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            if ((timer.Enabled == true) || (sp.IsOpen == true)) {
                timer.Enabled = false; // Turn off first the timer to be sure that the program doesn't try to read data from a serial port that is closed (the code is in the timer tick)
                sp.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblData.Text = sp.ReadLine();
        }
    }
}

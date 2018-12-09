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
        SerialPort serialPort = new SerialPort
        {
            PortName = "COM4",
            BaudRate = 9600
        };

        public frmMain()
        {
            InitializeComponent();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            // Display each port name to the console.
            foreach (string port in ports) {
                lblSerialPortName.Text = "Serial port name : " + Convert.ToString(port);
            }

            timer.Enabled = true; // timer tick = 20 ms
            serialPort.Open();
        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            timer.Enabled = false; // Turn off first the timer to be sure that the program doesn't try to read data from a serial port that is closed (the code is in the timer tick)
            serialPort.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblData.Text = Convert.ToString(serialPort.ReadLine());
        }
    }
}

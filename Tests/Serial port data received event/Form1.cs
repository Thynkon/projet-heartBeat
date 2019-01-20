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
using System.Diagnostics;

namespace Serial_port_data_received_event
{
    public partial class Form1 : Form
    {
	SerialPort port = new SerialPort();
	public Form1()
	{
	    InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
	    //SerialPort port = new SerialPort();
	    port.BaudRate = 9600;
	    port.PortName = "COM4";
	    port.ReadTimeout = 1000;

	    // Attach a method to be called when there
	    // is data waiting in the port's buffer
	    port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

	    // Begin communications
	    port.Open();
	}

	private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
	{
	    // Show all the incoming data in the port's buffer in the output window
	    //Debug.WriteLine("data : " + port.ReadExisting());
	    label1.Text = "data : " + port.ReadExisting();
	}
    }
}

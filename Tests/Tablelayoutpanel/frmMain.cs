using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablelayoutpanel
{
    public partial class frmMain : Form
    {
	public frmMain()
	{
	    InitializeComponent();
	    //this.WindowState = FormWindowState.Maximized;
	    //this.AutoSize = true;
	    //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
	}

	private void frmMain_Resize(object sender, EventArgs e)
	{
	    TableLayoutPanelCellPosition pos = tableLayoutPanel1.GetCellPosition(chart1);
	    int width = 0;
	    int height = 0;
	    string []groupBox = { "gbxCurrentHeartRate", "gbxHeartRatePerMinute", "gbxHeartRateLevel", "gbxElapsedTime", "gbxUserAge" };

	    width = tableLayoutPanel1.GetColumnWidths()[pos.Column];
	    height = tableLayoutPanel1.Height;

	    //chart1.Size = new Size(width, height);
	    
	    pos = tableLayoutPanel2.GetCellPosition(gbxCurrentHeartRate);
	    width = tableLayoutPanel2.GetColumnWidths()[pos.Column];
	    height = tableLayoutPanel2.GetRowHeights()[pos.Row];

	    //gbxCurrentHeartRate.Size = new Size(width, height);
	    //gbxHeartRatePerMinute.Size = new Size(width, height);
	    //gbxHeartRateLevel.Size = new Size(width, height);
	    //gbxElapsedTime.Size = new Size(width, height);
	    //gbxUserAge.Size = new Size(width, height);

	    //lbCurrentHeartRate.Location = new System.Drawing.Point(1, 48);
	}
    }
}

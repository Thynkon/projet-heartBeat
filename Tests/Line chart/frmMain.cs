using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_test
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        double function(double x) {
            return (Math.Pow(x, 2) + 2 * Math.Sin(2 * x));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Sets the chart's type
            crtHeartBeats.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            // Alows the user to zoom
            crtHeartBeats.ChartAreas[0].CursorX.IsUserEnabled = true;
            crtHeartBeats.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            crtHeartBeats.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            // Removes background lines from the lines chart
            crtHeartBeats.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            crtHeartBeats.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            for (int i = -15; i < 50; i++)
            {
                crtHeartBeats.Series[0].Points.AddXY(i, function(i));
            }
        }
    }
}

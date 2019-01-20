namespace Tablelayoutpanel
{
    partial class frmMain
    {
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
	    if (disposing && (components != null))
	    {
		components.Dispose();
	    }
	    base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
	    System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
	    System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
	    System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
	    this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
	    this.gbxUserAge = new System.Windows.Forms.GroupBox();
	    this.lblUserAgeTitle = new System.Windows.Forms.Label();
	    this.tbxUserAge = new System.Windows.Forms.TextBox();
	    this.gbxElapsedTime = new System.Windows.Forms.GroupBox();
	    this.lblElapsedTime = new System.Windows.Forms.Label();
	    this.lblElapsedTimeTitle = new System.Windows.Forms.Label();
	    this.gbxHeartRateLevel = new System.Windows.Forms.GroupBox();
	    this.lblHeartRateLevel = new System.Windows.Forms.Label();
	    this.lblHeartRateLevelTitle = new System.Windows.Forms.Label();
	    this.gbxHeartRatePerMinute = new System.Windows.Forms.GroupBox();
	    this.lblHeartRatePerMinute = new System.Windows.Forms.Label();
	    this.lblHeartRatePerMinuteUnit = new System.Windows.Forms.Label();
	    this.lblHrPerMinute = new System.Windows.Forms.Label();
	    this.gbxCurrentHeartRate = new System.Windows.Forms.GroupBox();
	    this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
	    this.label1 = new System.Windows.Forms.Label();
	    this.lblCurrentHeartRateUnit = new System.Windows.Forms.Label();
	    this.label3 = new System.Windows.Forms.Label();
	    this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
	    this.menuStrip1 = new System.Windows.Forms.MenuStrip();
	    this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.lblInformation = new System.Windows.Forms.Label();
	    this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
	    this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
	    this.button2 = new System.Windows.Forms.Button();
	    this.button1 = new System.Windows.Forms.Button();
	    this.tableLayoutPanel2.SuspendLayout();
	    this.gbxUserAge.SuspendLayout();
	    this.gbxElapsedTime.SuspendLayout();
	    this.gbxHeartRateLevel.SuspendLayout();
	    this.gbxHeartRatePerMinute.SuspendLayout();
	    this.gbxCurrentHeartRate.SuspendLayout();
	    this.tableLayoutPanel4.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
	    this.menuStrip1.SuspendLayout();
	    this.tableLayoutPanel1.SuspendLayout();
	    this.tableLayoutPanel3.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // tableLayoutPanel2
	    // 
	    this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
	    this.tableLayoutPanel2.ColumnCount = 2;
	    this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
	    this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
	    this.tableLayoutPanel2.Controls.Add(this.gbxUserAge, 1, 4);
	    this.tableLayoutPanel2.Controls.Add(this.gbxElapsedTime, 1, 3);
	    this.tableLayoutPanel2.Controls.Add(this.gbxHeartRateLevel, 1, 2);
	    this.tableLayoutPanel2.Controls.Add(this.gbxHeartRatePerMinute, 1, 1);
	    this.tableLayoutPanel2.Controls.Add(this.gbxCurrentHeartRate, 1, 0);
	    this.tableLayoutPanel2.Controls.Add(this.chart1, 0, 0);
	    this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 67);
	    this.tableLayoutPanel2.Name = "tableLayoutPanel2";
	    this.tableLayoutPanel2.RowCount = 5;
	    this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
	    this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
	    this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
	    this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
	    this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
	    this.tableLayoutPanel2.Size = new System.Drawing.Size(1022, 526);
	    this.tableLayoutPanel2.TabIndex = 20;
	    // 
	    // gbxUserAge
	    // 
	    this.gbxUserAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.gbxUserAge.Controls.Add(this.lblUserAgeTitle);
	    this.gbxUserAge.Controls.Add(this.tbxUserAge);
	    this.gbxUserAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
	    this.gbxUserAge.Location = new System.Drawing.Point(823, 423);
	    this.gbxUserAge.Name = "gbxUserAge";
	    this.gbxUserAge.Size = new System.Drawing.Size(196, 100);
	    this.gbxUserAge.TabIndex = 31;
	    this.gbxUserAge.TabStop = false;
	    // 
	    // lblUserAgeTitle
	    // 
	    this.lblUserAgeTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblUserAgeTitle.ForeColor = System.Drawing.Color.White;
	    this.lblUserAgeTitle.Location = new System.Drawing.Point(1, 4);
	    this.lblUserAgeTitle.Name = "lblUserAgeTitle";
	    this.lblUserAgeTitle.Size = new System.Drawing.Size(194, 33);
	    this.lblUserAgeTitle.TabIndex = 14;
	    this.lblUserAgeTitle.Text = "Age";
	    this.lblUserAgeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // tbxUserAge
	    // 
	    this.tbxUserAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.tbxUserAge.Location = new System.Drawing.Point(59, 48);
	    this.tbxUserAge.Name = "tbxUserAge";
	    this.tbxUserAge.Size = new System.Drawing.Size(78, 34);
	    this.tbxUserAge.TabIndex = 16;
	    this.tbxUserAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
	    // 
	    // gbxElapsedTime
	    // 
	    this.gbxElapsedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.gbxElapsedTime.Controls.Add(this.lblElapsedTime);
	    this.gbxElapsedTime.Controls.Add(this.lblElapsedTimeTitle);
	    this.gbxElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
	    this.gbxElapsedTime.ForeColor = System.Drawing.Color.White;
	    this.gbxElapsedTime.Location = new System.Drawing.Point(823, 318);
	    this.gbxElapsedTime.Name = "gbxElapsedTime";
	    this.gbxElapsedTime.Size = new System.Drawing.Size(196, 99);
	    this.gbxElapsedTime.TabIndex = 30;
	    this.gbxElapsedTime.TabStop = false;
	    // 
	    // lblElapsedTime
	    // 
	    this.lblElapsedTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F);
	    this.lblElapsedTime.Location = new System.Drawing.Point(1, 47);
	    this.lblElapsedTime.Name = "lblElapsedTime";
	    this.lblElapsedTime.Size = new System.Drawing.Size(194, 53);
	    this.lblElapsedTime.TabIndex = 25;
	    this.lblElapsedTime.Text = "00:00:00";
	    this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // lblElapsedTimeTitle
	    // 
	    this.lblElapsedTimeTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblElapsedTimeTitle.Location = new System.Drawing.Point(1, 4);
	    this.lblElapsedTimeTitle.Name = "lblElapsedTimeTitle";
	    this.lblElapsedTimeTitle.Size = new System.Drawing.Size(194, 32);
	    this.lblElapsedTimeTitle.TabIndex = 14;
	    this.lblElapsedTimeTitle.Text = "Elapsed time";
	    this.lblElapsedTimeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // gbxHeartRateLevel
	    // 
	    this.gbxHeartRateLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.gbxHeartRateLevel.Controls.Add(this.lblHeartRateLevel);
	    this.gbxHeartRateLevel.Controls.Add(this.lblHeartRateLevelTitle);
	    this.gbxHeartRateLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
	    this.gbxHeartRateLevel.ForeColor = System.Drawing.Color.White;
	    this.gbxHeartRateLevel.Location = new System.Drawing.Point(823, 213);
	    this.gbxHeartRateLevel.Name = "gbxHeartRateLevel";
	    this.gbxHeartRateLevel.Size = new System.Drawing.Size(196, 99);
	    this.gbxHeartRateLevel.TabIndex = 29;
	    this.gbxHeartRateLevel.TabStop = false;
	    // 
	    // lblHeartRateLevel
	    // 
	    this.lblHeartRateLevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblHeartRateLevel.Location = new System.Drawing.Point(1, 48);
	    this.lblHeartRateLevel.Name = "lblHeartRateLevel";
	    this.lblHeartRateLevel.Size = new System.Drawing.Size(194, 40);
	    this.lblHeartRateLevel.TabIndex = 25;
	    this.lblHeartRateLevel.Text = "none";
	    this.lblHeartRateLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // lblHeartRateLevelTitle
	    // 
	    this.lblHeartRateLevelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblHeartRateLevelTitle.Location = new System.Drawing.Point(1, 4);
	    this.lblHeartRateLevelTitle.Name = "lblHeartRateLevelTitle";
	    this.lblHeartRateLevelTitle.Size = new System.Drawing.Size(194, 33);
	    this.lblHeartRateLevelTitle.TabIndex = 14;
	    this.lblHeartRateLevelTitle.Text = "HR level";
	    this.lblHeartRateLevelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // gbxHeartRatePerMinute
	    // 
	    this.gbxHeartRatePerMinute.Controls.Add(this.lblHeartRatePerMinute);
	    this.gbxHeartRatePerMinute.Controls.Add(this.lblHeartRatePerMinuteUnit);
	    this.gbxHeartRatePerMinute.Controls.Add(this.lblHrPerMinute);
	    this.gbxHeartRatePerMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
	    this.gbxHeartRatePerMinute.Location = new System.Drawing.Point(823, 105);
	    this.gbxHeartRatePerMinute.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
	    this.gbxHeartRatePerMinute.Name = "gbxHeartRatePerMinute";
	    this.gbxHeartRatePerMinute.Padding = new System.Windows.Forms.Padding(0);
	    this.gbxHeartRatePerMinute.Size = new System.Drawing.Size(196, 102);
	    this.gbxHeartRatePerMinute.TabIndex = 28;
	    this.gbxHeartRatePerMinute.TabStop = false;
	    // 
	    // lblHeartRatePerMinute
	    // 
	    this.lblHeartRatePerMinute.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblHeartRatePerMinute.ForeColor = System.Drawing.Color.White;
	    this.lblHeartRatePerMinute.Location = new System.Drawing.Point(1, 48);
	    this.lblHeartRatePerMinute.Name = "lblHeartRatePerMinute";
	    this.lblHeartRatePerMinute.Size = new System.Drawing.Size(194, 55);
	    this.lblHeartRatePerMinute.TabIndex = 25;
	    this.lblHeartRatePerMinute.Text = "0";
	    this.lblHeartRatePerMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // lblHeartRatePerMinuteUnit
	    // 
	    this.lblHeartRatePerMinuteUnit.AutoSize = true;
	    this.lblHeartRatePerMinuteUnit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblHeartRatePerMinuteUnit.ForeColor = System.Drawing.Color.White;
	    this.lblHeartRatePerMinuteUnit.Location = new System.Drawing.Point(116, 4);
	    this.lblHeartRatePerMinuteUnit.Margin = new System.Windows.Forms.Padding(18, 0, 0, 0);
	    this.lblHeartRatePerMinuteUnit.Name = "lblHeartRatePerMinuteUnit";
	    this.lblHeartRatePerMinuteUnit.Size = new System.Drawing.Size(74, 32);
	    this.lblHeartRatePerMinuteUnit.TabIndex = 24;
	    this.lblHeartRatePerMinuteUnit.Text = "BPM";
	    // 
	    // lblHrPerMinute
	    // 
	    this.lblHrPerMinute.AutoSize = true;
	    this.lblHrPerMinute.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblHrPerMinute.ForeColor = System.Drawing.Color.White;
	    this.lblHrPerMinute.Location = new System.Drawing.Point(4, 4);
	    this.lblHrPerMinute.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
	    this.lblHrPerMinute.Name = "lblHrPerMinute";
	    this.lblHrPerMinute.Size = new System.Drawing.Size(55, 32);
	    this.lblHrPerMinute.TabIndex = 14;
	    this.lblHrPerMinute.Text = "HR";
	    // 
	    // gbxCurrentHeartRate
	    // 
	    this.gbxCurrentHeartRate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
	    this.gbxCurrentHeartRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
	    this.gbxCurrentHeartRate.Controls.Add(this.tableLayoutPanel4);
	    this.gbxCurrentHeartRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
	    this.gbxCurrentHeartRate.ForeColor = System.Drawing.Color.White;
	    this.gbxCurrentHeartRate.Location = new System.Drawing.Point(823, 0);
	    this.gbxCurrentHeartRate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
	    this.gbxCurrentHeartRate.Name = "gbxCurrentHeartRate";
	    this.gbxCurrentHeartRate.Size = new System.Drawing.Size(196, 102);
	    this.gbxCurrentHeartRate.TabIndex = 27;
	    this.gbxCurrentHeartRate.TabStop = false;
	    // 
	    // tableLayoutPanel4
	    // 
	    this.tableLayoutPanel4.ColumnCount = 2;
	    this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
	    this.tableLayoutPanel4.Controls.Add(this.lblCurrentHeartRateUnit, 1, 0);
	    this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
	    this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tableLayoutPanel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 4);
	    this.tableLayoutPanel4.Name = "tableLayoutPanel4";
	    this.tableLayoutPanel4.RowCount = 2;
	    this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
	    this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
	    this.tableLayoutPanel4.Size = new System.Drawing.Size(190, 95);
	    this.tableLayoutPanel4.TabIndex = 0;
	    // 
	    // label1
	    // 
	    this.label1.AutoSize = true;
	    this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.label1.ForeColor = System.Drawing.Color.White;
	    this.label1.Location = new System.Drawing.Point(0, 0);
	    this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
	    this.label1.Name = "label1";
	    this.label1.Size = new System.Drawing.Size(92, 38);
	    this.label1.TabIndex = 15;
	    this.label1.Text = "HR";
	    // 
	    // lblCurrentHeartRateUnit
	    // 
	    this.lblCurrentHeartRateUnit.AutoSize = true;
	    this.lblCurrentHeartRateUnit.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblCurrentHeartRateUnit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblCurrentHeartRateUnit.ForeColor = System.Drawing.Color.White;
	    this.lblCurrentHeartRateUnit.Location = new System.Drawing.Point(115, 0);
	    this.lblCurrentHeartRateUnit.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
	    this.lblCurrentHeartRateUnit.Name = "lblCurrentHeartRateUnit";
	    this.lblCurrentHeartRateUnit.Size = new System.Drawing.Size(75, 38);
	    this.lblCurrentHeartRateUnit.TabIndex = 26;
	    this.lblCurrentHeartRateUnit.Text = "BPM";
	    // 
	    // label3
	    // 
	    this.label3.AutoSize = true;
	    this.tableLayoutPanel4.SetColumnSpan(this.label3, 2);
	    this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.label3.ForeColor = System.Drawing.Color.White;
	    this.label3.Location = new System.Drawing.Point(3, 38);
	    this.label3.Name = "label3";
	    this.label3.Size = new System.Drawing.Size(184, 57);
	    this.label3.TabIndex = 27;
	    this.label3.Text = "0";
	    this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // chart1
	    // 
	    chartArea3.Name = "ChartArea1";
	    this.chart1.ChartAreas.Add(chartArea3);
	    this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
	    legend3.Name = "Legend1";
	    this.chart1.Legends.Add(legend3);
	    this.chart1.Location = new System.Drawing.Point(3, 3);
	    this.chart1.Name = "chart1";
	    this.tableLayoutPanel2.SetRowSpan(this.chart1, 5);
	    series3.ChartArea = "ChartArea1";
	    series3.Legend = "Legend1";
	    series3.Name = "Series1";
	    this.chart1.Series.Add(series3);
	    this.chart1.Size = new System.Drawing.Size(814, 520);
	    this.chart1.TabIndex = 0;
	    this.chart1.Text = "chart1";
	    // 
	    // menuStrip1
	    // 
	    this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
	    this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem});
	    this.menuStrip1.Location = new System.Drawing.Point(0, 0);
	    this.menuStrip1.Name = "menuStrip1";
	    this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
	    this.menuStrip1.TabIndex = 0;
	    this.menuStrip1.Text = "menuStrip1";
	    // 
	    // restartToolStripMenuItem
	    // 
	    this.restartToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.restartToolStripMenuItem.ForeColor = System.Drawing.Color.White;
	    this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
	    this.restartToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
	    this.restartToolStripMenuItem.Text = "Restart";
	    // 
	    // lblInformation
	    // 
	    this.lblInformation.Dock = System.Windows.Forms.DockStyle.Top;
	    this.lblInformation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblInformation.ForeColor = System.Drawing.Color.White;
	    this.lblInformation.Location = new System.Drawing.Point(3, 32);
	    this.lblInformation.Name = "lblInformation";
	    this.lblInformation.Size = new System.Drawing.Size(1022, 31);
	    this.lblInformation.TabIndex = 19;
	    this.lblInformation.Text = "Welcome to the heartbeat monitor";
	    this.lblInformation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	    // 
	    // tableLayoutPanel1
	    // 
	    this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
	    this.tableLayoutPanel1.ColumnCount = 1;
	    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
	    this.tableLayoutPanel1.Controls.Add(this.lblInformation, 0, 1);
	    this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
	    this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
	    this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
	    this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
	    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
	    this.tableLayoutPanel1.RowCount = 4;
	    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
	    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
	    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.14286F));
	    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.035714F));
	    this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 649);
	    this.tableLayoutPanel1.TabIndex = 0;
	    // 
	    // tableLayoutPanel3
	    // 
	    this.tableLayoutPanel3.ColumnCount = 2;
	    this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
	    this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
	    this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 599);
	    this.tableLayoutPanel3.Name = "tableLayoutPanel3";
	    this.tableLayoutPanel3.RowCount = 1;
	    this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
	    this.tableLayoutPanel3.Size = new System.Drawing.Size(1022, 47);
	    this.tableLayoutPanel3.TabIndex = 21;
	    // 
	    // button2
	    // 
	    this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
	    this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
	    this.button2.FlatAppearance.BorderSize = 0;
	    this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
	    this.button2.ForeColor = System.Drawing.Color.White;
	    this.button2.Location = new System.Drawing.Point(514, 3);
	    this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 300, 3);
	    this.button2.Name = "button2";
	    this.button2.Size = new System.Drawing.Size(139, 41);
	    this.button2.TabIndex = 1;
	    this.button2.Text = "Start";
	    this.button2.UseVisualStyleBackColor = false;
	    // 
	    // button1
	    // 
	    this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
	    this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
	    this.button1.FlatAppearance.BorderSize = 0;
	    this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
	    this.button1.ForeColor = System.Drawing.Color.White;
	    this.button1.Location = new System.Drawing.Point(369, 3);
	    this.button1.Margin = new System.Windows.Forms.Padding(300, 3, 3, 3);
	    this.button1.Name = "button1";
	    this.button1.Size = new System.Drawing.Size(139, 41);
	    this.button1.TabIndex = 0;
	    this.button1.Text = "Start";
	    this.button1.UseVisualStyleBackColor = false;
	    // 
	    // frmMain
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.AutoScroll = true;
	    this.ClientSize = new System.Drawing.Size(1028, 649);
	    this.Controls.Add(this.tableLayoutPanel1);
	    this.MainMenuStrip = this.menuStrip1;
	    this.Name = "frmMain";
	    this.Text = "Heart rate monitor";
	    this.Resize += new System.EventHandler(this.frmMain_Resize);
	    this.tableLayoutPanel2.ResumeLayout(false);
	    this.gbxUserAge.ResumeLayout(false);
	    this.gbxUserAge.PerformLayout();
	    this.gbxElapsedTime.ResumeLayout(false);
	    this.gbxHeartRateLevel.ResumeLayout(false);
	    this.gbxHeartRatePerMinute.ResumeLayout(false);
	    this.gbxHeartRatePerMinute.PerformLayout();
	    this.gbxCurrentHeartRate.ResumeLayout(false);
	    this.tableLayoutPanel4.ResumeLayout(false);
	    this.tableLayoutPanel4.PerformLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
	    this.menuStrip1.ResumeLayout(false);
	    this.menuStrip1.PerformLayout();
	    this.tableLayoutPanel1.ResumeLayout(false);
	    this.tableLayoutPanel1.PerformLayout();
	    this.tableLayoutPanel3.ResumeLayout(false);
	    this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	private System.Windows.Forms.GroupBox gbxUserAge;
	private System.Windows.Forms.Label lblUserAgeTitle;
	private System.Windows.Forms.TextBox tbxUserAge;
	private System.Windows.Forms.GroupBox gbxElapsedTime;
	private System.Windows.Forms.Label lblElapsedTime;
	private System.Windows.Forms.Label lblElapsedTimeTitle;
	private System.Windows.Forms.GroupBox gbxHeartRateLevel;
	private System.Windows.Forms.Label lblHeartRateLevel;
	private System.Windows.Forms.Label lblHeartRateLevelTitle;
	private System.Windows.Forms.GroupBox gbxHeartRatePerMinute;
	private System.Windows.Forms.Label lblHeartRatePerMinute;
	private System.Windows.Forms.Label lblHeartRatePerMinuteUnit;
	private System.Windows.Forms.Label lblHrPerMinute;
	private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	private System.Windows.Forms.MenuStrip menuStrip1;
	private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
	private System.Windows.Forms.Label lblInformation;
	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.GroupBox gbxCurrentHeartRate;
	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label lblCurrentHeartRateUnit;
	private System.Windows.Forms.Label label3;
    }
}


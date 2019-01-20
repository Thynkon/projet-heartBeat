namespace Heart_rate_monitor
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
	    this.components = new System.ComponentModel.Container();
	    System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
	    System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
	    System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
	    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
	    this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
	    this.gbxUserAge = new System.Windows.Forms.GroupBox();
	    this.tlpUserAge = new System.Windows.Forms.TableLayoutPanel();
	    this.tbxUserAge = new System.Windows.Forms.TextBox();
	    this.lblUserAgeTitle = new System.Windows.Forms.Label();
	    this.gbxElapsedTime = new System.Windows.Forms.GroupBox();
	    this.tlpElapsedTime = new System.Windows.Forms.TableLayoutPanel();
	    this.lblElapsedTime = new System.Windows.Forms.Label();
	    this.lblElapsedTimeTitle = new System.Windows.Forms.Label();
	    this.gbxHeartRateLevel = new System.Windows.Forms.GroupBox();
	    this.tlpHeartRateLevel = new System.Windows.Forms.TableLayoutPanel();
	    this.lblHeartRateLevel = new System.Windows.Forms.Label();
	    this.lblHeartRateLevelTitle = new System.Windows.Forms.Label();
	    this.gbxHearRatePerMinute = new System.Windows.Forms.GroupBox();
	    this.tlpHeartRatePerMinute = new System.Windows.Forms.TableLayoutPanel();
	    this.lblHeartRatePerMinute = new System.Windows.Forms.Label();
	    this.lblHeartRatePerMinuteUnit = new System.Windows.Forms.Label();
	    this.lblHrPerMinute = new System.Windows.Forms.Label();
	    this.mstApplication = new System.Windows.Forms.MenuStrip();
	    this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.lblInformation = new System.Windows.Forms.Label();
	    this.crtHeartBeat = new System.Windows.Forms.DataVisualization.Charting.Chart();
	    this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
	    this.btnEnd = new System.Windows.Forms.Button();
	    this.btnStart = new System.Windows.Forms.Button();
	    this.gbxCurrentHeartRate = new System.Windows.Forms.GroupBox();
	    this.tlpCurrentHeartRate = new System.Windows.Forms.TableLayoutPanel();
	    this.lblCurrentlHeartRate = new System.Windows.Forms.Label();
	    this.lblCurrentHeartRateUnit = new System.Windows.Forms.Label();
	    this.lblCurrentHeartRateHr = new System.Windows.Forms.Label();
	    this.timer = new System.Windows.Forms.Timer(this.components);
	    this.tlpMain.SuspendLayout();
	    this.gbxUserAge.SuspendLayout();
	    this.tlpUserAge.SuspendLayout();
	    this.gbxElapsedTime.SuspendLayout();
	    this.tlpElapsedTime.SuspendLayout();
	    this.gbxHeartRateLevel.SuspendLayout();
	    this.tlpHeartRateLevel.SuspendLayout();
	    this.gbxHearRatePerMinute.SuspendLayout();
	    this.tlpHeartRatePerMinute.SuspendLayout();
	    this.mstApplication.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.crtHeartBeat)).BeginInit();
	    this.tlpBottom.SuspendLayout();
	    this.gbxCurrentHeartRate.SuspendLayout();
	    this.tlpCurrentHeartRate.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // tlpMain
	    // 
	    this.tlpMain.ColumnCount = 2;
	    this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.49466F));
	    this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.50534F));
	    this.tlpMain.Controls.Add(this.gbxUserAge, 1, 6);
	    this.tlpMain.Controls.Add(this.gbxElapsedTime, 1, 5);
	    this.tlpMain.Controls.Add(this.gbxHeartRateLevel, 1, 4);
	    this.tlpMain.Controls.Add(this.gbxHearRatePerMinute, 1, 3);
	    this.tlpMain.Controls.Add(this.mstApplication, 0, 0);
	    this.tlpMain.Controls.Add(this.lblInformation, 0, 1);
	    this.tlpMain.Controls.Add(this.crtHeartBeat, 0, 2);
	    this.tlpMain.Controls.Add(this.tlpBottom, 0, 7);
	    this.tlpMain.Controls.Add(this.gbxCurrentHeartRate, 1, 2);
	    this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tlpMain.Location = new System.Drawing.Point(0, 0);
	    this.tlpMain.Name = "tlpMain";
	    this.tlpMain.RowCount = 8;
	    this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.407512F));
	    this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.315718F));
	    this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.38865F));
	    this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.38513F));
	    this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.38513F));
	    this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.38513F));
	    this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.38513F));
	    this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.347599F));
	    this.tlpMain.Size = new System.Drawing.Size(1124, 666);
	    this.tlpMain.TabIndex = 0;
	    // 
	    // gbxUserAge
	    // 
	    this.gbxUserAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
	    this.gbxUserAge.Controls.Add(this.tlpUserAge);
	    this.gbxUserAge.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.gbxUserAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
	    this.gbxUserAge.ForeColor = System.Drawing.Color.White;
	    this.gbxUserAge.Location = new System.Drawing.Point(918, 496);
	    this.gbxUserAge.Name = "gbxUserAge";
	    this.gbxUserAge.Size = new System.Drawing.Size(203, 103);
	    this.gbxUserAge.TabIndex = 32;
	    this.gbxUserAge.TabStop = false;
	    // 
	    // tlpUserAge
	    // 
	    this.tlpUserAge.ColumnCount = 1;
	    this.tlpUserAge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
	    this.tlpUserAge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
	    this.tlpUserAge.Controls.Add(this.tbxUserAge, 0, 1);
	    this.tlpUserAge.Controls.Add(this.lblUserAgeTitle, 0, 0);
	    this.tlpUserAge.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tlpUserAge.Location = new System.Drawing.Point(3, 4);
	    this.tlpUserAge.Name = "tlpUserAge";
	    this.tlpUserAge.RowCount = 2;
	    this.tlpUserAge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tlpUserAge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tlpUserAge.Size = new System.Drawing.Size(197, 96);
	    this.tlpUserAge.TabIndex = 1;
	    // 
	    // tbxUserAge
	    // 
	    this.tbxUserAge.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tbxUserAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.tbxUserAge.Location = new System.Drawing.Point(60, 51);
	    this.tbxUserAge.Margin = new System.Windows.Forms.Padding(60, 3, 60, 3);
	    this.tbxUserAge.Name = "tbxUserAge";
	    this.tbxUserAge.Size = new System.Drawing.Size(77, 34);
	    this.tbxUserAge.TabIndex = 17;
	    this.tbxUserAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
	    // 
	    // lblUserAgeTitle
	    // 
	    this.lblUserAgeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblUserAgeTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblUserAgeTitle.ForeColor = System.Drawing.Color.White;
	    this.lblUserAgeTitle.Location = new System.Drawing.Point(3, 0);
	    this.lblUserAgeTitle.Name = "lblUserAgeTitle";
	    this.lblUserAgeTitle.Size = new System.Drawing.Size(191, 48);
	    this.lblUserAgeTitle.TabIndex = 15;
	    this.lblUserAgeTitle.Text = "Age";
	    this.lblUserAgeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // gbxElapsedTime
	    // 
	    this.gbxElapsedTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
	    this.gbxElapsedTime.Controls.Add(this.tlpElapsedTime);
	    this.gbxElapsedTime.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.gbxElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
	    this.gbxElapsedTime.ForeColor = System.Drawing.Color.White;
	    this.gbxElapsedTime.Location = new System.Drawing.Point(918, 387);
	    this.gbxElapsedTime.Name = "gbxElapsedTime";
	    this.gbxElapsedTime.Size = new System.Drawing.Size(203, 103);
	    this.gbxElapsedTime.TabIndex = 31;
	    this.gbxElapsedTime.TabStop = false;
	    // 
	    // tlpElapsedTime
	    // 
	    this.tlpElapsedTime.ColumnCount = 1;
	    this.tlpElapsedTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
	    this.tlpElapsedTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
	    this.tlpElapsedTime.Controls.Add(this.lblElapsedTime, 0, 1);
	    this.tlpElapsedTime.Controls.Add(this.lblElapsedTimeTitle, 0, 0);
	    this.tlpElapsedTime.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tlpElapsedTime.Location = new System.Drawing.Point(3, 4);
	    this.tlpElapsedTime.Name = "tlpElapsedTime";
	    this.tlpElapsedTime.RowCount = 2;
	    this.tlpElapsedTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tlpElapsedTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tlpElapsedTime.Size = new System.Drawing.Size(197, 96);
	    this.tlpElapsedTime.TabIndex = 1;
	    // 
	    // lblElapsedTime
	    // 
	    this.lblElapsedTime.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblElapsedTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F);
	    this.lblElapsedTime.Location = new System.Drawing.Point(3, 48);
	    this.lblElapsedTime.Name = "lblElapsedTime";
	    this.lblElapsedTime.Size = new System.Drawing.Size(191, 48);
	    this.lblElapsedTime.TabIndex = 26;
	    this.lblElapsedTime.Text = "00:00:00";
	    this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // lblElapsedTimeTitle
	    // 
	    this.lblElapsedTimeTitle.AutoSize = true;
	    this.lblElapsedTimeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblElapsedTimeTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblElapsedTimeTitle.Location = new System.Drawing.Point(3, 0);
	    this.lblElapsedTimeTitle.Name = "lblElapsedTimeTitle";
	    this.lblElapsedTimeTitle.Size = new System.Drawing.Size(191, 48);
	    this.lblElapsedTimeTitle.TabIndex = 15;
	    this.lblElapsedTimeTitle.Text = "Elapsed time";
	    this.lblElapsedTimeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // gbxHeartRateLevel
	    // 
	    this.gbxHeartRateLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
	    this.gbxHeartRateLevel.Controls.Add(this.tlpHeartRateLevel);
	    this.gbxHeartRateLevel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.gbxHeartRateLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
	    this.gbxHeartRateLevel.ForeColor = System.Drawing.Color.White;
	    this.gbxHeartRateLevel.Location = new System.Drawing.Point(918, 278);
	    this.gbxHeartRateLevel.Name = "gbxHeartRateLevel";
	    this.gbxHeartRateLevel.Size = new System.Drawing.Size(203, 103);
	    this.gbxHeartRateLevel.TabIndex = 30;
	    this.gbxHeartRateLevel.TabStop = false;
	    // 
	    // tlpHeartRateLevel
	    // 
	    this.tlpHeartRateLevel.ColumnCount = 1;
	    this.tlpHeartRateLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
	    this.tlpHeartRateLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
	    this.tlpHeartRateLevel.Controls.Add(this.lblHeartRateLevel, 0, 1);
	    this.tlpHeartRateLevel.Controls.Add(this.lblHeartRateLevelTitle, 0, 0);
	    this.tlpHeartRateLevel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tlpHeartRateLevel.Location = new System.Drawing.Point(3, 4);
	    this.tlpHeartRateLevel.Name = "tlpHeartRateLevel";
	    this.tlpHeartRateLevel.RowCount = 2;
	    this.tlpHeartRateLevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.74757F));
	    this.tlpHeartRateLevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.25243F));
	    this.tlpHeartRateLevel.Size = new System.Drawing.Size(197, 96);
	    this.tlpHeartRateLevel.TabIndex = 1;
	    // 
	    // lblHeartRateLevel
	    // 
	    this.lblHeartRateLevel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblHeartRateLevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblHeartRateLevel.Location = new System.Drawing.Point(3, 40);
	    this.lblHeartRateLevel.Name = "lblHeartRateLevel";
	    this.lblHeartRateLevel.Size = new System.Drawing.Size(191, 56);
	    this.lblHeartRateLevel.TabIndex = 26;
	    this.lblHeartRateLevel.Text = "none";
	    this.lblHeartRateLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // lblHeartRateLevelTitle
	    // 
	    this.lblHeartRateLevelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblHeartRateLevelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblHeartRateLevelTitle.Location = new System.Drawing.Point(3, 0);
	    this.lblHeartRateLevelTitle.Name = "lblHeartRateLevelTitle";
	    this.lblHeartRateLevelTitle.Size = new System.Drawing.Size(191, 40);
	    this.lblHeartRateLevelTitle.TabIndex = 15;
	    this.lblHeartRateLevelTitle.Text = "HR level";
	    this.lblHeartRateLevelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // gbxHearRatePerMinute
	    // 
	    this.gbxHearRatePerMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
	    this.gbxHearRatePerMinute.Controls.Add(this.tlpHeartRatePerMinute);
	    this.gbxHearRatePerMinute.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.gbxHearRatePerMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
	    this.gbxHearRatePerMinute.ForeColor = System.Drawing.Color.White;
	    this.gbxHearRatePerMinute.Location = new System.Drawing.Point(918, 169);
	    this.gbxHearRatePerMinute.Name = "gbxHearRatePerMinute";
	    this.gbxHearRatePerMinute.Size = new System.Drawing.Size(203, 103);
	    this.gbxHearRatePerMinute.TabIndex = 29;
	    this.gbxHearRatePerMinute.TabStop = false;
	    // 
	    // tlpHeartRatePerMinute
	    // 
	    this.tlpHeartRatePerMinute.ColumnCount = 2;
	    this.tlpHeartRatePerMinute.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tlpHeartRatePerMinute.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tlpHeartRatePerMinute.Controls.Add(this.lblHeartRatePerMinute, 0, 1);
	    this.tlpHeartRatePerMinute.Controls.Add(this.lblHeartRatePerMinuteUnit, 0, 0);
	    this.tlpHeartRatePerMinute.Controls.Add(this.lblHrPerMinute, 0, 0);
	    this.tlpHeartRatePerMinute.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tlpHeartRatePerMinute.Location = new System.Drawing.Point(3, 4);
	    this.tlpHeartRatePerMinute.Name = "tlpHeartRatePerMinute";
	    this.tlpHeartRatePerMinute.RowCount = 2;
	    this.tlpHeartRatePerMinute.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.01456F));
	    this.tlpHeartRatePerMinute.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.98544F));
	    this.tlpHeartRatePerMinute.Size = new System.Drawing.Size(197, 96);
	    this.tlpHeartRatePerMinute.TabIndex = 1;
	    // 
	    // lblHeartRatePerMinute
	    // 
	    this.tlpHeartRatePerMinute.SetColumnSpan(this.lblHeartRatePerMinute, 2);
	    this.lblHeartRatePerMinute.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblHeartRatePerMinute.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblHeartRatePerMinute.Location = new System.Drawing.Point(3, 43);
	    this.lblHeartRatePerMinute.Name = "lblHeartRatePerMinute";
	    this.lblHeartRatePerMinute.Size = new System.Drawing.Size(191, 53);
	    this.lblHeartRatePerMinute.TabIndex = 27;
	    this.lblHeartRatePerMinute.Text = "0";
	    this.lblHeartRatePerMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // lblHeartRatePerMinuteUnit
	    // 
	    this.lblHeartRatePerMinuteUnit.AutoSize = true;
	    this.lblHeartRatePerMinuteUnit.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblHeartRatePerMinuteUnit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblHeartRatePerMinuteUnit.ForeColor = System.Drawing.Color.White;
	    this.lblHeartRatePerMinuteUnit.Location = new System.Drawing.Point(98, 0);
	    this.lblHeartRatePerMinuteUnit.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
	    this.lblHeartRatePerMinuteUnit.Name = "lblHeartRatePerMinuteUnit";
	    this.lblHeartRatePerMinuteUnit.Size = new System.Drawing.Size(96, 43);
	    this.lblHeartRatePerMinuteUnit.TabIndex = 18;
	    this.lblHeartRatePerMinuteUnit.Text = "BPM";
	    this.lblHeartRatePerMinuteUnit.TextAlign = System.Drawing.ContentAlignment.TopRight;
	    // 
	    // lblHrPerMinute
	    // 
	    this.lblHrPerMinute.AutoSize = true;
	    this.lblHrPerMinute.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblHrPerMinute.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblHrPerMinute.ForeColor = System.Drawing.Color.White;
	    this.lblHrPerMinute.Location = new System.Drawing.Point(0, 0);
	    this.lblHrPerMinute.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
	    this.lblHrPerMinute.Name = "lblHrPerMinute";
	    this.lblHrPerMinute.Size = new System.Drawing.Size(95, 43);
	    this.lblHrPerMinute.TabIndex = 16;
	    this.lblHrPerMinute.Text = "HR/M";
	    // 
	    // mstApplication
	    // 
	    this.mstApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
	    this.tlpMain.SetColumnSpan(this.mstApplication, 2);
	    this.mstApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.mstApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem});
	    this.mstApplication.Location = new System.Drawing.Point(0, 0);
	    this.mstApplication.Name = "mstApplication";
	    this.mstApplication.Size = new System.Drawing.Size(1124, 22);
	    this.mstApplication.TabIndex = 12;
	    this.mstApplication.Text = "menuStrip1";
	    // 
	    // restartToolStripMenuItem
	    // 
	    this.restartToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.restartToolStripMenuItem.ForeColor = System.Drawing.Color.White;
	    this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
	    this.restartToolStripMenuItem.Size = new System.Drawing.Size(70, 18);
	    this.restartToolStripMenuItem.Text = " Restart";
	    this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
	    // 
	    // lblInformation
	    // 
	    this.lblInformation.AutoSize = true;
	    this.tlpMain.SetColumnSpan(this.lblInformation, 2);
	    this.lblInformation.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblInformation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
	    this.lblInformation.ForeColor = System.Drawing.Color.White;
	    this.lblInformation.Location = new System.Drawing.Point(3, 22);
	    this.lblInformation.Name = "lblInformation";
	    this.lblInformation.Size = new System.Drawing.Size(1118, 35);
	    this.lblInformation.TabIndex = 13;
	    this.lblInformation.Text = "Welcome to the Heart rate monitor";
	    this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // crtHeartBeat
	    // 
	    chartArea1.AxisX.Title = "Seconds";
	    chartArea1.AxisY.Title = "Heartbeats";
	    chartArea1.Name = "ChartArea1";
	    this.crtHeartBeat.ChartAreas.Add(chartArea1);
	    this.crtHeartBeat.Dock = System.Windows.Forms.DockStyle.Fill;
	    legend1.Name = "Legend1";
	    this.crtHeartBeat.Legends.Add(legend1);
	    this.crtHeartBeat.Location = new System.Drawing.Point(7, 60);
	    this.crtHeartBeat.Margin = new System.Windows.Forms.Padding(7, 3, 3, 4);
	    this.crtHeartBeat.Name = "crtHeartBeat";
	    this.tlpMain.SetRowSpan(this.crtHeartBeat, 5);
	    series1.ChartArea = "ChartArea1";
	    series1.Legend = "Legend1";
	    series1.Name = "Heartbeats per second";
	    this.crtHeartBeat.Series.Add(series1);
	    this.crtHeartBeat.Size = new System.Drawing.Size(905, 538);
	    this.crtHeartBeat.TabIndex = 14;
	    this.crtHeartBeat.Text = "chart1";
	    // 
	    // tlpBottom
	    // 
	    this.tlpBottom.ColumnCount = 2;
	    this.tlpMain.SetColumnSpan(this.tlpBottom, 2);
	    this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tlpBottom.Controls.Add(this.btnEnd, 0, 0);
	    this.tlpBottom.Controls.Add(this.btnStart, 0, 0);
	    this.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tlpBottom.Location = new System.Drawing.Point(3, 605);
	    this.tlpBottom.Name = "tlpBottom";
	    this.tlpBottom.RowCount = 1;
	    this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
	    this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
	    this.tlpBottom.Size = new System.Drawing.Size(1118, 58);
	    this.tlpBottom.TabIndex = 28;
	    // 
	    // btnEnd
	    // 
	    this.btnEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
	    this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
	    this.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
	    this.btnEnd.FlatAppearance.BorderSize = 0;
	    this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.btnEnd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.btnEnd.ForeColor = System.Drawing.Color.White;
	    this.btnEnd.Location = new System.Drawing.Point(574, 7);
	    this.btnEnd.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
	    this.btnEnd.Name = "btnEnd";
	    this.btnEnd.Size = new System.Drawing.Size(139, 44);
	    this.btnEnd.TabIndex = 22;
	    this.btnEnd.Text = "End";
	    this.btnEnd.UseVisualStyleBackColor = false;
	    this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
	    // 
	    // btnStart
	    // 
	    this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
	    this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
	    this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
	    this.btnStart.FlatAppearance.BorderSize = 0;
	    this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.btnStart.ForeColor = System.Drawing.Color.White;
	    this.btnStart.Location = new System.Drawing.Point(405, 7);
	    this.btnStart.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
	    this.btnStart.Name = "btnStart";
	    this.btnStart.Size = new System.Drawing.Size(139, 44);
	    this.btnStart.TabIndex = 21;
	    this.btnStart.Text = "Start";
	    this.btnStart.UseVisualStyleBackColor = false;
	    this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
	    // 
	    // gbxCurrentHeartRate
	    // 
	    this.gbxCurrentHeartRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
	    this.gbxCurrentHeartRate.Controls.Add(this.tlpCurrentHeartRate);
	    this.gbxCurrentHeartRate.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.gbxCurrentHeartRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
	    this.gbxCurrentHeartRate.ForeColor = System.Drawing.Color.White;
	    this.gbxCurrentHeartRate.Location = new System.Drawing.Point(918, 60);
	    this.gbxCurrentHeartRate.Name = "gbxCurrentHeartRate";
	    this.gbxCurrentHeartRate.Size = new System.Drawing.Size(203, 103);
	    this.gbxCurrentHeartRate.TabIndex = 27;
	    this.gbxCurrentHeartRate.TabStop = false;
	    // 
	    // tlpCurrentHeartRate
	    // 
	    this.tlpCurrentHeartRate.ColumnCount = 2;
	    this.tlpCurrentHeartRate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tlpCurrentHeartRate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	    this.tlpCurrentHeartRate.Controls.Add(this.lblCurrentlHeartRate, 0, 1);
	    this.tlpCurrentHeartRate.Controls.Add(this.lblCurrentHeartRateUnit, 1, 0);
	    this.tlpCurrentHeartRate.Controls.Add(this.lblCurrentHeartRateHr, 0, 0);
	    this.tlpCurrentHeartRate.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.tlpCurrentHeartRate.Location = new System.Drawing.Point(3, 4);
	    this.tlpCurrentHeartRate.Name = "tlpCurrentHeartRate";
	    this.tlpCurrentHeartRate.RowCount = 2;
	    this.tlpCurrentHeartRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.68932F));
	    this.tlpCurrentHeartRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.31068F));
	    this.tlpCurrentHeartRate.Size = new System.Drawing.Size(197, 96);
	    this.tlpCurrentHeartRate.TabIndex = 0;
	    // 
	    // lblCurrentlHeartRate
	    // 
	    this.tlpCurrentHeartRate.SetColumnSpan(this.lblCurrentlHeartRate, 2);
	    this.lblCurrentlHeartRate.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblCurrentlHeartRate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblCurrentlHeartRate.Location = new System.Drawing.Point(3, 41);
	    this.lblCurrentlHeartRate.Name = "lblCurrentlHeartRate";
	    this.lblCurrentlHeartRate.Size = new System.Drawing.Size(191, 55);
	    this.lblCurrentlHeartRate.TabIndex = 26;
	    this.lblCurrentlHeartRate.Text = "0";
	    this.lblCurrentlHeartRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // lblCurrentHeartRateUnit
	    // 
	    this.lblCurrentHeartRateUnit.AutoSize = true;
	    this.lblCurrentHeartRateUnit.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblCurrentHeartRateUnit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblCurrentHeartRateUnit.ForeColor = System.Drawing.Color.White;
	    this.lblCurrentHeartRateUnit.Location = new System.Drawing.Point(98, 0);
	    this.lblCurrentHeartRateUnit.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
	    this.lblCurrentHeartRateUnit.Name = "lblCurrentHeartRateUnit";
	    this.lblCurrentHeartRateUnit.Size = new System.Drawing.Size(96, 41);
	    this.lblCurrentHeartRateUnit.TabIndex = 17;
	    this.lblCurrentHeartRateUnit.Text = "BPM";
	    this.lblCurrentHeartRateUnit.TextAlign = System.Drawing.ContentAlignment.TopRight;
	    // 
	    // lblCurrentHeartRateHr
	    // 
	    this.lblCurrentHeartRateHr.AutoSize = true;
	    this.lblCurrentHeartRateHr.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.lblCurrentHeartRateHr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.lblCurrentHeartRateHr.ForeColor = System.Drawing.Color.White;
	    this.lblCurrentHeartRateHr.Location = new System.Drawing.Point(0, 0);
	    this.lblCurrentHeartRateHr.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
	    this.lblCurrentHeartRateHr.Name = "lblCurrentHeartRateHr";
	    this.lblCurrentHeartRateHr.Size = new System.Drawing.Size(95, 41);
	    this.lblCurrentHeartRateHr.TabIndex = 16;
	    this.lblCurrentHeartRateHr.Text = "HR";
	    // 
	    // timer
	    // 
	    this.timer.Interval = 1000;
	    this.timer.Tick += new System.EventHandler(this.timer_Tick);
	    // 
	    // frmMain
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
	    this.ClientSize = new System.Drawing.Size(1124, 666);
	    this.Controls.Add(this.tlpMain);
	    this.HelpButton = true;
	    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
	    this.Name = "frmMain";
	    this.Text = " Heart rate monitor";
	    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
	    this.tlpMain.ResumeLayout(false);
	    this.tlpMain.PerformLayout();
	    this.gbxUserAge.ResumeLayout(false);
	    this.tlpUserAge.ResumeLayout(false);
	    this.tlpUserAge.PerformLayout();
	    this.gbxElapsedTime.ResumeLayout(false);
	    this.tlpElapsedTime.ResumeLayout(false);
	    this.tlpElapsedTime.PerformLayout();
	    this.gbxHeartRateLevel.ResumeLayout(false);
	    this.tlpHeartRateLevel.ResumeLayout(false);
	    this.gbxHearRatePerMinute.ResumeLayout(false);
	    this.tlpHeartRatePerMinute.ResumeLayout(false);
	    this.tlpHeartRatePerMinute.PerformLayout();
	    this.mstApplication.ResumeLayout(false);
	    this.mstApplication.PerformLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.crtHeartBeat)).EndInit();
	    this.tlpBottom.ResumeLayout(false);
	    this.gbxCurrentHeartRate.ResumeLayout(false);
	    this.tlpCurrentHeartRate.ResumeLayout(false);
	    this.tlpCurrentHeartRate.PerformLayout();
	    this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.TableLayoutPanel tlpMain;
	private System.Windows.Forms.MenuStrip mstApplication;
	private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
	private System.Windows.Forms.Label lblInformation;
	private System.Windows.Forms.DataVisualization.Charting.Chart crtHeartBeat;
	private System.Windows.Forms.GroupBox gbxCurrentHeartRate;
	private System.Windows.Forms.TableLayoutPanel tlpBottom;
	private System.Windows.Forms.GroupBox gbxUserAge;
	private System.Windows.Forms.GroupBox gbxElapsedTime;
	private System.Windows.Forms.GroupBox gbxHeartRateLevel;
	private System.Windows.Forms.GroupBox gbxHearRatePerMinute;
	private System.Windows.Forms.TableLayoutPanel tlpCurrentHeartRate;
	private System.Windows.Forms.TableLayoutPanel tlpUserAge;
	private System.Windows.Forms.TableLayoutPanel tlpElapsedTime;
	private System.Windows.Forms.TableLayoutPanel tlpHeartRateLevel;
	private System.Windows.Forms.TableLayoutPanel tlpHeartRatePerMinute;
	private System.Windows.Forms.Label lblHrPerMinute;
	private System.Windows.Forms.Label lblCurrentHeartRateHr;
	private System.Windows.Forms.Label lblCurrentHeartRateUnit;
	private System.Windows.Forms.Label lblCurrentlHeartRate;
	private System.Windows.Forms.Label lblHeartRatePerMinuteUnit;
	private System.Windows.Forms.Label lblHeartRatePerMinute;
	private System.Windows.Forms.Label lblHeartRateLevelTitle;
	private System.Windows.Forms.Label lblHeartRateLevel;
	private System.Windows.Forms.Label lblElapsedTimeTitle;
	private System.Windows.Forms.Label lblElapsedTime;
	private System.Windows.Forms.Label lblUserAgeTitle;
	private System.Windows.Forms.TextBox tbxUserAge;
	private System.Windows.Forms.Button btnEnd;
	private System.Windows.Forms.Button btnStart;
	private System.Windows.Forms.Timer timer;
    }
}


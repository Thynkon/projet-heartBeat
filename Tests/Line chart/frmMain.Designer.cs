namespace graphics_test
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.crtHeartBeats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.crtHeartBeats)).BeginInit();
            this.SuspendLayout();
            // 
            // crtHeartBeats
            // 
            chartArea2.Name = "ChartArea1";
            this.crtHeartBeats.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crtHeartBeats.Legends.Add(legend2);
            this.crtHeartBeats.Location = new System.Drawing.Point(2, 2);
            this.crtHeartBeats.Name = "crtHeartBeats";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.crtHeartBeats.Series.Add(series2);
            this.crtHeartBeats.Size = new System.Drawing.Size(797, 439);
            this.crtHeartBeats.TabIndex = 0;
            this.crtHeartBeats.Text = "chart1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(681, 133);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.crtHeartBeats);
            this.Name = "frmMain";
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.crtHeartBeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtHeartBeats;
        private System.Windows.Forms.Button btnStart;
    }
}


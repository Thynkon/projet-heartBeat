namespace Tests_regex
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
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAfficherNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(38, 79);
            this.tbxNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(241, 22);
            this.tbxNumber.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(104, 30);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(111, 16);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Entrez un nombre";
            // 
            // btnAfficherNombre
            // 
            this.btnAfficherNombre.Location = new System.Drawing.Point(38, 135);
            this.btnAfficherNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfficherNombre.Name = "btnAfficherNombre";
            this.btnAfficherNombre.Size = new System.Drawing.Size(243, 28);
            this.btnAfficherNombre.TabIndex = 2;
            this.btnAfficherNombre.Text = "Afficher le nombre";
            this.btnAfficherNombre.UseVisualStyleBackColor = true;
            this.btnAfficherNombre.Click += new System.EventHandler(this.btnAfficherNombre_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 204);
            this.Controls.Add(this.btnAfficherNombre);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbxNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Tests avec des expressions régulières";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAfficherNombre;
    }
}


namespace FA_Fraktale
{
    partial class FractalWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnSetParams = new System.Windows.Forms.Button();
            this.tbXMin = new System.Windows.Forms.TextBox();
            this.tbXMax = new System.Windows.Forms.TextBox();
            this.tbYMin = new System.Windows.Forms.TextBox();
            this.tbYMax = new System.Windows.Forms.TextBox();
            this.labelXMin = new System.Windows.Forms.Label();
            this.labelYMin = new System.Windows.Forms.Label();
            this.labelXMax = new System.Windows.Forms.Label();
            this.labelYMax = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSetParams
            // 
            this.btnSetParams.Location = new System.Drawing.Point(26, 1179);
            this.btnSetParams.Name = "btnSetParams";
            this.btnSetParams.Size = new System.Drawing.Size(257, 46);
            this.btnSetParams.TabIndex = 1;
            this.btnSetParams.Text = "Setzen";
            this.btnSetParams.UseVisualStyleBackColor = true;
            this.btnSetParams.Click += new System.EventHandler(this.btnSetParams_Click);
            // 
            // tbXMin
            // 
            this.tbXMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXMin.Location = new System.Drawing.Point(87, 1068);
            this.tbXMin.Name = "tbXMin";
            this.tbXMin.Size = new System.Drawing.Size(56, 30);
            this.tbXMin.TabIndex = 2;
            this.tbXMin.Text = "-2,1";
            // 
            // tbXMax
            // 
            this.tbXMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXMax.Location = new System.Drawing.Point(87, 1117);
            this.tbXMax.Name = "tbXMax";
            this.tbXMax.Size = new System.Drawing.Size(56, 30);
            this.tbXMax.TabIndex = 3;
            this.tbXMax.Text = "1";
            // 
            // tbYMin
            // 
            this.tbYMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYMin.Location = new System.Drawing.Point(227, 1068);
            this.tbYMin.Name = "tbYMin";
            this.tbYMin.Size = new System.Drawing.Size(56, 30);
            this.tbYMin.TabIndex = 4;
            this.tbYMin.Text = "-1,3";
            // 
            // tbYMax
            // 
            this.tbYMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYMax.Location = new System.Drawing.Point(227, 1117);
            this.tbYMax.Name = "tbYMax";
            this.tbYMax.Size = new System.Drawing.Size(56, 30);
            this.tbYMax.TabIndex = 5;
            this.tbYMax.Text = "1,3";
            // 
            // labelXMin
            // 
            this.labelXMin.AutoSize = true;
            this.labelXMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXMin.Location = new System.Drawing.Point(21, 1071);
            this.labelXMin.Name = "labelXMin";
            this.labelXMin.Size = new System.Drawing.Size(54, 25);
            this.labelXMin.TabIndex = 6;
            this.labelXMin.Text = "xMin";
            // 
            // labelYMin
            // 
            this.labelYMin.AutoSize = true;
            this.labelYMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYMin.Location = new System.Drawing.Point(161, 1071);
            this.labelYMin.Name = "labelYMin";
            this.labelYMin.Size = new System.Drawing.Size(54, 25);
            this.labelYMin.TabIndex = 7;
            this.labelYMin.Text = "yMin";
            // 
            // labelXMax
            // 
            this.labelXMax.AutoSize = true;
            this.labelXMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXMax.Location = new System.Drawing.Point(21, 1120);
            this.labelXMax.Name = "labelXMax";
            this.labelXMax.Size = new System.Drawing.Size(60, 25);
            this.labelXMax.TabIndex = 8;
            this.labelXMax.Text = "xMax";
            // 
            // labelYMax
            // 
            this.labelYMax.AutoSize = true;
            this.labelYMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYMax.Location = new System.Drawing.Point(161, 1120);
            this.labelYMax.Name = "labelYMax";
            this.labelYMax.Size = new System.Drawing.Size(60, 25);
            this.labelYMax.TabIndex = 9;
            this.labelYMax.Text = "yMax";
            // 
            // imagePanel
            // 
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Location = new System.Drawing.Point(12, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(1558, 1000);
            this.imagePanel.TabIndex = 10;
            this.imagePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseDown);
            this.imagePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseMove);
            this.imagePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseUp);
            // 
            // FractalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1582, 1253);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.labelYMax);
            this.Controls.Add(this.labelXMax);
            this.Controls.Add(this.labelYMin);
            this.Controls.Add(this.labelXMin);
            this.Controls.Add(this.tbYMax);
            this.Controls.Add(this.tbYMin);
            this.Controls.Add(this.tbXMax);
            this.Controls.Add(this.tbXMin);
            this.Controls.Add(this.btnSetParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FractalWindow";
            this.Text = "Facharbeit Fraktale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnSetParams;
        private System.Windows.Forms.TextBox tbXMin;
        private System.Windows.Forms.TextBox tbXMax;
        private System.Windows.Forms.TextBox tbYMin;
        private System.Windows.Forms.TextBox tbYMax;
        private System.Windows.Forms.Label labelXMin;
        private System.Windows.Forms.Label labelYMin;
        private System.Windows.Forms.Label labelXMax;
        private System.Windows.Forms.Label labelYMax;
        private System.Windows.Forms.Panel imagePanel;
    }
}


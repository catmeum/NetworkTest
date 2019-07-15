namespace Network_Test
{
    partial class StartPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SeparationLine = new System.Windows.Forms.PictureBox();
            this.GatewayData = new System.Windows.Forms.Label();
            this.GatewayLabel = new System.Windows.Forms.Label();
            this.IPAddrData = new System.Windows.Forms.Label();
            this.HostnameData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IPAddrLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HostnameLbl = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SeparationLine)).BeginInit();
            this.SuspendLayout();
            // 
            // SeparationLine
            // 
            this.SeparationLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SeparationLine.Location = new System.Drawing.Point(87, 338);
            this.SeparationLine.Name = "SeparationLine";
            this.SeparationLine.Size = new System.Drawing.Size(746, 5);
            this.SeparationLine.TabIndex = 29;
            this.SeparationLine.TabStop = false;
            // 
            // GatewayData
            // 
            this.GatewayData.AutoSize = true;
            this.GatewayData.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GatewayData.Location = new System.Drawing.Point(565, 654);
            this.GatewayData.Name = "GatewayData";
            this.GatewayData.Size = new System.Drawing.Size(174, 48);
            this.GatewayData.TabIndex = 37;
            this.GatewayData.Text = "Gateway";
            // 
            // GatewayLabel
            // 
            this.GatewayLabel.AutoSize = true;
            this.GatewayLabel.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GatewayLabel.Location = new System.Drawing.Point(101, 639);
            this.GatewayLabel.Name = "GatewayLabel";
            this.GatewayLabel.Size = new System.Drawing.Size(432, 63);
            this.GatewayLabel.TabIndex = 36;
            this.GatewayLabel.Text = "Default Gateway:";
            // 
            // IPAddrData
            // 
            this.IPAddrData.AutoSize = true;
            this.IPAddrData.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddrData.Location = new System.Drawing.Point(423, 540);
            this.IPAddrData.Name = "IPAddrData";
            this.IPAddrData.Size = new System.Drawing.Size(215, 48);
            this.IPAddrData.TabIndex = 35;
            this.IPAddrData.Text = "IP Address";
            // 
            // HostnameData
            // 
            this.HostnameData.AutoSize = true;
            this.HostnameData.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostnameData.Location = new System.Drawing.Point(406, 432);
            this.HostnameData.Name = "HostnameData";
            this.HostnameData.Size = new System.Drawing.Size(216, 48);
            this.HostnameData.TabIndex = 34;
            this.HostnameData.Text = "Hostname ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 63);
            this.label3.TabIndex = 32;
            this.label3.Text = "IP Address: ";
            // 
            // IPAddrLbl
            // 
            this.IPAddrLbl.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddrLbl.Location = new System.Drawing.Point(101, 525);
            this.IPAddrLbl.Name = "IPAddrLbl";
            this.IPAddrLbl.Size = new System.Drawing.Size(242, 65);
            this.IPAddrLbl.TabIndex = 33;
            this.IPAddrLbl.Text = "IP Address: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 63);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hostname: ";
            // 
            // HostnameLbl
            // 
            this.HostnameLbl.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostnameLbl.Location = new System.Drawing.Point(101, 417);
            this.HostnameLbl.Name = "HostnameLbl";
            this.HostnameLbl.Size = new System.Drawing.Size(299, 90);
            this.HostnameLbl.TabIndex = 31;
            this.HostnameLbl.Text = "Hostname: ";
            // 
            // StartLabel
            // 
            this.StartLabel.AllowDrop = true;
            this.StartLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartLabel.Font = new System.Drawing.Font("Source Sans Pro Semibold", 33F, System.Drawing.FontStyle.Bold);
            this.StartLabel.Location = new System.Drawing.Point(0, 0);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(904, 300);
            this.StartLabel.TabIndex = 39;
            this.StartLabel.Text = "START TESTING YOUR NETWORK";
            this.StartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LimeGreen;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(165, 812);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(559, 107);
            this.StartButton.TabIndex = 41;
            this.StartButton.Text = "Go";
            this.StartButton.UseVisualStyleBackColor = false;
            // 
            // StartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.SeparationLine);
            this.Controls.Add(this.GatewayData);
            this.Controls.Add(this.GatewayLabel);
            this.Controls.Add(this.IPAddrData);
            this.Controls.Add(this.HostnameData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IPAddrLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostnameLbl);
            this.Name = "StartPanel";
            this.Size = new System.Drawing.Size(904, 1019);
            ((System.ComponentModel.ISupportInitialize)(this.SeparationLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SeparationLine;
        private System.Windows.Forms.Label GatewayData;
        private System.Windows.Forms.Label GatewayLabel;
        private System.Windows.Forms.Label IPAddrData;
        private System.Windows.Forms.Label HostnameData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IPAddrLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HostnameLbl;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Button StartButton;
    }
}

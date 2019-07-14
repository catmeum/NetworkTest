namespace Network_Test
{
    partial class StartPage
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
            this.StartLabel = new System.Windows.Forms.Label();
            this.SeparationLine = new System.Windows.Forms.PictureBox();
            this.HostnameLbl = new System.Windows.Forms.Label();
            this.IPAddrLbl = new System.Windows.Forms.Label();
            this.MACAddrLbl = new System.Windows.Forms.Label();
            this.HDSpaceLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HostnameData = new System.Windows.Forms.Label();
            this.IPAddrData = new System.Windows.Forms.Label();
            this.MACAddrData = new System.Windows.Forms.Label();
            this.HDData = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.GatewayLabel = new System.Windows.Forms.Label();
            this.GatewayData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SeparationLine)).BeginInit();
            this.SuspendLayout();
            // 
            // StartLabel
            // 
            this.StartLabel.AllowDrop = true;
            this.StartLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartLabel.Font = new System.Drawing.Font("Source Sans Pro", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.Location = new System.Drawing.Point(0, 0);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(1198, 376);
            this.StartLabel.TabIndex = 0;
            this.StartLabel.Text = "START TESTING YOUR NETWORK";
            this.StartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // SeparationLine
            // 
            this.SeparationLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SeparationLine.Location = new System.Drawing.Point(224, 406);
            this.SeparationLine.Name = "SeparationLine";
            this.SeparationLine.Size = new System.Drawing.Size(746, 5);
            this.SeparationLine.TabIndex = 1;
            this.SeparationLine.TabStop = false;
            // 
            // HostnameLbl
            // 
            this.HostnameLbl.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostnameLbl.Location = new System.Drawing.Point(120, 450);
            this.HostnameLbl.Name = "HostnameLbl";
            this.HostnameLbl.Size = new System.Drawing.Size(299, 90);
            this.HostnameLbl.TabIndex = 3;
            this.HostnameLbl.Text = "Hostname: ";
            // 
            // IPAddrLbl
            // 
            this.IPAddrLbl.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddrLbl.Location = new System.Drawing.Point(120, 527);
            this.IPAddrLbl.Name = "IPAddrLbl";
            this.IPAddrLbl.Size = new System.Drawing.Size(242, 65);
            this.IPAddrLbl.TabIndex = 5;
            this.IPAddrLbl.Text = "IP Address: ";
            // 
            // MACAddrLbl
            // 
            this.MACAddrLbl.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MACAddrLbl.Location = new System.Drawing.Point(120, 685);
            this.MACAddrLbl.Name = "MACAddrLbl";
            this.MACAddrLbl.Size = new System.Drawing.Size(320, 65);
            this.MACAddrLbl.TabIndex = 6;
            this.MACAddrLbl.Text = "MAC Address: ";
            // 
            // HDSpaceLbl
            // 
            this.HDSpaceLbl.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDSpaceLbl.Location = new System.Drawing.Point(120, 770);
            this.HDSpaceLbl.Name = "HDSpaceLbl";
            this.HDSpaceLbl.Size = new System.Drawing.Size(386, 65);
            this.HDSpaceLbl.TabIndex = 7;
            this.HDSpaceLbl.Text = "Hard Drive Space: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hostname: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 63);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP Address: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 685);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 63);
            this.label4.TabIndex = 6;
            this.label4.Text = "MAC Address: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 770);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(466, 63);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hard Drive Space: ";
            // 
            // HostnameData
            // 
            this.HostnameData.AutoSize = true;
            this.HostnameData.Font = new System.Drawing.Font("Roboto", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostnameData.Location = new System.Drawing.Point(415, 455);
            this.HostnameData.Name = "HostnameData";
            this.HostnameData.Size = new System.Drawing.Size(258, 58);
            this.HostnameData.TabIndex = 11;
            this.HostnameData.Text = "Hostname ";
            this.HostnameData.Click += new System.EventHandler(this.Label6_Click);
            // 
            // IPAddrData
            // 
            this.IPAddrData.AutoSize = true;
            this.IPAddrData.Font = new System.Drawing.Font("Roboto", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddrData.Location = new System.Drawing.Point(432, 532);
            this.IPAddrData.Name = "IPAddrData";
            this.IPAddrData.Size = new System.Drawing.Size(256, 58);
            this.IPAddrData.TabIndex = 13;
            this.IPAddrData.Text = "IP Address";
            // 
            // MACAddrData
            // 
            this.MACAddrData.AutoSize = true;
            this.MACAddrData.Font = new System.Drawing.Font("Roboto", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MACAddrData.Location = new System.Drawing.Point(495, 690);
            this.MACAddrData.Name = "MACAddrData";
            this.MACAddrData.Size = new System.Drawing.Size(317, 58);
            this.MACAddrData.TabIndex = 14;
            this.MACAddrData.Text = "MAC Address";
            // 
            // HDData
            // 
            this.HDData.AutoSize = true;
            this.HDData.Font = new System.Drawing.Font("Roboto", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDData.Location = new System.Drawing.Point(592, 775);
            this.HDData.Name = "HDData";
            this.HDData.Size = new System.Drawing.Size(390, 58);
            this.HDData.TabIndex = 15;
            this.HDData.Text = "Hard Drive Space";
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartButton.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(298, 1064);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(581, 170);
            this.StartButton.TabIndex = 17;
            this.StartButton.Text = "Go";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GatewayLabel
            // 
            this.GatewayLabel.AutoSize = true;
            this.GatewayLabel.Font = new System.Drawing.Font("Roboto", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GatewayLabel.Location = new System.Drawing.Point(120, 605);
            this.GatewayLabel.Name = "GatewayLabel";
            this.GatewayLabel.Size = new System.Drawing.Size(247, 63);
            this.GatewayLabel.TabIndex = 18;
            this.GatewayLabel.Text = "Gateway:";
            this.GatewayLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // GatewayData
            // 
            this.GatewayData.AutoSize = true;
            this.GatewayData.Font = new System.Drawing.Font("Roboto", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GatewayData.Location = new System.Drawing.Point(373, 610);
            this.GatewayData.Name = "GatewayData";
            this.GatewayData.Size = new System.Drawing.Size(210, 58);
            this.GatewayData.TabIndex = 19;
            this.GatewayData.Text = "Gateway";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1198, 1512);
            this.Controls.Add(this.GatewayData);
            this.Controls.Add(this.GatewayLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.HDData);
            this.Controls.Add(this.MACAddrData);
            this.Controls.Add(this.IPAddrData);
            this.Controls.Add(this.HostnameData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HDSpaceLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MACAddrLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IPAddrLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostnameLbl);
            this.Controls.Add(this.SeparationLine);
            this.Controls.Add(this.StartLabel);
            this.Name = "StartPage";
            this.Text = "Network Tester";
            ((System.ComponentModel.ISupportInitialize)(this.SeparationLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.PictureBox SeparationLine;
        private System.Windows.Forms.Label HostnameLbl;
        private System.Windows.Forms.Label IPAddrLbl;
        private System.Windows.Forms.Label MACAddrLbl;
        private System.Windows.Forms.Label HDSpaceLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label HostnameData;
        private System.Windows.Forms.Label IPAddrData;
        private System.Windows.Forms.Label MACAddrData;
        private System.Windows.Forms.Label HDData;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label GatewayLabel;
        private System.Windows.Forms.Label GatewayData;
    }
}


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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.startPanel1 = new Network_Test.StartPanel();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.startPanel1);
            this.Panel1.Location = new System.Drawing.Point(-4, -2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1018, 1083);
            this.Panel1.TabIndex = 20;
            // 
            // startPanel1
            // 
            this.startPanel1.BackColor = System.Drawing.Color.White;
            this.startPanel1.Location = new System.Drawing.Point(35, 31);
            this.startPanel1.Name = "startPanel1";
            this.startPanel1.Size = new System.Drawing.Size(947, 1037);
            this.startPanel1.TabIndex = 0;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1015, 1078);
            this.Controls.Add(this.Panel1);
            this.Name = "StartPage";
            this.Text = "Network Tester";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel1;
        private StartPanel startPanel1;
    }
}


namespace Network_Test
{
    partial class Testing_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testing_Panel));
            this.StartLabel = new System.Windows.Forms.Label();
            this.LoadingPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // StartLabel
            // 
            this.StartLabel.AllowDrop = true;
            this.StartLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartLabel.Font = new System.Drawing.Font("Source Sans Pro Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.StartLabel.Location = new System.Drawing.Point(0, 0);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(982, 354);
            this.StartLabel.TabIndex = 2;
            this.StartLabel.Text = "TESTING PLACEHOLDER";
            this.StartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingPic
            // 
            this.LoadingPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadingPic.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPic.Image")));
            this.LoadingPic.Location = new System.Drawing.Point(189, 330);
            this.LoadingPic.Name = "LoadingPic";
            this.LoadingPic.Size = new System.Drawing.Size(600, 600);
            this.LoadingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoadingPic.TabIndex = 3;
            this.LoadingPic.TabStop = false;
            // 
            // Testing_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoadingPic);
            this.Controls.Add(this.StartLabel);
            this.Name = "Testing_Panel";
            this.Size = new System.Drawing.Size(982, 1133);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.PictureBox LoadingPic;
    }
}

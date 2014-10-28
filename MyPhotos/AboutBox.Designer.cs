namespace MyPhotos
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.lblIcon = new System.Windows.Forms.PictureBox();
            this.lblAboutText = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lblIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIcon
            // 
            this.lblIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblIcon.Image")));
            this.lblIcon.Location = new System.Drawing.Point(12, 12);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(54, 54);
            this.lblIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblIcon.TabIndex = 0;
            this.lblIcon.TabStop = false;
            // 
            // lblAboutText
            // 
            this.lblAboutText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutText.Location = new System.Drawing.Point(90, 12);
            this.lblAboutText.Multiline = true;
            this.lblAboutText.Name = "lblAboutText";
            this.lblAboutText.ReadOnly = true;
            this.lblAboutText.Size = new System.Drawing.Size(282, 54);
            this.lblAboutText.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(152, 76);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 106);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAboutText);
            this.Controls.Add(this.lblIcon);
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About MyPhotos";
            ((System.ComponentModel.ISupportInitialize)(this.lblIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblIcon;
        private System.Windows.Forms.TextBox lblAboutText;
        private System.Windows.Forms.Button btnClose;
    }
}
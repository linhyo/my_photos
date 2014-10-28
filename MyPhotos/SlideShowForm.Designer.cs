namespace MyPhotos
{
    partial class SlideShowForm
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
            this.pboxSlide = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.trackSlide = new System.Windows.Forms.TrackBar();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxSlide
            // 
            this.pboxSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxSlide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxSlide.Location = new System.Drawing.Point(12, 12);
            this.pboxSlide.Name = "pboxSlide";
            this.pboxSlide.Size = new System.Drawing.Size(260, 186);
            this.pboxSlide.TabIndex = 0;
            this.pboxSlide.TabStop = false;
            this.pboxSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxSlide_Paint);
            this.pboxSlide.Resize += new System.EventHandler(this.pboxSlide_Resize);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Interval";
            // 
            // txtInterval
            // 
            this.txtInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInterval.Location = new System.Drawing.Point(60, 210);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(37, 20);
            this.txtInterval.TabIndex = 2;
            this.txtInterval.Text = "2";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(135, 208);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(212, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // trackSlide
            // 
            this.trackSlide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackSlide.Location = new System.Drawing.Point(12, 245);
            this.trackSlide.Name = "trackSlide";
            this.trackSlide.Size = new System.Drawing.Size(260, 45);
            this.trackSlide.TabIndex = 5;
            this.trackSlide.Scroll += new System.EventHandler(this.trackSlide_Scroll);
            // 
            // slideTimer
            // 
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
            // 
            // SlideShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.ControlBox = false;
            this.Controls.Add(this.trackSlide);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxSlide);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SlideShowForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SlideShowForm";
            ((System.ComponentModel.ISupportInitialize)(this.pboxSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSlide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxSlide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TrackBar trackSlide;
        private System.Windows.Forms.Timer slideTimer;
    }
}
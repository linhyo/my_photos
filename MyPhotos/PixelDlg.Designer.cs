namespace MyPhotos
{
    partial class PixelDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixelDlg));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblXVal = new System.Windows.Forms.Label();
            this.lblYVal = new System.Windows.Forms.Label();
            this.lblRedVal = new System.Windows.Forms.Label();
            this.lblGreenVal = new System.Windows.Forms.Label();
            this.lblBlueVal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Red";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Green";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Blue";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblXVal
            // 
            this.lblXVal.AutoSize = true;
            this.lblXVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblXVal.Location = new System.Drawing.Point(73, 9);
            this.lblXVal.Name = "lblXVal";
            this.lblXVal.Size = new System.Drawing.Size(37, 15);
            this.lblXVal.TabIndex = 5;
            this.lblXVal.Text = "label6";
            // 
            // lblYVal
            // 
            this.lblYVal.AutoSize = true;
            this.lblYVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYVal.Location = new System.Drawing.Point(73, 44);
            this.lblYVal.Name = "lblYVal";
            this.lblYVal.Size = new System.Drawing.Size(37, 15);
            this.lblYVal.TabIndex = 6;
            this.lblYVal.Text = "label7";
            // 
            // lblRedVal
            // 
            this.lblRedVal.AutoSize = true;
            this.lblRedVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRedVal.Location = new System.Drawing.Point(73, 79);
            this.lblRedVal.Name = "lblRedVal";
            this.lblRedVal.Size = new System.Drawing.Size(37, 15);
            this.lblRedVal.TabIndex = 7;
            this.lblRedVal.Text = "label8";
            // 
            // lblGreenVal
            // 
            this.lblGreenVal.AutoSize = true;
            this.lblGreenVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGreenVal.Location = new System.Drawing.Point(73, 114);
            this.lblGreenVal.Name = "lblGreenVal";
            this.lblGreenVal.Size = new System.Drawing.Size(37, 15);
            this.lblGreenVal.TabIndex = 8;
            this.lblGreenVal.Text = "label9";
            // 
            // lblBlueVal
            // 
            this.lblBlueVal.AutoSize = true;
            this.lblBlueVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlueVal.Location = new System.Drawing.Point(73, 149);
            this.lblBlueVal.Name = "lblBlueVal";
            this.lblBlueVal.Size = new System.Drawing.Size(43, 15);
            this.lblBlueVal.TabIndex = 9;
            this.lblBlueVal.Text = "label10";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(32, 173);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PixelDlg
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(144, 202);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblBlueVal);
            this.Controls.Add(this.lblGreenVal);
            this.Controls.Add(this.lblRedVal);
            this.Controls.Add(this.lblYVal);
            this.Controls.Add(this.lblXVal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PixelDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixel Values";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblXVal;
        private System.Windows.Forms.Label lblYVal;
        private System.Windows.Forms.Label lblRedVal;
        private System.Windows.Forms.Label lblGreenVal;
        private System.Windows.Forms.Label lblBlueVal;
        private System.Windows.Forms.Button btnClose;
    }
}
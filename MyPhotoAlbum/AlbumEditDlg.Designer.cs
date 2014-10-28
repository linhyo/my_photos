namespace Manning.MyPhotoAlbum
{
    partial class AlbumEditDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlbumFile = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.rbtnCaption = new System.Windows.Forms.RadioButton();
            this.rbtnFileName = new System.Windows.Forms.RadioButton();
            this.cbtnPassword = new System.Windows.Forms.CheckBox();
            this.txtAlbumPwd = new System.Windows.Forms.TextBox();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtAlbumFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(270, 77);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album &File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlbumFile
            // 
            this.txtAlbumFile.Location = new System.Drawing.Point(77, 14);
            this.txtAlbumFile.Name = "txtAlbumFile";
            this.txtAlbumFile.ReadOnly = true;
            this.txtAlbumFile.Size = new System.Drawing.Size(177, 20);
            this.txtAlbumFile.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(77, 44);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(177, 20);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDate);
            this.groupBox1.Controls.Add(this.rbtnCaption);
            this.groupBox1.Controls.Add(this.rbtnFileName);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phot&o Display Text.";
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(195, 19);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(48, 17);
            this.rbtnDate.TabIndex = 2;
            this.rbtnDate.TabStop = true;
            this.rbtnDate.Text = "&Date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            this.rbtnDate.Click += new System.EventHandler(this.DisplayOption_Click);
            // 
            // rbtnCaption
            // 
            this.rbtnCaption.AutoSize = true;
            this.rbtnCaption.Location = new System.Drawing.Point(111, 19);
            this.rbtnCaption.Name = "rbtnCaption";
            this.rbtnCaption.Size = new System.Drawing.Size(61, 17);
            this.rbtnCaption.TabIndex = 1;
            this.rbtnCaption.TabStop = true;
            this.rbtnCaption.Text = "Ca&ption";
            this.rbtnCaption.UseVisualStyleBackColor = true;
            this.rbtnCaption.Click += new System.EventHandler(this.DisplayOption_Click);
            // 
            // rbtnFileName
            // 
            this.rbtnFileName.AutoSize = true;
            this.rbtnFileName.Location = new System.Drawing.Point(20, 19);
            this.rbtnFileName.Name = "rbtnFileName";
            this.rbtnFileName.Size = new System.Drawing.Size(70, 17);
            this.rbtnFileName.TabIndex = 0;
            this.rbtnFileName.TabStop = true;
            this.rbtnFileName.Text = "File &name";
            this.rbtnFileName.UseVisualStyleBackColor = true;
            this.rbtnFileName.Click += new System.EventHandler(this.DisplayOption_Click);
            // 
            // cbtnPassword
            // 
            this.cbtnPassword.AutoSize = true;
            this.cbtnPassword.Location = new System.Drawing.Point(32, 174);
            this.cbtnPassword.Name = "cbtnPassword";
            this.cbtnPassword.Size = new System.Drawing.Size(112, 17);
            this.cbtnPassword.TabIndex = 4;
            this.cbtnPassword.Text = "Require &Password";
            this.cbtnPassword.UseVisualStyleBackColor = true;
            this.cbtnPassword.CheckedChanged += new System.EventHandler(this.cbtnPassword_CheckedChanged);
            // 
            // txtAlbumPwd
            // 
            this.txtAlbumPwd.Enabled = false;
            this.txtAlbumPwd.Location = new System.Drawing.Point(150, 172);
            this.txtAlbumPwd.Name = "txtAlbumPwd";
            this.txtAlbumPwd.PasswordChar = '*';
            this.txtAlbumPwd.Size = new System.Drawing.Size(117, 20);
            this.txtAlbumPwd.TabIndex = 6;
            this.txtAlbumPwd.Validating += new System.ComponentModel.CancelEventHandler(this.txtAlbumPwd_Validating);
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.Enabled = false;
            this.lblConfirmPwd.Location = new System.Drawing.Point(51, 205);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPwd.TabIndex = 7;
            this.lblConfirmPwd.Text = "Confir&m Password";
            this.lblConfirmPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Enabled = false;
            this.txtConfirmPwd.Location = new System.Drawing.Point(150, 202);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = 'x';
            this.txtConfirmPwd.Size = new System.Drawing.Size(117, 20);
            this.txtConfirmPwd.TabIndex = 8;
            // 
            // AlbumEditDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 292);
            this.Controls.Add(this.txtConfirmPwd);
            this.Controls.Add(this.lblConfirmPwd);
            this.Controls.Add(this.txtAlbumPwd);
            this.Controls.Add(this.cbtnPassword);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlbumEditDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album Properties";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cbtnPassword, 0);
            this.Controls.SetChildIndex(this.txtAlbumPwd, 0);
            this.Controls.SetChildIndex(this.lblConfirmPwd, 0);
            this.Controls.SetChildIndex(this.txtConfirmPwd, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAlbumFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.RadioButton rbtnCaption;
        private System.Windows.Forms.RadioButton rbtnFileName;
        private System.Windows.Forms.CheckBox cbtnPassword;
        private System.Windows.Forms.TextBox txtAlbumPwd;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.TextBox txtConfirmPwd;
    }
}
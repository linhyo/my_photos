namespace MyAlbumData
{
    partial class MainForm
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
            this.cmbxAlbum = new System.Windows.Forms.ComboBox();
            this.gridPhotoAlbum = new System.Windows.Forms.DataGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabAlbum = new System.Windows.Forms.TabPage();
            this.tabPhoto = new System.Windows.Forms.TabPage();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateTaken = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhotographer = new System.Windows.Forms.TextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pboxPhoto = new System.Windows.Forms.PictureBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tabAlbum.SuspendLayout();
            this.tabPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Album";
            // 
            // cmbxAlbum
            // 
            this.cmbxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxAlbum.FormattingEnabled = true;
            this.cmbxAlbum.Location = new System.Drawing.Point(73, 11);
            this.cmbxAlbum.Name = "cmbxAlbum";
            this.cmbxAlbum.Size = new System.Drawing.Size(234, 21);
            this.cmbxAlbum.TabIndex = 1;
            this.cmbxAlbum.SelectedIndexChanged += new System.EventHandler(this.cmbxAlbum_SelectedIndexChanged);
            // 
            // gridPhotoAlbum
            // 
            this.gridPhotoAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPhotoAlbum.DataMember = "";
            this.gridPhotoAlbum.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.gridPhotoAlbum.Location = new System.Drawing.Point(0, 0);
            this.gridPhotoAlbum.Name = "gridPhotoAlbum";
            this.gridPhotoAlbum.Size = new System.Drawing.Size(402, 209);
            this.gridPhotoAlbum.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(347, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tabAlbum);
            this.tcMain.Controls.Add(this.tabPhoto);
            this.tcMain.Location = new System.Drawing.Point(12, 44);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(410, 231);
            this.tcMain.TabIndex = 4;
            // 
            // tabAlbum
            // 
            this.tabAlbum.Controls.Add(this.gridPhotoAlbum);
            this.tabAlbum.Location = new System.Drawing.Point(4, 22);
            this.tabAlbum.Name = "tabAlbum";
            this.tabAlbum.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlbum.Size = new System.Drawing.Size(402, 205);
            this.tabAlbum.TabIndex = 0;
            this.tabAlbum.Text = "Album";
            this.tabAlbum.UseVisualStyleBackColor = true;
            // 
            // tabPhoto
            // 
            this.tabPhoto.Controls.Add(this.txtNotes);
            this.tabPhoto.Controls.Add(this.label6);
            this.tabPhoto.Controls.Add(this.dtpDateTaken);
            this.tabPhoto.Controls.Add(this.label5);
            this.tabPhoto.Controls.Add(this.label4);
            this.tabPhoto.Controls.Add(this.txtPhotographer);
            this.tabPhoto.Controls.Add(this.txtCaption);
            this.tabPhoto.Controls.Add(this.label3);
            this.tabPhoto.Controls.Add(this.btnNext);
            this.tabPhoto.Controls.Add(this.btnPrev);
            this.tabPhoto.Controls.Add(this.pboxPhoto);
            this.tabPhoto.Controls.Add(this.txtFileName);
            this.tabPhoto.Controls.Add(this.label2);
            this.tabPhoto.Location = new System.Drawing.Point(4, 22);
            this.tabPhoto.Name = "tabPhoto";
            this.tabPhoto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhoto.Size = new System.Drawing.Size(402, 205);
            this.tabPhoto.TabIndex = 1;
            this.tabPhoto.Text = "Photo";
            this.tabPhoto.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(193, 147);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(199, 52);
            this.txtNotes.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Note&s";
            // 
            // dtpDateTaken
            // 
            this.dtpDateTaken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateTaken.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTaken.Location = new System.Drawing.Point(265, 95);
            this.dtpDateTaken.Name = "dtpDateTaken";
            this.dtpDateTaken.Size = new System.Drawing.Size(127, 20);
            this.dtpDateTaken.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "&Date Taken";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Photographer";
            // 
            // txtPhotographer
            // 
            this.txtPhotographer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhotographer.Location = new System.Drawing.Point(265, 67);
            this.txtPhotographer.Name = "txtPhotographer";
            this.txtPhotographer.Size = new System.Drawing.Size(127, 20);
            this.txtPhotographer.TabIndex = 5;
            // 
            // txtCaption
            // 
            this.txtCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaption.Location = new System.Drawing.Point(265, 37);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(127, 20);
            this.txtCaption.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Captio&n";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(105, 178);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Nex&t";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Location = new System.Drawing.Point(9, 178);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(60, 23);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "Pre&v";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pboxPhoto
            // 
            this.pboxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxPhoto.Location = new System.Drawing.Point(9, 37);
            this.pboxPhoto.Name = "pboxPhoto";
            this.pboxPhoto.Size = new System.Drawing.Size(156, 133);
            this.pboxPhoto.TabIndex = 2;
            this.pboxPhoto.TabStop = false;
            this.pboxPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxPhoto_Paint);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(86, 8);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(306, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&File Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 312);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbxAlbum);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAlbumData";
            ((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tabAlbum.ResumeLayout(false);
            this.tabPhoto.ResumeLayout(false);
            this.tabPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxAlbum;
        private System.Windows.Forms.DataGrid gridPhotoAlbum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabAlbum;
        private System.Windows.Forms.TabPage tabPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhotographer;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.PictureBox pboxPhoto;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateTaken;
        private System.Windows.Forms.Label label5;
    }
}


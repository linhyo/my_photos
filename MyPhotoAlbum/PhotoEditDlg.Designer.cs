namespace Manning.MyPhotoAlbum
{
    partial class PhotoEditDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoEditDlg));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhotoFile = new System.Windows.Forms.TextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cmbxPhotographer = new System.Windows.Forms.ComboBox();
            this.dtpDateTaken = new System.Windows.Forms.DateTimePicker();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.toolTipPhotos = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDateTaken);
            this.panel1.Controls.Add(this.cmbxPhotographer);
            this.panel1.Controls.Add(this.txtCaption);
            this.panel1.Controls.Add(this.txtPhotoFile);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Photo &File:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cap&tion:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Date Taken:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Photographer:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhotoFile
            // 
            this.txtPhotoFile.Location = new System.Drawing.Point(83, 10);
            this.txtPhotoFile.Name = "txtPhotoFile";
            this.txtPhotoFile.ReadOnly = true;
            this.txtPhotoFile.Size = new System.Drawing.Size(171, 20);
            this.txtPhotoFile.TabIndex = 1;
            this.toolTipPhotos.SetToolTip(this.txtPhotoFile, "Image file containing photo");
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(83, 43);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(171, 20);
            this.txtCaption.TabIndex = 3;
            this.toolTipPhotos.SetToolTip(this.txtCaption, "Short caption for photo");
            this.txtCaption.TextChanged += new System.EventHandler(this.txtCaption_TextChanged);
            this.txtCaption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaption_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.Location = new System.Drawing.Point(12, 194);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(270, 57);
            this.txtNotes.TabIndex = 5;
            this.toolTipPhotos.SetToolTip(this.txtNotes, "Details about this photo");
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // cmbxPhotographer
            // 
            this.cmbxPhotographer.FormattingEnabled = true;
            this.cmbxPhotographer.Location = new System.Drawing.Point(83, 109);
            this.cmbxPhotographer.MaxDropDownItems = 4;
            this.cmbxPhotographer.Name = "cmbxPhotographer";
            this.cmbxPhotographer.Size = new System.Drawing.Size(171, 21);
            this.cmbxPhotographer.Sorted = true;
            this.cmbxPhotographer.TabIndex = 7;
            this.cmbxPhotographer.Text = "photographer";
            this.toolTipPhotos.SetToolTip(this.cmbxPhotographer, "Person who took photo");
            this.cmbxPhotographer.TextChanged += new System.EventHandler(this.cmbxPhotographer_TextChanged);
            this.cmbxPhotographer.Validated += new System.EventHandler(this.cmbxPhotographer_Validated);
            // 
            // dtpDateTaken
            // 
            this.dtpDateTaken.CustomFormat = "MM/dd/yy \'at\' hh:mm tt";
            this.dtpDateTaken.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTaken.Location = new System.Drawing.Point(83, 76);
            this.dtpDateTaken.Name = "dtpDateTaken";
            this.dtpDateTaken.Size = new System.Drawing.Size(170, 20);
            this.dtpDateTaken.TabIndex = 5;
            this.toolTipPhotos.SetToolTip(this.dtpDateTaken, "When photo was taken");
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(222, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 20);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "N&ext";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipPhotos.SetToolTip(this.btnNext, "Next photo");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(146, 6);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(60, 20);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Pre&v";
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipPhotos.SetToolTip(this.btnPrev, "Previous photo");
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // PhotoEditDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 292);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label5);
            this.Name = "PhotoEditDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Properties.";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNotes, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnPrev, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.TextBox txtPhotoFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbxPhotographer;
        private System.Windows.Forms.DateTimePicker dtpDateTaken;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ToolTip toolTipPhotos;
    }
}
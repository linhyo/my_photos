namespace MyAlbumEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxAlbums = new System.Windows.Forms.ComboBox();
            this.btnAlbumProp = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.ctxtPhotoList = new System.Windows.Forms.ContextMenu();
            this.menuThumbs = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuImages = new System.Windows.Forms.MenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcPhotos = new System.Windows.Forms.TabControl();
            this.tabPhotos = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnPhotoProp = new System.Windows.Forms.Button();
            this.lstPhotos = new System.Windows.Forms.ListBox();
            this.tabDates = new System.Windows.Forms.TabPage();
            this.monthCalDates = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            this.tcPhotos.SuspendLayout();
            this.tabPhotos.SuspendLayout();
            this.tabDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbxAlbums);
            this.groupBox1.Controls.Add(this.btnAlbumProp);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Albums";
            // 
            // cmbxAlbums
            // 
            this.cmbxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxAlbums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAlbums.FormattingEnabled = true;
            this.cmbxAlbums.Location = new System.Drawing.Point(6, 19);
            this.cmbxAlbums.Name = "cmbxAlbums";
            this.cmbxAlbums.Size = new System.Drawing.Size(235, 21);
            this.cmbxAlbums.Sorted = true;
            this.cmbxAlbums.TabIndex = 3;
            this.cmbxAlbums.SelectedIndexChanged += new System.EventHandler(this.cmbxAlbums_SelectedIndexChanged);
            // 
            // btnAlbumProp
            // 
            this.btnAlbumProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlbumProp.Enabled = false;
            this.btnAlbumProp.Location = new System.Drawing.Point(305, 18);
            this.btnAlbumProp.Name = "btnAlbumProp";
            this.btnAlbumProp.Size = new System.Drawing.Size(75, 23);
            this.btnAlbumProp.TabIndex = 2;
            this.btnAlbumProp.Text = "Propertie&s";
            this.btnAlbumProp.UseVisualStyleBackColor = true;
            this.btnAlbumProp.Click += new System.EventHandler(this.btnAlbumProp_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(247, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(52, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ctxtPhotoList
            // 
            this.ctxtPhotoList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuThumbs,
            this.menuItem1,
            this.menuImages});
            // 
            // menuThumbs
            // 
            this.menuThumbs.Index = 0;
            this.menuThumbs.Text = "&Thumbnail";
            this.menuThumbs.Click += new System.EventHandler(this.menuThumbs_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "-";
            // 
            // menuImages
            // 
            this.menuImages.Index = 2;
            this.menuImages.Text = "&Images…";
            this.menuImages.Click += new System.EventHandler(this.menuImages_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(167, 252);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tcPhotos
            // 
            this.tcPhotos.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPhotos.Controls.Add(this.tabPhotos);
            this.tcPhotos.Controls.Add(this.tabDates);
            this.tcPhotos.Location = new System.Drawing.Point(12, 71);
            this.tcPhotos.Multiline = true;
            this.tcPhotos.Name = "tcPhotos";
            this.tcPhotos.SelectedIndex = 0;
            this.tcPhotos.Size = new System.Drawing.Size(386, 175);
            this.tcPhotos.TabIndex = 3;
            this.tcPhotos.SelectedIndexChanged += new System.EventHandler(this.tcPhotos_SelectedIndexChanged);
            // 
            // tabPhotos
            // 
            this.tabPhotos.Controls.Add(this.btnRemove);
            this.tabPhotos.Controls.Add(this.btnMoveDown);
            this.tabPhotos.Controls.Add(this.btnMoveUp);
            this.tabPhotos.Controls.Add(this.btnPhotoProp);
            this.tabPhotos.Controls.Add(this.lstPhotos);
            this.tabPhotos.Location = new System.Drawing.Point(23, 4);
            this.tabPhotos.Name = "tabPhotos";
            this.tabPhotos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhotos.Size = new System.Drawing.Size(359, 167);
            this.tabPhotos.TabIndex = 0;
            this.tabPhotos.Text = "Photos";
            this.tabPhotos.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(278, 88);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Location = new System.Drawing.Point(278, 52);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 10;
            this.btnMoveDown.Text = "Move &Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Location = new System.Drawing.Point(278, 16);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 9;
            this.btnMoveUp.Text = "Move &Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnPhotoProp
            // 
            this.btnPhotoProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhotoProp.Enabled = false;
            this.btnPhotoProp.Location = new System.Drawing.Point(278, 124);
            this.btnPhotoProp.Name = "btnPhotoProp";
            this.btnPhotoProp.Size = new System.Drawing.Size(75, 23);
            this.btnPhotoProp.TabIndex = 8;
            this.btnPhotoProp.Text = "Properti&es";
            this.btnPhotoProp.UseVisualStyleBackColor = true;
            this.btnPhotoProp.Click += new System.EventHandler(this.btnPhotoProp_Click);
            // 
            // lstPhotos
            // 
            this.lstPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPhotos.FormattingEnabled = true;
            this.lstPhotos.Location = new System.Drawing.Point(6, 6);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.Size = new System.Drawing.Size(266, 147);
            this.lstPhotos.TabIndex = 7;
            this.lstPhotos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPhotos_DrawItem);
            this.lstPhotos.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstPhotos_MeasureItem);
            this.lstPhotos.SelectedIndexChanged += new System.EventHandler(this.lstPhotos_SelectedIndexChanged);
            this.lstPhotos.DoubleClick += new System.EventHandler(this.lstPhotos_DoubleClick);
            // 
            // tabDates
            // 
            this.tabDates.Controls.Add(this.monthCalDates);
            this.tabDates.Location = new System.Drawing.Point(23, 4);
            this.tabDates.Name = "tabDates";
            this.tabDates.Padding = new System.Windows.Forms.Padding(3);
            this.tabDates.Size = new System.Drawing.Size(359, 167);
            this.tabDates.TabIndex = 1;
            this.tabDates.Text = "Dates";
            this.tabDates.UseVisualStyleBackColor = true;
            // 
            // monthCalDates
            // 
            this.monthCalDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalDates.Location = new System.Drawing.Point(3, 3);
            this.monthCalDates.MaxSelectionCount = 1;
            this.monthCalDates.Name = "monthCalDates";
            this.monthCalDates.ShowToday = false;
            this.monthCalDates.TabIndex = 0;
            this.monthCalDates.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalDates_MouseDown);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 282);
            this.Controls.Add(this.tcPhotos);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAlbumEditor";
            this.groupBox1.ResumeLayout(false);
            this.tcPhotos.ResumeLayout(false);
            this.tabPhotos.ResumeLayout(false);
            this.tabDates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAlbumProp;
        private System.Windows.Forms.ComboBox cmbxAlbums;
        private System.Windows.Forms.ContextMenu ctxtPhotoList;
        private System.Windows.Forms.MenuItem menuThumbs;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuImages;
        private System.Windows.Forms.TabControl tcPhotos;
        private System.Windows.Forms.TabPage tabPhotos;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnPhotoProp;
        private System.Windows.Forms.ListBox lstPhotos;
        private System.Windows.Forms.TabPage tabDates;
        private System.Windows.Forms.MonthCalendar monthCalDates;
    }
}


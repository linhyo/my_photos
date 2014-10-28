namespace MyPhotos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ctxtMenuView = new System.Windows.Forms.ContextMenu();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuNew = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.menuSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.menuEdit = new System.Windows.Forms.MenuItem();
            this.menuAdd = new System.Windows.Forms.MenuItem();
            this.menuRemove = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuPhotoProp = new System.Windows.Forms.MenuItem();
            this.menuAlbumProp = new System.Windows.Forms.MenuItem();
            this.menuView = new System.Windows.Forms.MenuItem();
            this.menuImage = new System.Windows.Forms.MenuItem();
            this.menuScale = new System.Windows.Forms.MenuItem();
            this.menuStretch = new System.Windows.Forms.MenuItem();
            this.menuActual = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuNext = new System.Windows.Forms.MenuItem();
            this.menuPrevious = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuPixelData = new System.Windows.Forms.MenuItem();
            this.menuSlideShow = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.sbpnlFileName = new System.Windows.Forms.StatusBarPanel();
            this.sbpnlImageSize = new System.Windows.Forms.StatusBarPanel();
            this.sbpnlImagePercent = new System.Windows.Forms.StatusBarPanel();
            this.sbpnlFileIndex = new System.Windows.Forms.StatusBarPanel();
            this.pnlPhoto = new System.Windows.Forms.Panel();
            this.toolBarMain = new System.Windows.Forms.ToolBar();
            this.tbbNew = new System.Windows.Forms.ToolBarButton();
            this.tbbOpen = new System.Windows.Forms.ToolBarButton();
            this.tbbSave = new System.Windows.Forms.ToolBarButton();
            this.seperator1 = new System.Windows.Forms.ToolBarButton();
            this.tbbPrevious = new System.Windows.Forms.ToolBarButton();
            this.tbbNext = new System.Windows.Forms.ToolBarButton();
            this.seperator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbImage = new System.Windows.Forms.ToolBarButton();
            this.ctxtMenuImage = new System.Windows.Forms.ContextMenu();
            this.seperator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbPixelData = new System.Windows.Forms.ToolBarButton();
            this.imageListToolBar = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sbpnlFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpnlImageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpnlImagePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpnlFileIndex)).BeginInit();
            this.pnlPhoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuAbout});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuItem1,
            this.menuSave,
            this.menuSaveAs,
            this.menuItem2,
            this.menuExit});
            this.menuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
            this.menuFile.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.Index = 0;
            this.menuNew.MergeType = System.Windows.Forms.MenuMerge.Remove;
            this.menuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Index = 1;
            this.menuOpen.MergeOrder = 1;
            this.menuOpen.MergeType = System.Windows.Forms.MenuMerge.Remove;
            this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.MergeOrder = 3;
            this.menuItem1.Text = "-";
            // 
            // menuSave
            // 
            this.menuSave.Index = 3;
            this.menuSave.MergeOrder = 4;
            this.menuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Index = 4;
            this.menuSaveAs.MergeOrder = 5;
            this.menuSaveAs.Text = "Save &As...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 5;
            this.menuItem2.MergeOrder = 6;
            this.menuItem2.Text = "-";
            // 
            // menuExit
            // 
            this.menuExit.Index = 6;
            this.menuExit.MergeOrder = 2;
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Index = 1;
            this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuAdd,
            this.menuRemove,
            this.menuItem4,
            this.menuPhotoProp,
            this.menuAlbumProp});
            this.menuEdit.Text = "&Edit";
            this.menuEdit.Popup += new System.EventHandler(this.menuEdit_Popup);
            // 
            // menuAdd
            // 
            this.menuAdd.Index = 0;
            this.menuAdd.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuAdd.Text = "&Add";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuRemove
            // 
            this.menuRemove.Index = 1;
            this.menuRemove.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.menuRemove.Text = "&Remove";
            this.menuRemove.Click += new System.EventHandler(this.menuRemove_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // menuPhotoProp
            // 
            this.menuPhotoProp.Enabled = false;
            this.menuPhotoProp.Index = 3;
            this.menuPhotoProp.Text = "&Photo Properties…";
            this.menuPhotoProp.Click += new System.EventHandler(this.menuPhotoProp_Click);
            // 
            // menuAlbumProp
            // 
            this.menuAlbumProp.Index = 4;
            this.menuAlbumProp.Text = "A&lbum Properties";
            this.menuAlbumProp.Click += new System.EventHandler(this.menuAlbumProp_Click);
            // 
            // menuView
            // 
            this.menuView.Index = 2;
            this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuImage,
            this.menuItem3,
            this.menuNext,
            this.menuPrevious,
            this.menuItem5,
            this.menuPixelData,
            this.menuSlideShow});
            this.menuView.Text = "&View";
            // 
            // menuImage
            // 
            this.menuImage.Index = 0;
            this.menuImage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuScale,
            this.menuStretch,
            this.menuActual});
            this.menuImage.Text = "&Image";
            this.menuImage.Popup += new System.EventHandler(this.menuImage_Popup);
            // 
            // menuScale
            // 
            this.menuScale.Index = 0;
            this.menuScale.Text = "&Scale to Fit";
            this.menuScale.Click += new System.EventHandler(this.menuImage_ChildClick);
            // 
            // menuStretch
            // 
            this.menuStretch.Index = 1;
            this.menuStretch.Text = "S&tretch to Fit";
            this.menuStretch.Click += new System.EventHandler(this.menuImage_ChildClick);
            // 
            // menuActual
            // 
            this.menuActual.Index = 2;
            this.menuActual.Text = "&Actual Size";
            this.menuActual.Click += new System.EventHandler(this.menuImage_ChildClick);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // menuNext
            // 
            this.menuNext.Index = 2;
            this.menuNext.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftN;
            this.menuNext.Text = "&Next";
            this.menuNext.Click += new System.EventHandler(this.menuNext_Click);
            // 
            // menuPrevious
            // 
            this.menuPrevious.Index = 3;
            this.menuPrevious.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftP;
            this.menuPrevious.Text = "&Previous";
            this.menuPrevious.Click += new System.EventHandler(this.menuPrevious_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "-";
            // 
            // menuPixelData
            // 
            this.menuPixelData.Index = 5;
            this.menuPixelData.Text = "Pi&xel Data…";
            this.menuPixelData.Click += new System.EventHandler(this.menuPixelData_Click);
            // 
            // menuSlideShow
            // 
            this.menuSlideShow.Index = 6;
            this.menuSlideShow.Text = "&Slide Show…";
            this.menuSlideShow.Click += new System.EventHandler(this.menuSlideShow_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Index = 3;
            this.menuAbout.Text = "&About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 219);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sbpnlFileName,
            this.sbpnlImageSize,
            this.sbpnlImagePercent,
            this.sbpnlFileIndex});
            this.statusBar1.Size = new System.Drawing.Size(384, 22);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Text = "Ready";
            this.statusBar1.DrawItem += new System.Windows.Forms.StatusBarDrawItemEventHandler(this.statusBar1_DrawItem);
            // 
            // sbpnlFileName
            // 
            this.sbpnlFileName.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.sbpnlFileName.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.sbpnlFileName.Name = "sbpnlFileName";
            this.sbpnlFileName.Text = "statusBarPanel1";
            this.sbpnlFileName.ToolTipText = "Image File Name";
            // 
            // sbpnlImageSize
            // 
            this.sbpnlImageSize.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.sbpnlImageSize.Name = "sbpnlImageSize";
            this.sbpnlImageSize.Text = "statusBarPanel1";
            this.sbpnlImageSize.ToolTipText = "Image Size";
            this.sbpnlImageSize.Width = 97;
            // 
            // sbpnlImagePercent
            // 
            this.sbpnlImagePercent.Name = "sbpnlImagePercent";
            this.sbpnlImagePercent.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
            this.sbpnlImagePercent.Text = "statusBarPanel1";
            this.sbpnlImagePercent.ToolTipText = "Percent of Image Shown";
            this.sbpnlImagePercent.Width = 75;
            // 
            // sbpnlFileIndex
            // 
            this.sbpnlFileIndex.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.sbpnlFileIndex.Name = "sbpnlFileIndex";
            this.sbpnlFileIndex.Text = "statusBarPanel1";
            this.sbpnlFileIndex.ToolTipText = "Image Index";
            this.sbpnlFileIndex.Width = 97;
            // 
            // pnlPhoto
            // 
            this.pnlPhoto.AllowDrop = true;
            this.pnlPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhoto.Controls.Add(this.toolBarMain);
            this.pnlPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhoto.Location = new System.Drawing.Point(0, 0);
            this.pnlPhoto.Name = "pnlPhoto";
            this.pnlPhoto.Size = new System.Drawing.Size(384, 219);
            this.pnlPhoto.TabIndex = 3;
            this.pnlPhoto.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPhoto_DragDrop);
            this.pnlPhoto.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlPhoto_DragEnter);
            this.pnlPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPhoto_Paint);
            this.pnlPhoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPhoto_MouseDown);
            this.pnlPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPhoto_MouseMove);
            // 
            // toolBarMain
            // 
            this.toolBarMain.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbNew,
            this.tbbOpen,
            this.tbbSave,
            this.seperator1,
            this.tbbPrevious,
            this.tbbNext,
            this.seperator2,
            this.tbbImage,
            this.seperator3,
            this.tbbPixelData});
            this.toolBarMain.ButtonSize = new System.Drawing.Size(30, 16);
            this.toolBarMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBarMain.DropDownArrows = true;
            this.toolBarMain.ImageList = this.imageListToolBar;
            this.toolBarMain.Location = new System.Drawing.Point(0, 0);
            this.toolBarMain.Margin = new System.Windows.Forms.Padding(1);
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.ShowToolTips = true;
            this.toolBarMain.Size = new System.Drawing.Size(382, 36);
            this.toolBarMain.TabIndex = 0;
            this.toolBarMain.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarMain_ButtonClick);
            // 
            // tbbNew
            // 
            this.tbbNew.ImageIndex = 0;
            this.tbbNew.Name = "tbbNew";
            this.tbbNew.ToolTipText = "Create album";
            // 
            // tbbOpen
            // 
            this.tbbOpen.ImageIndex = 6;
            this.tbbOpen.Name = "tbbOpen";
            this.tbbOpen.ToolTipText = "Open album";
            // 
            // tbbSave
            // 
            this.tbbSave.ImageIndex = 4;
            this.tbbSave.Name = "tbbSave";
            this.tbbSave.ToolTipText = "Save album";
            // 
            // seperator1
            // 
            this.seperator1.Name = "seperator1";
            this.seperator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbPrevious
            // 
            this.tbbPrevious.ImageIndex = 1;
            this.tbbPrevious.Name = "tbbPrevious";
            this.tbbPrevious.ToolTipText = "Previous image";
            // 
            // tbbNext
            // 
            this.tbbNext.ImageIndex = 2;
            this.tbbNext.Name = "tbbNext";
            this.tbbNext.ToolTipText = "Next image";
            // 
            // seperator2
            // 
            this.seperator2.Name = "seperator2";
            this.seperator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbImage
            // 
            this.tbbImage.DropDownMenu = this.ctxtMenuImage;
            this.tbbImage.ImageIndex = 10;
            this.tbbImage.Name = "tbbImage";
            this.tbbImage.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.tbbImage.ToolTipText = "Set display mode";
            // 
            // ctxtMenuImage
            // 
            this.ctxtMenuImage.Popup += new System.EventHandler(this.menuImage_Popup);
            // 
            // seperator3
            // 
            this.seperator3.Name = "seperator3";
            this.seperator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbPixelData
            // 
            this.tbbPixelData.ImageIndex = 8;
            this.tbbPixelData.Name = "tbbPixelData";
            this.tbbPixelData.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbPixelData.ToolTipText = "Show pixel data";
            // 
            // imageListToolBar
            // 
            this.imageListToolBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListToolBar.ImageStream")));
            this.imageListToolBar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListToolBar.Images.SetKeyName(0, "New document.png");
            this.imageListToolBar.Images.SetKeyName(1, "Folder.png");
            this.imageListToolBar.Images.SetKeyName(2, "Save.png");
            this.imageListToolBar.Images.SetKeyName(3, "Back.png");
            this.imageListToolBar.Images.SetKeyName(4, "Forward.png");
            this.imageListToolBar.Images.SetKeyName(5, "Notes.png");
            this.imageListToolBar.Images.SetKeyName(6, "folder_open_add2.png");
            this.imageListToolBar.Images.SetKeyName(7, "notebook.png");
            this.imageListToolBar.Images.SetKeyName(8, "boot.png");
            this.imageListToolBar.Images.SetKeyName(9, "traffic.png");
            this.imageListToolBar.Images.SetKeyName(10, "gwenview.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.ContextMenu = this.ctxtMenuView;
            this.Controls.Add(this.pnlPhoto);
            this.Controls.Add(this.statusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPhotos";
            ((System.ComponentModel.ISupportInitialize)(this.sbpnlFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpnlImageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpnlImagePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpnlFileIndex)).EndInit();
            this.pnlPhoto.ResumeLayout(false);
            this.pnlPhoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuFile;
        private System.Windows.Forms.MenuItem menuView;
        private System.Windows.Forms.MenuItem menuImage;
        private System.Windows.Forms.MenuItem menuStretch;
        private System.Windows.Forms.MenuItem menuActual;
        private System.Windows.Forms.ContextMenu ctxtMenuView;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel sbpnlFileName;
        private System.Windows.Forms.StatusBarPanel sbpnlImageSize;
        private System.Windows.Forms.StatusBarPanel sbpnlImagePercent;
        private System.Windows.Forms.MenuItem menuNew;
        private System.Windows.Forms.MenuItem menuOpen;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.MenuItem menuSaveAs;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuEdit;
        private System.Windows.Forms.MenuItem menuAdd;
        private System.Windows.Forms.MenuItem menuRemove;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuNext;
        private System.Windows.Forms.MenuItem menuPrevious;
        private System.Windows.Forms.StatusBarPanel sbpnlFileIndex;
        private System.Windows.Forms.MenuItem menuScale;
        private System.Windows.Forms.Panel pnlPhoto;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuPhotoProp;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuPixelData;
        private System.Windows.Forms.MenuItem menuAlbumProp;
        private System.Windows.Forms.ToolBar toolBarMain;
        private System.Windows.Forms.ImageList imageListToolBar;
        private System.Windows.Forms.ToolBarButton tbbNew;
        private System.Windows.Forms.ToolBarButton tbbOpen;
        private System.Windows.Forms.ToolBarButton tbbSave;
        private System.Windows.Forms.ToolBarButton seperator1;
        private System.Windows.Forms.ToolBarButton tbbPrevious;
        private System.Windows.Forms.ToolBarButton tbbNext;
        private System.Windows.Forms.ContextMenu ctxtMenuImage;
        private System.Windows.Forms.ToolBarButton seperator2;
        private System.Windows.Forms.ToolBarButton tbbImage;
        private System.Windows.Forms.ToolBarButton seperator3;
        private System.Windows.Forms.ToolBarButton tbbPixelData;
        private System.Windows.Forms.MenuItem menuSlideShow;
        private System.Windows.Forms.MenuItem menuAbout;

        
    }
}


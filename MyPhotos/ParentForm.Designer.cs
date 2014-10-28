namespace MyPhotos
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuNew = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuPageSetup = new System.Windows.Forms.MenuItem();
            this.menuPrintPreview = new System.Windows.Forms.MenuItem();
            this.menuPrint = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.menuWindows = new System.Windows.Forms.MenuItem();
            this.menuArrange = new System.Windows.Forms.MenuItem();
            this.menuCascade = new System.Windows.Forms.MenuItem();
            this.menuTileHorizontal = new System.Windows.Forms.MenuItem();
            this.menuTileVertical = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.imageListParent = new System.Windows.Forms.ImageList(this.components);
            this.toolBarParent = new System.Windows.Forms.ToolBar();
            this.tbbNew = new System.Windows.Forms.ToolBarButton();
            this.tbbOpen = new System.Windows.Forms.ToolBarButton();
            this.tbbSave = new System.Windows.Forms.ToolBarButton();
            this.tbbSep = new System.Windows.Forms.ToolBarButton();
            this.tbbPrev = new System.Windows.Forms.ToolBarButton();
            this.tbbNext = new System.Windows.Forms.ToolBarButton();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuWindows,
            this.menuHelp});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuItem2,
            this.menuPageSetup,
            this.menuPrintPreview,
            this.menuPrint,
            this.menuItem1,
            this.menuExit});
            this.menuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
            this.menuFile.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.Index = 0;
            this.menuNew.MergeType = System.Windows.Forms.MenuMerge.Replace;
            this.menuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Index = 1;
            this.menuOpen.MergeOrder = 1;
            this.menuOpen.MergeType = System.Windows.Forms.MenuMerge.Replace;
            this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MergeType = System.Windows.Forms.MenuMerge.Remove;
            this.menuItem2.Text = "-";
            // 
            // menuPageSetup
            // 
            this.menuPageSetup.Index = 3;
            this.menuPageSetup.MergeOrder = 7;
            this.menuPageSetup.Text = "Page Set&up…";
            this.menuPageSetup.Click += new System.EventHandler(this.menuPageSetup_Click);
            // 
            // menuPrintPreview
            // 
            this.menuPrintPreview.Index = 4;
            this.menuPrintPreview.MergeOrder = 7;
            this.menuPrintPreview.Text = "Print Pre&view";
            this.menuPrintPreview.Click += new System.EventHandler(this.menuPrintPreview_Click);
            // 
            // menuPrint
            // 
            this.menuPrint.Index = 5;
            this.menuPrint.MergeOrder = 7;
            this.menuPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuPrint.Text = "&Print…";
            this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 6;
            this.menuItem1.MergeOrder = 6;
            this.menuItem1.Text = "-";
            // 
            // menuExit
            // 
            this.menuExit.Index = 7;
            this.menuExit.MergeOrder = 7;
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuWindows
            // 
            this.menuWindows.Index = 1;
            this.menuWindows.MdiList = true;
            this.menuWindows.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuArrange,
            this.menuCascade,
            this.menuTileHorizontal,
            this.menuTileVertical});
            this.menuWindows.MergeOrder = 3;
            this.menuWindows.Text = "&Window";
            // 
            // menuArrange
            // 
            this.menuArrange.Index = 0;
            this.menuArrange.Text = "&Arrange Icons";
            this.menuArrange.Click += new System.EventHandler(this.menuArrange_Click);
            // 
            // menuCascade
            // 
            this.menuCascade.Index = 1;
            this.menuCascade.Text = "&Cascade";
            this.menuCascade.Click += new System.EventHandler(this.menuCascade_Click);
            // 
            // menuTileHorizontal
            // 
            this.menuTileHorizontal.Index = 2;
            this.menuTileHorizontal.Text = "Tile &Horizontal";
            this.menuTileHorizontal.Click += new System.EventHandler(this.menuTileHorizontal_Click);
            // 
            // menuTileVertical
            // 
            this.menuTileVertical.Index = 3;
            this.menuTileVertical.Text = "Tile &Vertical";
            this.menuTileVertical.Click += new System.EventHandler(this.menuTileVertical_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 2;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuAbout});
            this.menuHelp.MergeOrder = 9;
            this.menuHelp.Text = "&Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Index = 0;
            this.menuAbout.Text = "&About MyPhotos…";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // imageListParent
            // 
            this.imageListParent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListParent.ImageStream")));
            this.imageListParent.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListParent.Images.SetKeyName(0, "new_document.png");
            this.imageListParent.Images.SetKeyName(1, "open1.png");
            this.imageListParent.Images.SetKeyName(2, "3floppy_unmount.png");
            this.imageListParent.Images.SetKeyName(3, "back (1).png");
            this.imageListParent.Images.SetKeyName(4, "forward.png");
            // 
            // toolBarParent
            // 
            this.toolBarParent.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarParent.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbNew,
            this.tbbOpen,
            this.tbbSave,
            this.tbbSep,
            this.tbbPrev,
            this.tbbNext});
            this.toolBarParent.ButtonSize = new System.Drawing.Size(24, 24);
            this.toolBarParent.DropDownArrows = true;
            this.toolBarParent.ImageList = this.imageListParent;
            this.toolBarParent.Location = new System.Drawing.Point(0, 0);
            this.toolBarParent.Name = "toolBarParent";
            this.toolBarParent.ShowToolTips = true;
            this.toolBarParent.Size = new System.Drawing.Size(584, 28);
            this.toolBarParent.TabIndex = 1;
            this.toolBarParent.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBarParent.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarParent_ButtonClick);
            // 
            // tbbNew
            // 
            this.tbbNew.ImageIndex = 0;
            this.tbbNew.Name = "tbbNew";
            this.tbbNew.ToolTipText = "New";
            // 
            // tbbOpen
            // 
            this.tbbOpen.ImageIndex = 1;
            this.tbbOpen.Name = "tbbOpen";
            // 
            // tbbSave
            // 
            this.tbbSave.ImageIndex = 2;
            this.tbbSave.Name = "tbbSave";
            this.tbbSave.ToolTipText = "Save";
            // 
            // tbbSep
            // 
            this.tbbSep.Name = "tbbSep";
            this.tbbSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbPrev
            // 
            this.tbbPrev.ImageIndex = 3;
            this.tbbPrev.Name = "tbbPrev";
            this.tbbPrev.ToolTipText = "Previous";
            // 
            // tbbNext
            // 
            this.tbbNext.ImageIndex = 4;
            this.tbbNext.Name = "tbbNext";
            this.tbbNext.ToolTipText = "Next";
            // 
            // printDoc
            // 
            this.printDoc.DocumentName = "Image Document";
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.toolBarParent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuFile;
        private System.Windows.Forms.MenuItem menuNew;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuOpen;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.ImageList imageListParent;
        private System.Windows.Forms.ToolBar toolBarParent;
        private System.Windows.Forms.ToolBarButton tbbNew;
        private System.Windows.Forms.ToolBarButton tbbOpen;
        private System.Windows.Forms.ToolBarButton tbbSave;
        private System.Windows.Forms.ToolBarButton tbbSep;
        private System.Windows.Forms.ToolBarButton tbbPrev;
        private System.Windows.Forms.ToolBarButton tbbNext;
        private System.Windows.Forms.MenuItem menuWindows;
        private System.Windows.Forms.MenuItem menuArrange;
        private System.Windows.Forms.MenuItem menuCascade;
        private System.Windows.Forms.MenuItem menuTileHorizontal;
        private System.Windows.Forms.MenuItem menuTileVertical;
        private System.Windows.Forms.MenuItem menuPageSetup;
        private System.Windows.Forms.MenuItem menuPrintPreview;
        private System.Windows.Forms.MenuItem menuPrint;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.MenuItem menuHelp;
        private System.Windows.Forms.MenuItem menuAbout;
    }
}
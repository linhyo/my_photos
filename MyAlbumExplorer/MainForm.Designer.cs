namespace MyAlbumExplorer
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Photo 1", 3, 4);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Album 1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Album 2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Album 3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Default Albums", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.menuEdit = new System.Windows.Forms.MenuItem();
            this.menuEditLabel = new System.Windows.Forms.MenuItem();
            this.menuProperties = new System.Windows.Forms.MenuItem();
            this.menuView = new System.Windows.Forms.MenuItem();
            this.menuLargeIcons = new System.Windows.Forms.MenuItem();
            this.menuSmallIcons = new System.Windows.Forms.MenuItem();
            this.menuList = new System.Windows.Forms.MenuItem();
            this.menuDetails = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuAlbums = new System.Windows.Forms.MenuItem();
            this.menuPhotos = new System.Windows.Forms.MenuItem();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuExit});
            this.menuFile.Text = "&File";
            // 
            // menuExit
            // 
            this.menuExit.Index = 0;
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Index = 1;
            this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuEditLabel,
            this.menuProperties});
            this.menuEdit.Text = "&Edit";
            this.menuEdit.Popup += new System.EventHandler(this.menuEdit_Popup);
            // 
            // menuEditLabel
            // 
            this.menuEditLabel.Index = 0;
            this.menuEditLabel.Text = "&Name";
            this.menuEditLabel.Click += new System.EventHandler(this.menuEditLabel_Click);
            // 
            // menuProperties
            // 
            this.menuProperties.Index = 1;
            this.menuProperties.Text = "&Properties…";
            this.menuProperties.Click += new System.EventHandler(this.menuProperties_Click);
            // 
            // menuView
            // 
            this.menuView.Index = 2;
            this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuLargeIcons,
            this.menuSmallIcons,
            this.menuList,
            this.menuDetails,
            this.menuItem1,
            this.menuAlbums,
            this.menuPhotos});
            this.menuView.Text = "&View";
            this.menuView.Popup += new System.EventHandler(this.menuView_Popup);
            // 
            // menuLargeIcons
            // 
            this.menuLargeIcons.Checked = true;
            this.menuLargeIcons.Index = 0;
            this.menuLargeIcons.RadioCheck = true;
            this.menuLargeIcons.Text = "Lar&ge Icons";
            this.menuLargeIcons.Click += new System.EventHandler(this.menuLargeIcons_Click);
            // 
            // menuSmallIcons
            // 
            this.menuSmallIcons.Index = 1;
            this.menuSmallIcons.RadioCheck = true;
            this.menuSmallIcons.Text = "S&mall Icons";
            this.menuSmallIcons.Click += new System.EventHandler(this.menuSmallIcons_Click);
            // 
            // menuList
            // 
            this.menuList.Index = 2;
            this.menuList.RadioCheck = true;
            this.menuList.Text = "&List";
            this.menuList.Click += new System.EventHandler(this.menuList_Click);
            // 
            // menuDetails
            // 
            this.menuDetails.Index = 3;
            this.menuDetails.RadioCheck = true;
            this.menuDetails.Text = "&Details";
            this.menuDetails.Click += new System.EventHandler(this.menuDetails_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 4;
            this.menuItem1.Text = "-";
            // 
            // menuAlbums
            // 
            this.menuAlbums.Index = 5;
            this.menuAlbums.Text = "&Albums";
            this.menuAlbums.Click += new System.EventHandler(this.menuAlbums_Click);
            // 
            // menuPhotos
            // 
            this.menuPhotos.Index = 6;
            this.menuPhotos.Text = "&Photos";
            this.menuPhotos.Click += new System.EventHandler(this.menuPhotos_Click);
            // 
            // listViewMain
            // 
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.HideSelection = false;
            this.listViewMain.LabelEdit = true;
            this.listViewMain.LargeImageList = this.imageListLarge;
            this.listViewMain.Location = new System.Drawing.Point(129, 0);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(255, 241);
            this.listViewMain.SmallImageList = this.imageListSmall;
            this.listViewMain.TabIndex = 0;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewMain_AfterLabelEdit);
            this.listViewMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewMain_ColumnClick);
            this.listViewMain.ItemActivate += new System.EventHandler(this.listViewMain_ItemActivate);
            this.listViewMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewMain_KeyDown);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "camera.png");
            this.imageListLarge.Images.SetKeyName(1, "164.png");
            this.imageListLarge.Images.SetKeyName(2, "Hopstarter-Soft-Scraps-Address-Book.ico");
            this.imageListLarge.Images.SetKeyName(3, "face_plain.png");
            this.imageListLarge.Images.SetKeyName(4, "face_smile.png");
            this.imageListLarge.Images.SetKeyName(5, "face_sad (1).png");
            this.imageListLarge.Images.SetKeyName(6, "Visualpharm-Must-Have-Picture.ico");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "camera.png");
            this.imageListSmall.Images.SetKeyName(1, "164.png");
            this.imageListSmall.Images.SetKeyName(2, "Hopstarter-Soft-Scraps-Address-Book.ico");
            this.imageListSmall.Images.SetKeyName(3, "face_plain.png");
            this.imageListSmall.Images.SetKeyName(4, "face_smile.png");
            this.imageListSmall.Images.SetKeyName(5, "face_sad (1).png");
            this.imageListSmall.Images.SetKeyName(6, "Visualpharm-Must-Have-Picture.ico");
            // 
            // treeViewMain
            // 
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewMain.HideSelection = false;
            this.treeViewMain.ImageIndex = 2;
            this.treeViewMain.ImageList = this.imageListSmall;
            this.treeViewMain.LabelEdit = true;
            this.treeViewMain.Location = new System.Drawing.Point(0, 0);
            this.treeViewMain.Name = "treeViewMain";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "Node4";
            treeNode1.SelectedImageIndex = 4;
            treeNode1.Text = "Photo 1";
            treeNode2.Name = "Node1";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Album 1";
            treeNode3.Name = "Node2";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Album 2";
            treeNode4.Name = "Node3";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Album 3";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "Node0";
            treeNode5.SelectedImageIndex = 0;
            treeNode5.Text = "Default Albums";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeViewMain.SelectedImageIndex = 1;
            this.treeViewMain.Size = new System.Drawing.Size(126, 241);
            this.treeViewMain.TabIndex = 1;
            this.treeViewMain.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewMain_AfterLabelEdit);
            this.treeViewMain.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewMain_BeforeExpand);
            this.treeViewMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMain_AfterSelect);
            this.treeViewMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewMain_KeyDown);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(126, 0);
            this.splitter1.MinExtra = 100;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 241);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Location = new System.Drawing.Point(129, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(255, 241);
            this.pictureBoxMain.TabIndex = 3;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Visible = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMain_Paint);
            this.pictureBoxMain.Resize += new System.EventHandler(this.pictureBoxMain_Resize);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.listViewMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeViewMain);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAlbumExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuFile;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuEdit;
        private System.Windows.Forms.MenuItem menuView;
        private System.Windows.Forms.MenuItem menuLargeIcons;
        private System.Windows.Forms.MenuItem menuSmallIcons;
        private System.Windows.Forms.MenuItem menuList;
        private System.Windows.Forms.MenuItem menuDetails;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.MenuItem menuProperties;
        private System.Windows.Forms.MenuItem menuEditLabel;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuAlbums;
        private System.Windows.Forms.MenuItem menuPhotos;
        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBoxMain;
    }
}


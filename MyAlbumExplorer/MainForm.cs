using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Manning.MyPhotoAlbum;
using System.Collections;

namespace MyAlbumExplorer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private const int AlbumNameColumn = 0;
        private const int AlbumTitleColumn = 1;
        private const int AlbumPwdColumn = 2;
        private const int AlbumSizeColumn = 3;

        private MyListViewComparer _comparer;

        private bool _albumsShown = true;
        private PhotoAlbum _album = null;

        private const int PhotoCaptionColumn = 0;
        private const int PhotoDateTakenColumn = 1;
        private const int PhotoPhotographerColumn = 2;
        private const int PhotoFileNameColumn = 3;

        private const int PhotoIndex = 6;
        private const int AlbumIndex = 2;
        private const int ErrorIndex = 5;

        private const int SelectedPhotoIndex = 4;
        private const int SelectedAlbumIndex = 1;
        private const int AlbumDirectoryIndex = 0;

        protected override void OnLoad(EventArgs e)
        {
            // Define the list view comparer
            _comparer = new MyListViewComparer(listViewMain);
            //listViewMain.ListViewItemSorter = _comparer;
            listViewMain.Sorting = SortOrder.Ascending;

            // Assign title bar
            Version v = new Version(Application.ProductVersion);
            this.Text = String.Format("MyAlbumExplorer {0:#}.{1:#}", v.Major, v.Minor);

            // Load the default album data
            LoadAlbumData(PhotoAlbum.DefaultDir);

            // Initialize the tree and list controls
            InitTreeData();
        }       

        //
        // EXIT
        //
        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        // VIEW
        //
        private void menuView_Popup(object sender, EventArgs e)
        {
            View v = listViewMain.View;
            menuLargeIcons.Checked = (v == View.LargeIcon);
            menuSmallIcons.Checked = (v == View.SmallIcon);
            menuList.Checked = (v == View.List);
            menuDetails.Checked = (v == View.Details);

            if (_albumsShown && listViewMain.SelectedItems.Count > 0)
                menuPhotos.Enabled = true;
            else
                menuPhotos.Enabled = false;
        }

        private void menuLargeIcons_Click(object sender, EventArgs e)
        {
            listViewMain.View = View.LargeIcon;
        }

        private void menuSmallIcons_Click(object sender, EventArgs e)
        {
            listViewMain.View = View.SmallIcon;
        }

        private void menuList_Click(object sender, EventArgs e)
        {
            listViewMain.View = View.List;
        }

        private void menuDetails_Click(object sender, EventArgs e)
        {
            listViewMain.View = View.Details;
        }

        //
        // OPEN ALBUM
        //
        private PhotoAlbum OpenAlbum(string fileName)
        {
            PhotoAlbum album = new PhotoAlbum();

            try
            {
                album.Open(fileName);
            }
            catch (Exception)
            {
                return null;
            }

            return album;
        }

        //
        // LOAD ALBUM DATA
        //
        private void LoadAlbumData(string dir)
        {
            listViewMain.Clear();
            _comparer.CurrentAlbum = null;

            _albumsShown = true;
            if (_album != null)
            {
                _album.Dispose();
                _album = null;
            }

            // Define the columns
            listViewMain.Columns.Add("Name", 80, HorizontalAlignment.Left);
            listViewMain.Columns.Add("Title", 100, HorizontalAlignment.Left);
            listViewMain.Columns.Add("Pwd", 40, HorizontalAlignment.Center);
            listViewMain.Columns.Add("Size", 40, HorizontalAlignment.Right);
            
            // Load the albums into the control
            string[] albumFiles = Directory.GetFiles(dir, "*.abm");

            foreach (string s in albumFiles)
            {
                // See if we can open this album
                PhotoAlbum album = OpenAlbum(s);

                // Create a new list view item
                ListViewItem item = new ListViewItem();

                item.Text = Path.GetFileNameWithoutExtension(s);

                if (album != null)
                {
                    item.Tag = album.FileName;
                    item.ImageIndex = MainForm.AlbumIndex;

                    // Add the subitems
                    item.SubItems.Add(album.Title);
                    bool hasPwd = (album.Password != null) && (album.Password.Length > 0);
                    item.SubItems.Add(hasPwd ? "y" : "n");
                    item.SubItems.Add(album.Count.ToString());
                }
                else
                {
                    item.ImageIndex = MainForm.ErrorIndex;
                    item.SubItems.Add(item.Text);
                    item.SubItems.Add("?");
                    item.SubItems.Add("0");
                }

                listViewMain.Items.Add(item);
            }
        }

        private class MyListViewComparer : IComparer<object>
        {        
            // Associate a ListView with the class
            private ListView _listView;

            public MyListViewComparer(ListView lv)
            {
                _listView = lv;
            }

            public ListView ListView
            {
                get
                {
                    return _listView;
                }
            }

            // Track the current sorting column
            private int _sortColumn = 0;

            public int SortColumn
            {
                get
                {
                    return _sortColumn;
                }
                set
                {
                    _sortColumn = value;
                }
            }
            
            // Compare method implementation
            public int Compare(object a, object b)
            {
                // Throws exception if not list items
                ListViewItem item1 = (ListViewItem)a;
                ListViewItem item2 = (ListViewItem)b;

                // Account for current sorting order
                if (ListView.Sorting == SortOrder.Descending)
                {
                    ListViewItem tmp = item1;
                    item1 = item2;
                    item2 = tmp;
                }

                // Handle nonDetails case
                if (ListView.View != View.Details)
                {
                    return CaseInsensitiveComparer.Default.Compare(item1.Text, item2.Text);
                }

                if (CurrentAlbum == null)
                    return CompareAlbums(item1, item2);
                else
                    return ComparePhotos(item1, item2);
            }

            private int ComparePhotos(ListViewItem item1, ListViewItem item2)
            {
                ListViewItem.ListViewSubItem sub1;
                ListViewItem.ListViewSubItem sub2;
                switch (SortColumn)
                {
                    case MainForm.PhotoCaptionColumn:
                    case MainForm.PhotoPhotographerColumn:
                    case MainForm.PhotoFileNameColumn:
                        sub1 = item1.SubItems[SortColumn];
                        sub2 = item2.SubItems[SortColumn];
                        return CaseInsensitiveComparer.Default.Compare(sub1.Text, sub2.Text);

                    case MainForm.PhotoDateTakenColumn:
                        // Find the indices into the album
                        int index1 = (int)item1.Tag;
                        int index2 = (int)item2.Tag;

                        // Look up the dates for each photo
                        DateTime date1 = CurrentAlbum[index1].DateTaken;
                        DateTime date2 = CurrentAlbum[index2].DateTaken;
                        return DateTime.Compare(date1, date2);

                    default:
                        throw new IndexOutOfRangeException("unrecognized column index");
                }
            }

            public int CompareAlbums(ListViewItem item1, ListViewItem item2)
            {
                // Find the subitem instances
                ListViewItem.ListViewSubItem sub1 = item1.SubItems[SortColumn];
                ListViewItem.ListViewSubItem sub2 = item2.SubItems[SortColumn];

                // Return value is based on sort column
                switch (SortColumn)
                {
                    case MainForm.AlbumNameColumn:
                    case MainForm.AlbumTitleColumn:
                    case MainForm.AlbumPwdColumn:
                    {
                        return
                            CaseInsensitiveComparer.Default.Compare(sub1.Text, sub2.Text);
                    }

                    case MainForm.AlbumSizeColumn:
                    {
                        // Compare using integer values.
                        int x1 = Convert.ToInt32(sub1.Text);
                        int x2 = Convert.ToInt32(sub2.Text);

                        if (x1 < x2)
                            return -1;
                        else if (x1 == x2)
                            return 0;
                        else
                            return 1;
                    }

                    default:
                    throw new IndexOutOfRangeException("unrecognized column index");
                }
            } // end of MyListViewComparer class
        
            PhotoAlbum _album = null;
            public PhotoAlbum CurrentAlbum
            {
                get 
                { 
                    return _album; 
                }
                set 
                { 
                    _album = value; 
                }
            }
        }

        private void listViewMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortOrder prevOrder = listViewMain.Sorting;
            listViewMain.Sorting = SortOrder.None;

            if (e.Column == _comparer.SortColumn)
            {
                // Switch the sorting order
                if (prevOrder == SortOrder.Ascending)
                    listViewMain.Sorting = SortOrder.Descending;
                else
                    listViewMain.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Define new sort column and reset order
                _comparer.SortColumn = e.Column;
                listViewMain.Sorting = SortOrder.Ascending;
            }
        }

        private void menuProperties_Click(object sender, EventArgs e)
        {
            if (treeViewMain.Focused)
            {
                TreeNode node = treeViewMain.SelectedNode;
                string file = node.Tag as string;

                if (node == null || node.Parent == null || file == null)
                    return; // do nothing

                if (Path.GetExtension(file) == ".abm")
                    DisplayAlbumProperties(node);
                else
                    DisplayPhotoProperties(node);
            }
            else if (pictureBoxMain.Focused)
            {
                // Display photograph for this image
                TreeNode node = treeViewMain.SelectedNode;

                if (node != null)
                    DisplayPhotoProperties(node);
            }
            else
                if (listViewMain.SelectedItems.Count > 0)
                {
                    ListViewItem item = listViewMain.SelectedItems[0];
                    if (this._albumsShown)
                        DisplayAlbumProperties(item);
                    else
                        DisplayPhotoProperties(item);
                }
        }

        private void DisplayPhotoProperties(object obj)
        {
            ListViewItem item = obj as ListViewItem;
            TreeNode node = obj as TreeNode;
            int index = 0;

            if (item != null && (item.Tag is int))
            {
                index = (int)item.Tag;
            }
            else if (node != null)
            {
                index = node.Index;
            }
            _album.CurrentPosition = index;

            using (PhotoEditDlg dlg = new PhotoEditDlg(_album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Save any changes made

                    // Update controls with new settings
                    TreeNode baseNode = null;
                    if (item != null)
                    {
                        LoadPhotoData(_album);
                        baseNode = treeViewMain.SelectedNode;
                    }
                    else if (node != null)
                    {
                        baseNode = node.Parent;
                    }

                    if (baseNode != null)
                    {
                        // Update all child labels
                        foreach (TreeNode n in baseNode.Nodes)
                        {
                            n.Text = _album[n.Index].Caption;
                        }
                    }
                }
            }
        }

        private void DisplayAlbumProperties(object obj)
        {
            ListViewItem item = obj as ListViewItem;
            TreeNode node = obj as TreeNode;

            // Open the album as appropriate
            PhotoAlbum album = null;

            if (item != null)
            {
                string fileName = item.Tag as string;
                if (fileName != null)
                album = this.OpenAlbum(fileName);
            }
            else if (node != null)
            {
                album = OpenTreeAlbum(node);
            }

            if (album == null)
            {
                MessageBox.Show("The properties for " + "this album cannot be displayed.");
                return;
            }

            using (AlbumEditDlg dlg = new AlbumEditDlg(album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Save changes made by the user
                    

                    // Update item settings
                    if (item != null)
                    {
                        item.SubItems[MainForm.AlbumTitleColumn].Text = album.Title;

                        bool hasPwd = (album.Password != null) && (album.Password.Length > 0);
                        item.SubItems[MainForm.AlbumPwdColumn].Text = (hasPwd ? "y" : "n");
                    }
                }
            }

            album.Dispose();
        }

        private void DisplayPhotoProperties(ListViewItem item)
        {
            if (!(item.Tag is int))
                return;

            int index = (int)item.Tag;
            _album.CurrentPosition = index;

            using (PhotoEditDlg dlg = new PhotoEditDlg(_album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Save any changes made
                    try
                    {
                        _album.Save(_album.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to save " + "changes to photos in album.");
                    }

                    // Update the list with any new settings
                    LoadPhotoData(_album);
                }
            }
        }

        private void DisplayAlbumProperties(ListViewItem item)
        {
            string fileName = item.Tag as string;
            PhotoAlbum album = null;

            if (fileName != null)
                album = this.OpenAlbum(fileName);

            if (album == null)
            {
                MessageBox.Show("The properties for " + "this album cannot be displayed.");
                return;
            }

            using (AlbumEditDlg dlg = new AlbumEditDlg(album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Save changes made by the user
                    try
                    {
                        album.Save();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to save " + "changes to album.");
                        return;
                    }

                    // Update subitem settings
                    item.SubItems[MainForm.AlbumTitleColumn].Text = album.Title;

                    bool hasPwd = (album.Password != null) && (album.Password.Length > 0);
                    item.SubItems[MainForm.AlbumPwdColumn].Text = (hasPwd ? "y" : "n");
                }
            }

            album.Dispose();
        }

        private void menuEditLabel_Click(object sender, EventArgs e)
        {
            if (treeViewMain.Focused)
            {
                if (treeViewMain.SelectedNode != null)
                treeViewMain.SelectedNode.BeginEdit();
            }
            else if (listViewMain.SelectedItems.Count > 0)
                listViewMain.SelectedItems[0].BeginEdit();
        }

        private void listViewMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (listViewMain.SelectedItems.Count == 1)
                {
                    listViewMain.SelectedItems[0].BeginEdit();
                    e.Handled = true;
                }
            }
        }

        private void listViewMain_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
            {
                // Edit cancelled by the user
                e.CancelEdit = true;
                return;
            }

            ListViewItem item = listViewMain.Items[e.Item];

            if (this._albumsShown)
                e.CancelEdit = !UpdateAlbumName(e.Label, item);
            else
                e.CancelEdit = !UpdatePhotoCaption(e.Label, item);
        }

        private bool UpdatePhotoCaption(string caption, ListViewItem item)
        {
            if (caption.Length == 0 || !(item.Tag is int))
            {
                MessageBox.Show("Invalid caption value.");
                return false;
            }
            int index = (int)item.Tag;
            _album[index].Caption = caption;

            try
            {
                _album.Save(_album.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to save new " + "caption to album file.");
            }

            return true;
        }

        private bool UpdateAlbumName(string newName, ListViewItem item)
        {
            string fileName = item.Tag as string;
            string newFileName = RenameFile(fileName, newName, ".abm");

            if (newFileName == null)
            {
                MessageBox.Show("Unable to rename album to this name.");
                return false;
            }

            // Update Tag property
            item.Tag = newFileName;
            return true;
        }

        private string RenameFile(string origFile, string newBase, string ext)
        {
            string fileName = Path.GetDirectoryName(origFile) + "\\" + newBase;
            string newFile = Path.ChangeExtension(fileName, ext);

            try
            {
                File.Move(origFile, newFile);
                return newFile;
            }
            catch (Exception)
            {
                // An error occurred
                return null;
            }
        }

        private void listViewMain_ItemActivate(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count > 0)
            {
                // Find the file path for selected item
                string fileName = null;
                ListViewItem item = listViewMain.SelectedItems[0];

                if (_albumsShown)
                {
                    // Get the file for this album
                    fileName = item.Tag as string;
                }
                else if (item.Tag is int)
                {
                    // Use the index of the photograph
                    int index = (int)item.Tag;
                    fileName = _album[index].FileName;
                }

                if (fileName == null)
                {
                    MessageBox.Show("This item cannot " + "be opened.");
                    return;
                }

                // Find tree node with identical path
                TreeNode node = FindNode(fileName, true);

                if (node != null)
                {
                    // Select the node to activate it.
                    node.EnsureVisible();
                    treeViewMain.SelectedNode = node;
                }
            }
        }

        private void LoadPhotoData(PhotoAlbum album)
        {
            listViewMain.Clear();
            if (_album != null && album != _album) 
                _album.Dispose();
            _albumsShown = false;
            _album = album;
            _comparer.CurrentAlbum = _album;

            // Define the columns
            listViewMain.Columns.Add("Caption", 100, HorizontalAlignment.Left);
            listViewMain.Columns.Add("Taken", 70, HorizontalAlignment.Center);
            listViewMain.Columns.Add("Photographer", 100, HorizontalAlignment.Left);
            listViewMain.Columns.Add("File Name", 200, HorizontalAlignment.Left);

            // Handle null or empty album
            if (album == null || album.Count == 0)
                return;

            // Load the photo items
            for (int i = 0; i < album.Count; i++)
            {
                Photograph photo = album[i];
                ListViewItem item = new ListViewItem();

                item.Text = photo.Caption;
                item.Tag = i;
                item.ImageIndex = MainForm.PhotoIndex;

                // Add the subitems
                item.SubItems.Add(photo.DateTaken.ToShortDateString());
                item.SubItems.Add(photo.Photographer);
                item.SubItems.Add(photo.FileName);

                listViewMain.Items.Add(item);
            }
        }

        private void menuEdit_Popup(object sender, EventArgs e)
        {
            if (treeViewMain.Focused)
            {
                menuEditLabel.Enabled = (treeViewMain.SelectedNode != null);
                menuEditLabel.Text = "&Node";
            }
            else // assume ListView has focus
            {
                menuEditLabel.Enabled = (listViewMain.SelectedItems.Count > 0);

                if (this._albumsShown)
                    menuEditLabel.Text = "&Name";
                else
                    menuEditLabel.Text = "&Caption";
            }
        }

        private void menuAlbums_Click(object sender, EventArgs e)
        {
            // Select Default Albums node
            if (treeViewMain.Nodes.Count > 0)
            {
                treeViewMain.SelectedNode = treeViewMain.Nodes[0];
            }
        }

        private void menuPhotos_Click(object sender, EventArgs e)
        {
            // Activate the selected album
            listViewMain_ItemActivate(sender, e);
        }

        private void InitTreeData()
        {
            treeViewMain.BeginUpdate();
            treeViewMain.Nodes.Clear();

            // Create the top-level node
            TreeNode defaultRoot = new TreeNode("Default Albums",
            AlbumDirectoryIndex, AlbumDirectoryIndex);
            defaultRoot.Tag = PhotoAlbum.DefaultDir;
            treeViewMain.Nodes.Add(defaultRoot);
            treeViewMain.SelectedNode = defaultRoot;

            foreach (string s in Directory.GetFiles(PhotoAlbum.DefaultDir, "*.abm"))
            {
                // Create a node for this album
                String baseName = Path.GetFileNameWithoutExtension(s);
                TreeNode albumNode = new TreeNode(baseName, new TreeNode[] { new TreeNode("child") });
                albumNode.Tag = s;
                defaultRoot.Nodes.Add(albumNode);
            }

            treeViewMain.EndUpdate();
        }

        private PhotoAlbum OpenTreeAlbum(TreeNode node)
        {
            string s = node.Tag as string;
            PhotoAlbum album = OpenAlbum(s);

            if (album == null)
            {
                // Unable to open album
                node.ImageIndex = ErrorIndex;
                node.SelectedImageIndex = ErrorIndex;
            }
            else
            {
                // Album opened successfully
                node.ImageIndex = AlbumIndex;
                node.SelectedImageIndex = SelectedAlbumIndex;
            }

            return album;
        }

        private void treeViewMain_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            string s = node.Tag as string;

            if (s == null || (Path.GetExtension(s) != ".abm"))
            {
                // Not an album node
                return;
            }

            // Found an album node
            node.Nodes.Clear();

            using (PhotoAlbum album = OpenTreeAlbum(node))
            {
                // Cancel if null or empty album
                if (album == null || album.Count == 0)
                {
                    e.Cancel = true;
                    return;
                }

                // Add a node for each photo in album
                treeViewMain.BeginUpdate();
                foreach (Photograph p in album)
                {
                    // Create a new node for this photo
                    TreeNode newNode = new TreeNode(album.GetDisplayText(p), MainForm.PhotoIndex, MainForm.SelectedPhotoIndex);
                    newNode.Tag = p.FileName;
                    node.Nodes.Add(newNode);
                }
                treeViewMain.EndUpdate();
            }
        }

        private void treeViewMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            string fileName = node.Tag as string;

            if (fileName == null)
                throw new ApplicationException("selected tree node has " + "invalid tag");

            if (node.Parent == null)
            {
                // Bad tag or Top-level node
                LoadAlbumData(fileName);
                DisplayPhoto(null);
            }
            else if (Path.GetExtension(fileName) == ".abm")
            {
                // Album node selected
                PhotoAlbum album = OpenTreeAlbum(node);
                LoadPhotoData(album);
                DisplayPhoto(null);
            }
            else // must be a photograph
            {
                // Clear the list and display the photo
                listViewMain.Clear();
                DisplayPhoto(node);
            }
        }

        private TreeNode FindNode(string fileName, bool expandNode)
        {
            TreeNode node = treeViewMain.SelectedNode;

            if (node == null)
                return null;

            // Ensure contents of node are available
            if (expandNode)
                node.Expand();

            // Search for a matching node
            foreach (TreeNode n in node.Nodes)
            {
                string nodePath = n.Tag as string;
                if (nodePath == fileName)
                {
                    // Found it!
                    return n;
                }
            }

            return null;
        }

        private void DisplayPhoto(TreeNode node)
        {
            if (node == null)
            {
                pictureBoxMain.Visible = false;
                listViewMain.Visible = true;
                return;
            }

            // Parent of photo node is album node
            string file = node.Parent.Tag as string;
            if (_album == null || (_album.FileName != file))
            {
                if (_album != null)
                    _album.Dispose();

                _album = OpenTreeAlbum(node.Parent);
            }

            if (_album != null)
            {
                // Proper PhotoAlbum is now open
                pictureBoxMain.Tag = _album[node.Index];
                pictureBoxMain.Invalidate();
                pictureBoxMain.Visible = true;
                listViewMain.Visible = false;
            }
        }

        private static Pen borderPen = new Pen(SystemColors.WindowFrame);

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            Photograph photo = pictureBoxMain.Tag as Photograph;

            if (photo == null)
            {
                // Something is wrong, give up
                e.Graphics.Clear(pictureBoxMain.BackColor);
                return;
            }

            // Paint the photograph
            Rectangle rect = photo.ScaleToFit(pictureBoxMain.ClientRectangle);
            e.Graphics.DrawImage(photo.Image, rect);
            e.Graphics.DrawRectangle(borderPen, rect);
        }

        private void pictureBoxMain_Resize(object sender, EventArgs e)
        {
            // Force the entire control to repaint
            pictureBoxMain.Invalidate();
        }

        private void treeViewMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (treeViewMain.SelectedNode != null)
                {
                    treeViewMain.SelectedNode.BeginEdit();
                    e.Handled = true;
                }
            }
        }

        private void treeViewMain_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null)
            {
                // Edit cancelled by the user
                e.CancelEdit = true;
                return;
            }

            // No changes required for root node
            if (e.Node.Parent == null)
                return;

            string fileName = e.Node.Tag as string;

            if (Path.GetExtension(fileName) == ".abm")
                e.CancelEdit = !UpdateAlbumName(e.Label, e.Node);
            else
                e.CancelEdit = !UpdatePhotoCaption(e.Label, e.Node);
        }

        private bool UpdatePhotoCaption(string caption, object obj)
        {
            ListViewItem item = obj as ListViewItem;
            TreeNode node = obj as TreeNode;

            // Determine the album index
            int index = -1;

            if ((item != null) && (item.Tag is int))
            {
                index = (int)item.Tag;
                node = FindNode(_album[index].FileName, false);
            }
            else if (node != null)
            {
                index = node.Index;
            }

            if ((caption.Length == 0) || (index < 0))
            {
                MessageBox.Show("Invalid caption value.");
                return false;
            }

            // Update caption
            _album[index].Caption = caption;

            if (item != null && node != null)
            {
                // Update node text as well
                node.Text = caption;
            }

            // Save the changes to the album
            return true;
        }

        private bool UpdateAlbumName(string newName, object obj)
        {
            ListViewItem item = obj as ListViewItem;
            TreeNode node = obj as TreeNode;

            // Determine the file name
            string fileName = null;

            if (item != null)
            {
                fileName = item.Tag as string;
                node = FindNode(fileName, false);
            }
            else if (node != null)
                fileName = node.Tag as string;

            // Rename the file
            string newFileName = null;
            if (fileName != null)
            {
                newFileName = RenameFile(fileName, newName, ".abm");
            }
            if (newFileName == null)
            {
                MessageBox.Show("Unable to rename album " + "to this name.");
                return false;
            }

            // Update the appropriate Tag property
            if (item != null)
            {
                item.Tag = newFileName;

                if (node != null)
                    node.Text = newName;
            }
            else if (node != null)
                node.Tag = newFileName;

            return true;
        }


    }
}

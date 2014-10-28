using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
using System.IO;
using System.Drawing.Printing;

namespace MyPhotos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Additional Form initialization
            DefineContextMenu();
            pnlPhoto.ContextMenu = this.ctxtMenuView;
            _album = new PhotoAlbum();
            menuNew_Click(this, EventArgs.Empty);
            menuImage_ChildClick(menuScale, EventArgs.Empty);
            InitToolBarButtons();            
        }

        protected PhotoAlbum _album;
        protected bool _bAlbumChanged = false;

        /// <summary>
        /// Mode settings for the View->Image
        /// submenu. The order and values here
        /// must correspond to the index of
        /// menus in the Image submenu.
        /// </summary>
        private enum DisplayMode
        {
            ScaleToFit = 0,
            StretchToFit = 1,
            ActualSize = 2
        }

        private DisplayMode _selectedMode = DisplayMode.ScaleToFit;

        //
        // NEW album
        //
        private void menuNew_Click(object sender, EventArgs e)
        {
            if (this.CloseCurrentAlbum() == true)
            {
                // Make sure the window is redrawn
                this.Invalidate();
            }
        }

        //
        // OPEN
        //
        private void menuOpen_Click(object sender, EventArgs e)
        {
            // Save the existing album, if necessary
            if (this.CloseCurrentAlbum() == false)
            {
                // Cancel this operation
                return;
            }

            // Allow user to select a new album
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Album";
            dlg.Filter = "Album files (*.abm)|*.abm|" + "All files (*.*)|*.*";
            dlg.InitialDirectory = PhotoAlbum.DefaultDir;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Open the new album
                    _album.Open(dlg.FileName);

                    _album.FileName = dlg.FileName;
                    _bAlbumChanged = false;
                    this.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Unable to open file " + dlg.FileName + "\n (" + ex.Message + ")", "Open Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dlg.Dispose();
        }

        //
        // SAVE AS
        //
        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save Album";
            dlg.DefaultExt = "abm";
            dlg.Filter = "Album files (*.abm)|*.abm|" + "All files|*.*";
            dlg.InitialDirectory = PhotoAlbum.DefaultDir;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Record the new album name
                _album.FileName = dlg.FileName;

                // Use Save handler to store the album
                menuSave_Click(sender, e);

                // Update title bar to include new name
                SetTitleBar();
            }
            dlg.Dispose();
        }

        //
        // SAVE
        //
        private void menuSave_Click(object sender, EventArgs e)
        {
            if (_album.FileName == null)
            {
                // Need to select an album file
                menuSaveAs_Click(sender, e);
            }
            else
            {
                try
                {
                    // Save the album in the current file
                    _album.Save();
                    _bAlbumChanged = false;
                }
                catch (Exception ex)
                {
                    string msg = "Unable to save file {0}" + " - {1}\nWould you like to save" + " the album in an alternate file?";
                    DialogResult result = MessageBox.Show(this, String.Format(msg, _album.FileName, ex.Message), "Save Album Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        menuSaveAs_Click(sender, e);
                    }
                }
            }
        }

        //
        // EXIT
        //
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // ADD photos
        //
        private void menuAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Add photos";
            dlg.Multiselect = true;
            dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
                + "*.jpg;*.jpeg;*.gif;*.bmp;"
                + "*.tif;*.tiff;*.png|"
                + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
                + "GIF files (*.gif)|*.gif|"
                + "BMP files (*.bmp)|*.bmp|"
                + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
                + "PNG files (*.png)|*.png|"
                + "All files (*.*)|*.*";
            dlg.InitialDirectory = Environment.CurrentDirectory;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] files = dlg.FileNames;

                statusBar1.ShowPanels = false;
                statusBar1.Text = String.Format("Loading {0} Files", files.Length);

                int index = 0;
                foreach (string s in files)
                {
                    Photograph photo = new Photograph(s);

                    // Add the file (if not already present)
                    index = _album.IndexOf(photo);
                    if (index < 0)
                    {
                        index = _album.Add(photo);
                        _bAlbumChanged = true;
                    }
                }
                dlg.Dispose();
                this.Invalidate();
            }
        }

        //
        // REMOVE photos
        //
        private void menuRemove_Click(object sender, EventArgs e)
        {
            if (_album.Count > 0)
            {
                _album.RemoveAt(_album.CurrentPosition);
                _bAlbumChanged = true;
            }

            this.Invalidate();
        }       


        private void menuImage_ChildClick(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem mi = (MenuItem)sender;
                _selectedMode = (DisplayMode)mi.Index;

                switch (_selectedMode)
                {
                    default:
                    case DisplayMode.ScaleToFit:
                    case DisplayMode.StretchToFit:
                        // Display entire image in window
                        pnlPhoto.AutoScroll = false;
                        SetStyle(ControlStyles.ResizeRedraw, true);
                        pnlPhoto.Invalidate();
                        break;   
                 
                    case DisplayMode.ActualSize:
                        // Display image at actual size
                        pnlPhoto.AutoScroll = true;
                        SetStyle(ControlStyles.ResizeRedraw, false);
                        pnlPhoto.Invalidate();
                        break;
                }
            }
        }


        private void menuImage_Popup(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                bool bImageLoaded = (_album.Count > 0);
                MenuItem miParent = (MenuItem)sender;

                foreach (MenuItem mi in miParent.MenuItems)
                {
                    mi.Enabled = bImageLoaded;
                    mi.Checked = (this._selectedMode == (DisplayMode)mi.Index);
                }
            }
        }        

        // Photo status
        private void statusBar1_DrawItem(object sender, StatusBarDrawItemEventArgs sbdevent)
        {
            if (sbdevent.Panel == sbpnlImagePercent)
            {
                // Calculate the percent of the image shown
                int percent = 100;
                if (_selectedMode == DisplayMode.ActualSize)
                {
                    Photograph photo = _album.CurrentPhoto;
                    Rectangle dr = pnlPhoto.ClientRectangle;
                    int imgWidth = photo.Image.Width;
                    int imgHeight = photo.Image.Height;
                    percent = 100 * Math.Min(dr.Width, imgWidth) * Math.Min(dr.Height, imgHeight) / (imgWidth * imgHeight);
                }

                // Calculate the rectangle to fill
                Rectangle fillRect = sbdevent.Bounds;
                fillRect.Width = sbdevent.Bounds.Width * percent / 100;

                // Draw the rectangle in the panel               
                sbdevent.Graphics.FillRectangle(Brushes.SlateGray, fillRect);

                // Draw the text on top of the rectangle
                sbdevent.Graphics.DrawString(
                    percent.ToString() + "%",
                    sbdevent.Font,
                    Brushes.White,
                    sbdevent.Bounds);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_album.Count > 0)
            {
                // Paint the current image
                Photograph photo = _album.CurrentPhoto;
                
                // Update the status bar
                sbpnlFileName.Text = _album.CurrentDisplayText;
                sbpnlImageSize.Text = String.Format("{0:#} x {1:#}", photo.Image.Width, photo.Image.Height);
                sbpnlFileIndex.Text = String.Format("{0:#}/{1:#}", _album.CurrentPosition + 1, _album.Count);
                statusBar1.ShowPanels = true;
            }
            else
            {
                // Indicate the album is empty
                statusBar1.Text = "No Photos in Album";
                statusBar1.ShowPanels = false;
            }

            // Ensure contained controls are redrawn
            pnlPhoto.Invalidate();
            statusBar1.Invalidate();
            base.OnPaint(e);
        }

        //
        // NEXT
        //
        private void menuNext_Click(object sender, EventArgs e)
        {
            if (_album.CurrentNext())
            {
                this.Invalidate();
            }
        }

        //
        // PREVIOUS
        //
        private void menuPrevious_Click(object sender, EventArgs e)
        {
            if (_album.CurrentPrev())
            {
                this.Invalidate();
            }
        }

        //
        // CONTEXT MENU
        //
        private void DefineContextMenu()
        {
            // Copy the View menu into ctxtMenuView
            foreach (MenuItem mi in menuView.MenuItems)
            {
                ctxtMenuView.MenuItems.Add(mi.Index, mi.CloneMenu());
            }

            // Copy Image menu into ctxtMenuImage
            foreach (MenuItem mi in menuImage.MenuItems)
            {
                ctxtMenuImage.MenuItems.Add(mi.Index, mi.CloneMenu());
            }
        }

        //
        // TITLE BAR
        //
        private void SetTitleBar()
        {
            Version ver = new Version(Application.ProductVersion);

            if (_album.FileName == null)
            {
                this.Text = String.Format("MyPhotos {0:#}.{1:#}", ver.Major, ver.Minor);
            }
            else
            {
                string baseFile = Path.
                GetFileNameWithoutExtension(_album.FileName);
                this.Text = String.Format("{0} - MyPhotos {1:#}.{2:#}", baseFile, ver.Major, ver.Minor);
            }
        }     
                     
        private void pnlPhoto_Paint(object sender, PaintEventArgs e)
        {
            // Update PixelDlg if photo has changed
            if ((_dlgPixel != null) && (_nPixelDlgIndex != _album.CurrentPosition))
            {
                _nPixelDlgIndex = _album.CurrentPosition;
                Point p = pnlPhoto.PointToClient(
                Form.MousePosition);
                UpdatePixelData(p.X, p.Y);
            }

            if (_album.Count > 0)
            {
                // Paint the current photo
                Photograph photo = _album.CurrentPhoto;
                Graphics g = e.Graphics;

                switch (_selectedMode)
                {
                    default:
                    case DisplayMode.ScaleToFit:
                        g.DrawImage(photo.Image, photo.ScaleToFit(pnlPhoto.DisplayRectangle));
                        break;

                    case DisplayMode.StretchToFit:
                        // Fill entire panel with image
                        g.DrawImage(photo.Image, pnlPhoto.DisplayRectangle);
                        break;

                    case DisplayMode.ActualSize:
                        // Draw portion of image
                        g.DrawImage(photo.Image, pnlPhoto.AutoScrollPosition.X, pnlPhoto.AutoScrollPosition.Y, photo.Image.Width, photo.Image.Height);
                        pnlPhoto.AutoScrollMinSize = photo.Image.Size;
                        break;
                }
            }
            else 
            {
                // No image to paint
                e.Graphics.Clear(SystemColors.Control);
            }
        }

        protected bool CloseCurrentAlbum()
        {
            if (_bAlbumChanged)
            {
                // Offer to save the current album
                string msg;
                if (_album.FileName == null)
                    msg = "Do you want to save the " + "current album?";
                else
                    msg = String.Format("Do you want to " + "save your changes to \n{0}?", _album.FileName);

                DialogResult result = MessageBox.Show(this, msg, "Save Current Album?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    menuSave_Click(this, EventArgs.Empty);
                else if (result == DialogResult.Cancel)
                {
                    // Do not close the album
                    return false;
                }
            }

            // Close the album and return true
            if (_album != null)
                _album.Dispose();
            _album = new PhotoAlbum();
            SetTitleBar();
            _bAlbumChanged = false;
            return true;
        }

        protected override void OnClosing(CancelEventArgs ce)
        {
            if (this.CloseCurrentAlbum() == false)
                ce.Cancel = true;
            else
                ce.Cancel = false;

            base.OnClosing(ce);
        }

        private void menuEdit_Popup(object sender, EventArgs e)
        {
            menuPhotoProp.Enabled = (_album.Count > 0);
        }

        //
        // PIXEL
        //
        private PixelDlg _dlgPixel = null;
        private int _nPixelDlgIndex;

        private void menuPixelData_Click(object sender, EventArgs e)
        {
            if (_dlgPixel == null || _dlgPixel.IsDisposed)
            {
                _dlgPixel = PixelDlg.GlobalDialog;
            }

            _nPixelDlgIndex = _album.CurrentPosition;
            Point p = pnlPhoto.PointToClient(Form.MousePosition);
            UpdatePixelData(p.X, p.Y);
            AssignPixelToggle(true);

            _dlgPixel.Show();
        }

        protected void UpdatePixelData(int xPos, int yPos)
        {
            if (IsMdiChild)
                _dlgPixel = PixelDlg.GlobalDialog;

            if (_dlgPixel == null || !_dlgPixel.Visible)
                return;

            Photograph photo = _album.CurrentPhoto;

            Rectangle r = pnlPhoto.ClientRectangle;
            if (photo == null || !(r.Contains(xPos, yPos)))
            {
                _dlgPixel.Text = ((photo == null) ? " " : photo.Caption);
                _dlgPixel.XVal = 0;
                _dlgPixel.YVal = 0;
                _dlgPixel.RedVal = 0;
                _dlgPixel.GreenVal = 0;
                _dlgPixel.BlueVal = 0;
                _dlgPixel.Update();
                return;
            }

            _dlgPixel.Text = photo.Caption;

            // Calc x and y position in the photo
            int x = 0, y = 0;
            Bitmap bmp = photo.Image;
            switch (this._selectedMode)
            {
                case DisplayMode.ActualSize:
                    // Panel coords equal image coords
                    x = xPos;
                    y = yPos;
                    break;

                case DisplayMode.StretchToFit:
                    // Translate panel coords to image
                    x = xPos * bmp.Width / r.Width;
                    y = yPos * bmp.Height / r.Height;
                    break;

                case DisplayMode.ScaleToFit:
                    // Determine image rectangle.
                    Rectangle r2 = photo.ScaleToFit(r);

                    if (!r2.Contains(xPos, yPos))
                        return; // Mouse outside image

                    // Translate r2 coords to image
                    x = (xPos - r2.Left)
                    * bmp.Width / r2.Width;
                    y = (yPos - r2.Top)
                    * bmp.Height / r2.Height;
                    break;
            }
            // Extract color at calculated location
            Color c = bmp.GetPixel(x, y);

            // Update PixelDlg with new values
            _dlgPixel.XVal = x;
            _dlgPixel.YVal = y;
            _dlgPixel.RedVal = c.R;
            _dlgPixel.GreenVal = c.G;
            _dlgPixel.BlueVal = c.B;
            _dlgPixel.Update();
        }

        private void pnlPhoto_MouseMove(object sender, MouseEventArgs e)
        {
            UpdatePixelData(e.X, e.Y);
        }

        private void menuPhotoProp_Click(object sender, EventArgs e)
        {
            if (_album.CurrentPhoto == null)
                return;

            using (PhotoEditDlg dlg = new PhotoEditDlg(_album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _bAlbumChanged = dlg.HasChanged;

                    if (_bAlbumChanged)
                    {
                        // Redraw to pick up any changes
                        this.Invalidate();
                    }

                    //sbpnlFileName.Text = _album.CurrentPhoto.Caption;
                    //statusBar1.Invalidate();
                }
            }
        }

        private void menuAlbumProp_Click(object sender, EventArgs e)
        {
            using (AlbumEditDlg dlg = new AlbumEditDlg(_album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Update window with changes
                    this._bAlbumChanged = true;
                    SetTitleBar();
                    this.Invalidate();
                }
            }
        }

        //
        // KEY PRESS
        //
        private bool ctrlKeyHeld = false;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    e.Handled = true;
                    menuNext.PerformClick();
                    break;

                case '-':
                    e.Handled = true;
                    menuPrevious.PerformClick();
                    break;

                default: // do nothing
                    break;
            }

            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Left:
                    e.Handled = true;
                    menuPrevious.PerformClick();
                    break;

                case Keys.Down:
                case Keys.Right:
                    e.Handled = true;
                    menuNext.PerformClick();
                    break;

                case Keys.ControlKey:
                    ctrlKeyHeld = true;
                    pnlPhoto.Cursor = Cursors.SizeWE;
                    this.ContextMenu = null;
                    break;

                default: // do nothing
                    break;
            }

            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    ReleaseControlKey();
                    break;

                default: // do nothing
                    break;
            }

            base.OnKeyUp(e);
        }

        private void pnlPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            if (ctrlKeyHeld)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        menuPrevious.PerformClick();
                        break;

                    case MouseButtons.Right:
                        menuNext.PerformClick();
                        break;

                    default: // do nothing
                        break;
                }
            }
            else
            {
                // Initiate drag and drop for this image
                Photograph photo = _album.CurrentPhoto;

                if (photo != null)
                {
                    // Create object for encapsulating data
                    DataObject data = new DataObject();

                    // Construct string array for FileDrop
                    string[] fileArray = new string[1];
                    fileArray[0] = photo.FileName;
                    data.SetData(DataFormats.FileDrop, fileArray);

                    // Use the caption for the text format
                    data.SetData(DataFormats.Text, photo.Caption);

                    // Initiate drag and drop
                    pnlPhoto.DoDragDrop(data, DragDropEffects.Copy);
                }
            }
        }

        private void ReleaseControlKey()
        {
            ctrlKeyHeld = false;
            pnlPhoto.Cursor = Cursors.Default;
            this.ContextMenu = ctxtMenuView;
        }

        protected override void OnDeactivate(EventArgs e)
        {
            if (ctrlKeyHeld)
                ReleaseControlKey();

            base.OnDeactivate(e);
        }

        protected override void OnMenuStart(EventArgs e)
        {
            if (ctrlKeyHeld)
                ReleaseControlKey();

            base.OnMenuStart(e);
        }

        //
        // TOOLBAR BUTTON
        private void InitToolBarButtons()
        {
            tbbNew.Tag = menuNew;
            tbbOpen.Tag = menuOpen;
            tbbSave.Tag = menuSave;

            tbbPrevious.Tag = menuPrevious;
            tbbNext.Tag = menuNext;
        }

        private void toolBarMain_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            // Handle menu buttons
            MenuItem mi = e.Button.Tag as MenuItem;

            if (mi != null)
                mi.PerformClick();

            // Handle Pixel Data button
            if (e.Button == tbbPixelData)
            {
                if (e.Button.Pushed)
                {
                    // Display pixel dialog
                    menuPixelData.PerformClick();
                }
                else if (this._dlgPixel != null && _dlgPixel.Visible)
                {
                    // Hide pixel dialog
                    _dlgPixel.Hide();
                }

                // Update the button settings
                AssignPixelToggle(e.Button.Pushed);
            }
        }

        protected void AssignPixelToggle(bool push)
        {
            tbbPixelData.Pushed = push;

            if (push)
            {
                tbbPixelData.ImageIndex = 9;
                tbbPixelData.ToolTipText = "Hide pixel data";
            }
            else
            {
                tbbPixelData.ImageIndex = 8;
                tbbPixelData.ToolTipText = "Show pixel data";
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            // Update toggle button if required
            if (_dlgPixel == null || _dlgPixel.IsDisposed)
            {
                AssignPixelToggle(false);
            }
            else
                AssignPixelToggle(_dlgPixel.Visible);

            base.OnActivated(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            if (IsMdiChild)
            {
                menuExit.Text = "&Close";
                toolBarMain.Visible = false;
            }

            base.OnLoad(e);
        }

        public MainForm(string albumFile)
            : this()
        {
            _album = new PhotoAlbum();
            _album.Open(albumFile);
            SetTitleBar();
        }

        internal void ClickSaveMenu()
        {
            menuSave.PerformClick();
        }

        internal void ClickPreviousMenu()
        {
            menuPrevious.PerformClick();
        }

        internal void ClickNextMenu()
        {
            menuNext.PerformClick();
        }

        public string AlbumFile
        {
            get
            {
                return _album.FileName;
            }
        }

        public string AlbumTitle
        {
            get 
            { 
                return _album.Title; 
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            if (IsMdiChild && ctrlKeyHeld)
                ReleaseControlKey();

            base.OnLeave(e);
        }

        //
        // PRINT
        //
        public void PrintCurrentImage(PrintPageEventArgs e)
        {
            Photograph photo = _album.CurrentPhoto;

            if (photo == null)
            {
                // nothing to print, so abort
                e.Cancel = true;
                return;
            }

            // Establish some useful shortcuts
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            float bottomMargin = e.MarginBounds.Bottom;
            float printableWidth = e.MarginBounds.Width;
            float printableHeight = e.MarginBounds.Height;
            Graphics g = e.Graphics;

            Font printFont = new Font("Times New Roman", 11);
            float fontHeight = printFont.GetHeight(g);
            float spaceWidth = g.MeasureString(" ", printFont).Width;

            // Draw image in box 75% of shortest side
            float imageBoxLength;
            float xPos = leftMargin;
            float yPos = topMargin + fontHeight;

            if (printableWidth < printableHeight)
            {
                imageBoxLength = printableWidth * 75 / 100;
                yPos += imageBoxLength;
            }
            else
            {
                imageBoxLength = printableHeight * 75 / 100;
                xPos += imageBoxLength + spaceWidth;
            }

            // Draw image at start of the page
            Rectangle imageBox = new Rectangle((int)leftMargin + 1,
            (int)topMargin + 1, (int)imageBoxLength, (int)imageBoxLength);
            g.DrawImage(photo.Image,
            photo.ScaleToFit(imageBox));

            // Determine rectangle for text
            RectangleF printArea = new RectangleF(xPos, yPos, rightMargin - xPos, bottomMargin - yPos);

            PrintTextString(g, printFont, "FileName:", photo.FileName, ref printArea);
            PrintTextString(g, printFont, "Caption:", photo.Caption, ref printArea);
            PrintTextString(g, printFont, "Photographer:", photo.Photographer, ref printArea);
            PrintTextString(g, printFont, "Notes:", photo.Notes, ref printArea);
        }

        private void PrintTextString(Graphics g, Font printFont, string name, string text, ref RectangleF printArea)
        {
            // Establish some useful shortcuts
            float leftMargin = printArea.Left;
            float rightMargin = printArea.Right;
            float topMargin = printArea.Top;
            float bottomMargin = printArea.Bottom;

            float fontHeight = printFont.GetHeight(g);
            float xPos = printArea.Left;
            float yPos = topMargin + fontHeight;

            float spaceWidth = g.MeasureString(" ", printFont).Width;
            float nameWidth = g.MeasureString(name, printFont).Width;

            if (!printArea.Contains(xPos + nameWidth, yPos))
            {
                // Does not fit, so abort
                return;
            }

            g.DrawString(name, printFont, Brushes.Black, new PointF(xPos, yPos));
            leftMargin += nameWidth + spaceWidth;
            xPos = leftMargin;

            // Draw text, use multi-lines if necessary
            string[] words = text.Split(" \r\t\n\0".ToCharArray());

            foreach (string word in words)
            {
                float wordWidth = g.MeasureString(word, printFont).Width;

                if (wordWidth == 0.0)
                    continue;

                if (xPos + wordWidth > rightMargin)
                {
                    // Start a new line
                    xPos = leftMargin;
                    yPos += fontHeight;

                    if (yPos > bottomMargin)
                    {
                        // no more page, abort foreach loop
                        break;
                    }
                }

                g.DrawString(word, printFont, Brushes.Black, new PointF(xPos, yPos));
                xPos += wordWidth;
            }

            // Adjust print area based on drawn text
            printArea.Y = yPos;
            printArea.Height = bottomMargin - yPos;
        }

        private void menuSlideShow_Click(object sender, EventArgs e)
        {
            using (SlideShowForm f = new SlideShowForm(_album))
            {
                // Display slide show as modal dialog
                f.ShowDialog();
            }
        }

        private void pnlPhoto_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;

            else
                e.Effect = DragDropEffects.None;
        }

        private void pnlPhoto_DragDrop(object sender, DragEventArgs e)
        {
            object obj = e.Data.GetData(DataFormats.FileDrop);
            Array files = obj as Array;

            int index = -1;
            foreach (object o in files)
            {
                string s = o as string;

                if (s != null)
                {
                    Photograph photo = new Photograph(s);

                    // Add the file (if not present)
                    index = _album.IndexOf(photo);
                    if (index < 0)
                    {
                        index = _album.Add(photo);
                        _bAlbumChanged = true;
                    }
                }
            }

            if (index >= 0)
            {
                // Show the last image added
                _album.CurrentPosition = index;
                Invalidate();
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutUs frmAbout = new AboutUs();
            frmAbout.ShowDialog();
        }


    }
}

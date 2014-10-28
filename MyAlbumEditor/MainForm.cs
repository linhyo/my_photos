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

namespace MyAlbumEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lstPhotos.ContextMenu = this.ctxtPhotoList;
        }

        private PhotoAlbum _album;
        private bool _bAlbumChanged = false;

        protected override void OnLoad(EventArgs e)
        {
            // Initialize the album
            _album = new PhotoAlbum();

            // Initialize the combo box
            cmbxAlbums.DataSource = Directory.GetFiles(PhotoAlbum.DefaultDir, "*.abm");

            base.OnLoad(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseAlbum()
        {
            if (_bAlbumChanged)
            {
                _bAlbumChanged = false;

                DialogResult result = MessageBox.Show("Do you want " + "to save your changes to " + _album.FileName + '?', "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _album.Save();
                }
            }

            _album.Clear();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            CloseAlbum();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            CloseAlbum();

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Album";
                dlg.Filter = "abm files (*.abm)" + "|*.abm|All Files (*.*)|*.*";
                dlg.InitialDirectory = PhotoAlbum.DefaultDir;

                try
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        _album.Open(dlg.FileName);
                        this.Text = _album.FileName;
                        btnAlbumProp.Enabled = true;
                        UpdateList();
                        UpdatePhotographs();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to open " + "album\n" + dlg.FileName, "Open Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected void UpdateList()
        {
            lstPhotos.BeginUpdate();
            lstPhotos.Items.Clear();
            foreach (Photograph photo in _album)
            {
                lstPhotos.Items.Add(photo);
            }
            lstPhotos.EndUpdate();
        }

        private void btnAlbumProp_Click(object sender, EventArgs e)
        {
            using (AlbumEditDlg dlg = new AlbumEditDlg(_album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _bAlbumChanged = true;
                    UpdateList();
                }
            }
        }

        private void btnPhotoProp_Click(object sender, EventArgs e)
        {
            if (_album.Count == 0)
                return;

            if (lstPhotos.SelectedIndex >= 0)
            {
                if (DisplayPhotoEditDlg(lstPhotos.SelectedIndex))
                {
                    UpdateList();
                }
            }

            using (PhotoEditDlg dlg = new PhotoEditDlg(_album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _bAlbumChanged = true;
                    UpdateList();
                }
            }
        }

        private void lstPhotos_DoubleClick(object sender, EventArgs e)
        {
            btnPhotoProp.PerformClick();
        }

        private void lstPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numSelected = lstPhotos.SelectedIndices.Count;
            bool someSelected = (numSelected > 0);

            btnMoveUp.Enabled = (someSelected && !lstPhotos.GetSelected(0));
            btnMoveDown.Enabled = (someSelected && (!lstPhotos.GetSelected(lstPhotos.Items.Count - 1)));
            btnRemove.Enabled = someSelected;

            btnPhotoProp.Enabled = (numSelected == 1);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = lstPhotos.SelectedIndices;
            int[] newSelects = new int[indices.Count];

            // Move the selected items up
            for (int i = 0; i < indices.Count; i++)
            {
                int index = indices[i];
                _album.MoveBefore(index);
                newSelects[i] = index - 1;
            }

            _bAlbumChanged = true;
            UpdateList();

            // Reset the selections.
            lstPhotos.ClearSelected();
            foreach (int x in newSelects)
            {
                lstPhotos.SetSelected(x, true);
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = lstPhotos.SelectedIndices;
            int[] newSelects = new int[indices.Count];

            // Move the selected items down
            for (int i = indices.Count - 1; i >= 0; i--)
            {
                int index = indices[i];
                _album.MoveAfter(index);
                newSelects[i] = index + 1;
            }

            _bAlbumChanged = true;
            UpdateList();

            // Reset the selections.
            lstPhotos.ClearSelected();
            foreach (int x in newSelects)
            {
                lstPhotos.SetSelected(x, true);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string msg;
            int n = lstPhotos.SelectedItems.Count;

            if (n == 1)
                msg = "Do your really want to " + "remove the selected photo?";
            else
                msg = String.Format("Do you really want to " + "remove the {0} selected photos?", n);

            DialogResult result = MessageBox.Show(msg, "Remove Photos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ListBox.SelectedIndexCollection indices = lstPhotos.SelectedIndices;
                for (int i = indices.Count - 1; i >= 0; i--)
                {
                    _album.RemoveAt(indices[i]);
                }

                _bAlbumChanged = true;
                UpdateList();
            }
        }

        private void OpenAlbum(string fileName)
        {
            CloseAlbum();

            // Open the given album file
            _album.Open(fileName);
            this.Text = _album.FileName;

            UpdatePhotographs();
        }

        private void cmbxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            string albumPath = cmbxAlbums.SelectedItem.ToString();

            if (albumPath == _album.FileName)
                return;

            try
            {
                CloseAlbum();
                OpenAlbum(albumPath);
                tcPhotos.Enabled = true;
                btnAlbumProp.Enabled = true;
                lstPhotos.BackColor = SystemColors.Window;
            }
            catch (Exception)
            {
                // Unable to open album
                this.Text = "Unable to open selected album";
                tcPhotos.Enabled = false;
                lstPhotos.Items.Clear();                               
                lstPhotos.BackColor = SystemColors.Control;
                monthCalDates.RemoveAllBoldedDates(); 
                btnAlbumProp.Enabled = false;
            }
        }

        private void menuThumbs_Click(object sender, EventArgs e)
        {
            menuThumbs.Checked = !menuThumbs.Checked;

            if (menuThumbs.Checked)
            {
                lstPhotos.DrawMode = DrawMode.OwnerDrawVariable;
            }
            else
            {
                lstPhotos.DrawMode = DrawMode.Normal;
                lstPhotos.ItemHeight = lstPhotos.Font.Height + 2;
            }
        }
        
        private void menuImages_Click(object sender, EventArgs e)
        {
            Form imagesDlg = new Form();
            TabControl tcImages = new TabControl();

            imagesDlg.SuspendLayout();
            tcImages.SuspendLayout();

            // Create a tab page for each photo
            foreach (Photograph photo in _album)
            {
                string shortFileName = Path.GetFileName(photo.FileName);
                TabPage newPage = new TabPage(shortFileName);

                newPage.SuspendLayout();

                PictureBox pbox = new PictureBox();
                pbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                pbox.Dock = DockStyle.Fill;
                pbox.Image = photo.Image;
                pbox.SizeMode = PictureBoxSizeMode.CenterImage;

                newPage.Controls.Add(pbox);

                newPage.ToolTipText = photo.FileName;

                tcImages.TabPages.Add(newPage);
                newPage.ResumeLayout();
            }

            tcImages.Dock = DockStyle.Fill;
            tcImages.HotTrack = true;
            tcImages.ShowToolTips = true;

            imagesDlg.Controls.Add(tcImages);
            imagesDlg.ShowInTaskbar = false;
            imagesDlg.Size = new Size(600, 400);
            imagesDlg.Text = "Images in " + Path.GetFileName(_album.FileName);

            tcImages.ResumeLayout();
            imagesDlg.ResumeLayout();

            imagesDlg.ShowDialog();

            imagesDlg.Dispose();
        }


        private static Rectangle _drawRect = new Rectangle(0, 0, 45, 45);

        private void lstPhotos_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            Photograph p = _album[e.Index];
            Rectangle scaledRect = p.ScaleToFit(_drawRect);

            e.ItemHeight = Math.Max(scaledRect.Height, lstPhotos.Font.Height) + 2;

            e.ItemWidth = scaledRect.Width + 2 + (int)e.Graphics.MeasureString(p.Caption, lstPhotos.Font).Width;
        }

        private static SolidBrush _textBrush = new SolidBrush(SystemColors.WindowText);

        private void lstPhotos_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Photograph p = _album[e.Index];

            Rectangle scaledRect = p.ScaleToFit(_drawRect);
            Rectangle imageRect = e.Bounds;
            imageRect.Y += 1;
            imageRect.Height = scaledRect.Height;
            imageRect.X += 2;
            imageRect.Width = scaledRect.Width;

            g.DrawImage(p.Thumbnail, imageRect);
            g.DrawRectangle(Pens.Black, imageRect);

            Rectangle textRect = new Rectangle(imageRect.Right + 2, imageRect.Y + ((imageRect.Height - e.Font.Height) / 2), e.Bounds.Width - imageRect.Width - 4, e.Font.Height);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                _textBrush.Color = SystemColors.Highlight;
                g.FillRectangle(_textBrush, textRect);
                _textBrush.Color = SystemColors.HighlightText;
            }
            else
            {
                _textBrush.Color = SystemColors.Window;
                g.FillRectangle(_textBrush, textRect);
                _textBrush.Color = SystemColors.WindowText;
            }

            g.DrawString(p.Caption, e.Font, _textBrush, textRect);
        }

        private void UpdateCalendar()
        {
            // Initialize MonthCalendar control
            DateTime minDate = DateTime.MaxValue;
            DateTime maxDate = DateTime.MinValue;

            DateTime[] dates = new DateTime[_album.Count];

            for (int i = 0; i < _album.Count; i++)
            {
                DateTime newDate = _album[i].DateTaken;
                dates[i] = newDate;

                if (newDate < minDate)
                    minDate = newDate;
                if (newDate > maxDate)
                    maxDate = newDate;
            }

            if (_album.Count > 0)
            {
                monthCalDates.BoldedDates = dates;
                monthCalDates.MinDate = minDate;
                monthCalDates.MaxDate = maxDate;
                monthCalDates.SelectionStart = minDate;
            }

        }

        private void UpdatePhotographs()
        {
            if (tcPhotos.SelectedTab == tabPhotos)
                UpdateList();
            else if (tcPhotos.SelectedTab == tabDates)
                UpdateCalendar();
        }

        private void tcPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePhotographs();
        }

        private class PhotoMenuItem : MenuItem
        {
            public int tag;
        }

        private void monthCalDates_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = monthCalDates.HitTest(e.X, e.Y);

            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                ContextMenu ctxtPhotoCal = new ContextMenu();

                for (int i = 0; i < _album.Count; i++)
                {
                    if (_album[i].DateTaken.Date == info.Time.Date)
                    {
                        PhotoMenuItem newItem = new PhotoMenuItem();
                        newItem.tag = i;
                        newItem.Text = _album[i].FileName;
                        newItem.Click += new
                        EventHandler(ctxtPhotoCal_MenuClick);
                        ctxtPhotoCal.MenuItems.Add(newItem);
                    }
                }

                if (ctxtPhotoCal.MenuItems.Count >= 1)
                {
                    ctxtPhotoCal.Show(monthCalDates, new Point(e.X, e.Y));
                }
            }
        }

        private bool DisplayPhotoEditDlg(int index)
        {
            _album.CurrentPosition = index;

            using (PhotoEditDlg dlg = new PhotoEditDlg(_album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _bAlbumChanged = true;
                    return true;
                }
            }

            return false;
        }

        private void ctxtPhotoCal_MenuClick(object sender, System.EventArgs e)
        {
            PhotoMenuItem mi = sender as PhotoMenuItem;

            if ((mi != null) && (DisplayPhotoEditDlg(mi.tag)))
            {
                UpdateCalendar();
            }
        }

    }
}

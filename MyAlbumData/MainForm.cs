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

namespace MyAlbumData
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private PhotoAlbum _album;

        protected override void OnLoad(EventArgs e)
        {
            Version ver = new Version(Application.ProductVersion);
            Text = String.Format("MyAlbumData {0:#}.{1:#}", ver.Major, ver.Minor);
            
            _album = new PhotoAlbum();
            
            cmbxAlbum.DataSource = Directory.GetFiles(PhotoAlbum.DefaultDir, "*.abm");

            // Table style for PhotoAlbum data source
            DataGridTableStyle albumStyle = new DataGridTableStyle();

            albumStyle.MappingName = "PhotoAlbum";
            albumStyle.AlternatingBackColor = Color.LightGray;
            albumStyle.RowHeaderWidth = 15;

            // Column styles for PhotoAlbum source
            DataGridColumnStyle captionCol = new DataGridTextBoxColumn();
            captionCol.MappingName = "Caption";
            captionCol.HeaderText = "Caption";
            captionCol.Width = 100;

            DataGridColumnStyle validCol = new DataGridBoolColumn();
            validCol.MappingName = "IsImageValid";
            validCol.HeaderText = "Valid?";
            validCol.ReadOnly = true;
            validCol.Width = 30;

            DataGridTextBoxColumn dateCol = new DataGridTextBoxColumn();
            dateCol.MappingName = "DateTaken";
            dateCol.HeaderText = "Date Taken";
            dateCol.Alignment = HorizontalAlignment.Center;
            dateCol.Format = "d";
            dateCol.Width = 80;

            DataGridColumnStyle photographerCol = new DataGridTextBoxColumn();
            photographerCol.MappingName = "Photographer";
            photographerCol.HeaderText = "Photographer";
            photographerCol.Width = 100;

            DataGridColumnStyle fileNameCol = new DataGridTextBoxColumn();
            fileNameCol.MappingName = "FileName";
            fileNameCol.HeaderText = "Image File Name";
            fileNameCol.ReadOnly = true;
            fileNameCol.Width = 200;

            // Add the column styles to the table style
            albumStyle.GridColumnStyles.AddRange(
            new DataGridColumnStyle[] {captionCol, validCol, dateCol, photographerCol, fileNameCol});
            
            // Assign the table style to the data grid
            gridPhotoAlbum.TableStyles.Add(albumStyle);

            // Bind data for the Photo tab
            txtFileName.DataBindings.Add("Text", _album, "FileName");
            txtCaption.DataBindings.Add("Text", _album, "Caption");
            txtPhotographer.DataBindings.Add("Text", _album, "Photographer");
            dtpDateTaken.DataBindings.Add("Value", _album, "DateTaken");
            
            txtNotes.DataBindings.Add("Text", _album, "Notes");
            pboxPhoto.DataBindings.Add("Tag", _album, "Image");

            gridPhotoAlbum.SetDataBinding(_album, null);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // Complete any in-progress edits
            BindingManagerBase bm = BindingContext[_album];

            if (bm != null)
                bm.EndCurrentEdit();

            SaveChanges();
            base.OnClosing(e);
        }

        //
        // CLOSE
        //
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string albumFile = cmbxAlbum.SelectedItem.ToString();

            if (_album != null)
            {
                SaveChanges();
                _album.Dispose();
            }

            _album.Clear();

            try
            {
                _album.Open(albumFile);
                gridPhotoAlbum.CaptionText = _album.Title;
            }
            catch (Exception)
            {
                _album.Clear();
                gridPhotoAlbum.CaptionText = "Unable to open album";
            }

            // Required to prevent binding exception
            if (_album.Count == 0)
                _album.Add(new Photograph(""));

            // Refresh the Photo tab controls
            BindingManagerBase bm = this.BindingContext[_album];
            CurrencyManager cm = bm as CurrencyManager;

            if (cm != null)
                cm.Refresh();

            EnablePhotoButtons(bm);
        }

        private void SaveChanges()
        {
            if (_album.HasEdits)
            {
                DialogResult result = MessageBox.Show("Do you wish to save your changes " + "to the album \'" + _album.Title + "\'?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                    _album.Save();
            }
        }

        //
        // NEXT AND PREV BUTTONS
        // 
        private void EnablePhotoButtons(BindingManagerBase bm)
        {
            btnNext.Enabled = (bm.Position < _album.Count - 1);
            btnPrev.Enabled = (bm.Position > 0);

            // Force image to repaint
            pboxPhoto.Invalidate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            BindingManagerBase bm = BindingContext[_album];

            if ((bm != null) && (bm.Position < bm.Count - 1))
            {
                bm.Position++;
            }

            EnablePhotoButtons(bm);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            BindingManagerBase bm = BindingContext[_album];
            if ((bm != null) && (bm.Position > 0))
                bm.Position--;

            EnablePhotoButtons(bm);
        }

        private void pboxPhoto_Paint(object sender, PaintEventArgs e)
        {
            Bitmap image = pboxPhoto.Tag as Bitmap;

            if (image == null)
            {
                // No image, just clear the graphics
                e.Graphics.Clear(SystemColors.Control);
                return;
            }

            // Load the current photo
            BindingManagerBase bm = BindingContext[_album];
            Photograph photo = bm.Current as Photograph;

            Rectangle r = pboxPhoto.ClientRectangle;

            if (photo == null)
            {
                // Something is wrong, just draw the image
                e.Graphics.DrawImage(image, r);
            }
            else
            {
                // Paint the image with proper aspect ratio
                e.Graphics.DrawImage(image, photo.ScaleToFit(r));
            }
        }




    }
}

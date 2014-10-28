using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manning.MyPhotoAlbum
{
    public partial class PhotoEditDlg : BaseEditDlg
    {
        public PhotoEditDlg(PhotoAlbum album)
        {
            // This call is required . . . .
            InitializeComponent();

            // Initialize the dialog settings
            _album = album;
            _index = album.CurrentPosition;
            ResetSettings();
            SetOriginals();
        }

        private PhotoAlbum _album;
        private int _index;
        private string _origCaption;
        private DateTime _origDateTaken;
        private string _origPhotographer;
        private bool _modifiedTxtNotes;
        private bool _hasChanged = false;

        protected override void ResetSettings()
        {
            // Initialize the ComboBox settings
            if (cmbxPhotographer.Items.Count == 0)
            {
                // Create the list of photographers
                cmbxPhotographer.BeginUpdate();
                cmbxPhotographer.Items.Clear();
                cmbxPhotographer.Items.Add("unknown");

                foreach (Photograph ph in _album)
                {
                    if (ph.Photographer != null && !cmbxPhotographer.Items.Contains(ph.Photographer))
                    {
                        cmbxPhotographer.Items.Add(ph.Photographer);
                    }
                }
                cmbxPhotographer.EndUpdate();
            }

            Photograph photo = _album[_index];

            if (photo != null)
            {
                txtPhotoFile.Text = photo.FileName;
                txtCaption.Text = photo.Caption;
                dtpDateTaken.Value = photo.DateTaken;
                cmbxPhotographer.SelectedItem = photo.Photographer;
                txtNotes.Text = photo.Notes;
            }

            btnPrev.Enabled = !(_index == 0);
            btnNext.Enabled = !(_index == _album.Count - 1);
        }

        protected override bool SaveSettings()
        {
            if (NewControlValues())
            {
                // Save the photograph’s settings
                Photograph photo = _album.CurrentPhoto;

                if (photo != null)
                {
                    photo.Caption = txtCaption.Text;
                    photo.DateTaken = dtpDateTaken.Value;
                    photo.Photographer = cmbxPhotographer.Text;
                    photo.Notes = txtNotes.Text;
                    _hasChanged = true;
                }
            }

            return true;
        }

        private void txtCaption_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            e.Handled = !(Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c) || Char.IsControl(c));
        }

        private void txtCaption_TextChanged(object sender, EventArgs e)
        {
            this.Text = String.Format("{0} - Photo Properties", txtCaption.Text);
        }

        private void cmbxPhotographer_Validated(object sender, EventArgs e)
        {
            string pg = cmbxPhotographer.Text;

            if (!cmbxPhotographer.Items.Contains(pg))
            {
                _album.CurrentPhoto.Photographer = pg;
                cmbxPhotographer.Items.Add(pg);
            }
            cmbxPhotographer.SelectedItem = pg;
        }

        private void cmbxPhotographer_TextChanged(object sender, EventArgs e)
        {
            string text = cmbxPhotographer.Text;
            int index = cmbxPhotographer.FindString(text);

            if (index >= 0)
            {
                // Found a match
                string newText = cmbxPhotographer.Items[index].ToString();
                cmbxPhotographer.Text = newText;
                cmbxPhotographer.SelectionStart = text.Length;
                cmbxPhotographer.SelectionLength = newText.Length - text.Length;
            }
        }

        protected void SetOriginals()
        {
            Photograph photo = _album[_index];

            if (photo != null)
            {
                _origCaption = photo.Caption;
                _origDateTaken = photo.DateTaken;
                _origPhotographer = photo.Photographer;
                _modifiedTxtNotes = false;
            }
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            if (txtNotes.Focused)
                _modifiedTxtNotes = true;
        }

        protected bool NewControlValues()
        {
            bool result = ((_origCaption != txtCaption.Text) || (_origDateTaken != dtpDateTaken.Value) || (_origPhotographer != cmbxPhotographer.Text) || (_modifiedTxtNotes));

            return result;
        }

        public bool HasChanged
        {
            get
            {
                return _hasChanged;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveSettings();

            if (_index < _album.Count - 1)
            {
                _index++;
                ResetSettings();
                SetOriginals();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            SaveSettings();

            if (_index > 0)
            {
                _index--;
                ResetSettings();
                SetOriginals();
            }
        }
    }
}

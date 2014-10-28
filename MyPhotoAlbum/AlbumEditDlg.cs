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
    public partial class AlbumEditDlg : BaseEditDlg
    {
        public AlbumEditDlg(PhotoAlbum album)
        {
            InitializeComponent();

            // Initialize radio button tags
            this.rbtnCaption.Tag = (int)PhotoAlbum.DisplayValEnum.Caption;
            this.rbtnDate.Tag = (int)PhotoAlbum.DisplayValEnum.Date;
            this.rbtnFileName.Tag = (int)PhotoAlbum.DisplayValEnum.FileName;

            // Initialize the dialog settings
            _album = album;
            ResetSettings();
        }

        private PhotoAlbum _album;

        private PhotoAlbum.DisplayValEnum _selectedDisplayOption;

        private void DisplayOption_Click(object sender, System.EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null)
                this._selectedDisplayOption = (PhotoAlbum.DisplayValEnum)rb.Tag;
        }

        private void cbtnPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Enable pwd controls as required.
            bool enable = cbtnPassword.Checked;
            txtAlbumPwd.Enabled = enable;
            lblConfirmPwd.Enabled = enable;
            txtConfirmPwd.Enabled = enable;

            if (enable)
            {
                // Assign focus to pwd text box
                txtAlbumPwd.Focus();
            }

        }

        private void txtAlbumPwd_Validating(object sender, CancelEventArgs e)
        {
            if (txtAlbumPwd.TextLength == 0)
            {
                MessageBox.Show(this, "The password for the album " + "cannot be blank", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private bool ValidPasswords()
        {
            if ((cbtnPassword.Checked) && (txtConfirmPwd.Text != txtAlbumPwd.Text))
            {
                MessageBox.Show(this, "The password and confirm " + "values do not match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        protected override void ResetSettings()
        {
            // Set file name
            txtAlbumFile.Text = _album.FileName;

            // Set title, and use in title bar
            this.txtTitle.Text = _album.Title;
            this.Text = String.Format("{0} - Album Properties", txtTitle.Text);

            // Set display option values
            _selectedDisplayOption = _album.DisplayOption;

            switch (_selectedDisplayOption)
            {
                case PhotoAlbum.DisplayValEnum.Date:
                    this.rbtnDate.Checked = true;
                    break;

                case PhotoAlbum.DisplayValEnum.FileName:
                    this.rbtnFileName.Checked = true;
                    break;

                case PhotoAlbum.DisplayValEnum.Caption:
                default:
                    this.rbtnCaption.Checked = true;
                    break;
            }

            string pwd = _album.Password;
            cbtnPassword.Checked = (pwd != null && pwd.Length > 0);
            txtAlbumPwd.Text = pwd;
            txtConfirmPwd.Text = pwd;
        }

        protected override bool SaveSettings()
        {
            bool valid = ValidPasswords();

            if (valid)
            {
                _album.Title = txtTitle.Text;
                _album.DisplayOption = this._selectedDisplayOption;
                if (cbtnPassword.Checked)
                    _album.Password = txtAlbumPwd.Text;
                else
                    _album.Password = null;
            }

            return valid;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            this.Text = String.Format("{0} - Album Properties", txtTitle.Text);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;

namespace MyPhotos
{
    public partial class SlideShowForm : Form
    {
        public SlideShowForm(PhotoAlbum album)
        {
            // Required for Form Designer support
            InitializeComponent();

            // Other initialization
            _album = album;
            _albumPos = 0;
        }

        private PhotoAlbum _album;
        private int _albumPos;

        protected void SetInterval()
        {
            int interval = 0;

            try
            {
                interval = Convert.ToInt32(txtInterval.Text);
            }
            catch
            {
                // Reset interval value
                txtInterval.Text = "2";
                interval = 2;
            }

            slideTimer.Interval = interval * 1000;
        }

        protected override void OnLoad(EventArgs e)
        {
            SetInterval();
            slideTimer.Enabled = true;

            trackSlide.Minimum = 0;
            trackSlide.Maximum = _album.Count - 1;
            base.OnLoad(e);
        }

        private void pboxSlide_Paint(object sender, PaintEventArgs e)
        {
            if (_albumPos >= _album.Count)
                return;

            Photograph photo = _album[_albumPos];
            if (photo != null)
            {
                this.Text = String.Format("{0} ({1:#}/{2:#})", photo.Caption, _albumPos + 1, _album.Count);
                e.Graphics.DrawImage(photo.Image, photo.ScaleToFit(pboxSlide.ClientRectangle));
            }
            else
                e.Graphics.Clear(SystemColors.Control);
        }

        private void slideTimer_Tick(object sender, EventArgs e)
        {
            _albumPos++;

            if (_albumPos > _album.Count)
            {
                btnStop.Text = "&Start";
                _albumPos = 0;
                trackSlide.Value = 0;
                pboxSlide.Invalidate();
                slideTimer.Enabled = false;
            }
            else if (_albumPos == _album.Count)
            {
                this.Text = "Finished";
            }
            else
            {
                pboxSlide.Invalidate();
                trackSlide.Value = _albumPos;
            }

            // Reset the interval
            SetInterval();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (btnStop.Text == "&Stop")
            {
                // Stop
                slideTimer.Stop();
                btnStop.Text = "Re&sume";
            }
            else
            {
                // Resume or Start
                slideTimer.Start();
                btnStop.Text = "&Stop";
            }
        }

        private void trackSlide_Scroll(object sender, EventArgs e)
        {
            _albumPos = trackSlide.Value;
            pboxSlide.Invalidate();
        }

        private void pboxSlide_Resize(object sender, EventArgs e)
        {
            pboxSlide.Invalidate();
        }
    }
}

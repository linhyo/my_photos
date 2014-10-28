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
    public partial class BaseEditDlg : Form
    {
        public BaseEditDlg()
        {
            InitializeComponent();
        }

        protected virtual void ResetSettings()
        {
            // Subclasses override to reset form
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }

        protected virtual bool SaveSettings()
        {
            // Subclasses override to save form
            return true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!e.Cancel && (this.DialogResult == DialogResult.OK))
            {
                e.Cancel = !SaveSettings();
            }

            base.OnClosing(e);
        }
    }
}

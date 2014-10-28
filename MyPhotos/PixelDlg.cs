using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPhotos
{
    public partial class PixelDlg : Form
    {
        public PixelDlg()
        {
            InitializeComponent();
        }

        static private Form _mdiForm = null;
        static private PixelDlg _globalDlg;

        static internal Form GlobalMdiParent
        {
            get
            {
                return _mdiForm;
            }
            set
            {
                _mdiForm = value;
            }
        }

        static public PixelDlg GlobalDialog
        {
            get
            {
                if (_globalDlg == null || _globalDlg.IsDisposed)
                {
                    _globalDlg = new PixelDlg();
                    _globalDlg.MdiParent = GlobalMdiParent;
                }

                return _globalDlg;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int XVal
        {
            set
            {
                lblXVal.Text = value.ToString();
            }
        }

        public int YVal
        {
            set
            {
                lblYVal.Text = value.ToString();
            }
        }

        public int RedVal
        {
            set
            {
                lblRedVal.Text = value.ToString();
            }
        }

        public int GreenVal
        {
            set
            {
                lblGreenVal.Text = value.ToString();
            }
        }

        public int BlueVal
        {
            set
            {
                lblBlueVal.Text = value.ToString();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Visible = false;

            if (this.Owner != null)
                Owner.Activate();

            base.OnClosing(e);
        }
    }
}

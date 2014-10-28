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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            // Required for Designer support
            InitializeComponent();

            // Initialize toolbar buttons
            tbbNew.Tag = menuNew;
            tbbOpen.Tag = menuOpen;
        }

        /// <summary>
        /// Entry point for MDI application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new ParentForm());
        }

        //
        // EXIT
        //
        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        // NEW
        //
        private void menuNew_Click(object sender, EventArgs e)
        {
            MainForm newChild = new MainForm();
            newChild.MdiParent = this;
            newChild.Show();
        }

        //
        // OPEN
        //
        private void menuOpen_Click(object sender, EventArgs e)
        {
            // Allow user to select a new album
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Album";
                dlg.Filter = "abm files (*.abm)|" + "*.abm|All files (*.*)|*.*";
                dlg.InitialDirectory = PhotoAlbum.DefaultDir;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // See if album is already open
                        foreach (Form f in MdiChildren)
                        {
                            if (f is MainForm)
                            {
                                MainForm mf = (MainForm) f;

                                if (mf.AlbumFile == dlg.FileName)
                                {
                                    if (mf.WindowState == FormWindowState.Minimized)
                                    {
                                        mf.WindowState = FormWindowState.Normal;
                                    }
                                    mf.BringToFront();
                                    return;
                                }
                            }
                        }

                        // Open new child window for the album
                        MainForm form = new MainForm(dlg.FileName);
                        form.MdiParent = this;
                        form.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Unable to open file " + dlg.FileName + "\n (" + ex.Message + ")", "Open Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolBarParent_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.Tag is MenuItem)
            {
                MenuItem mi = e.Button.Tag as MenuItem;
                mi.PerformClick();
                return;
            }

            // Must be MDI child button
            MainForm child = ActiveMdiChild as MainForm;

            if (child != null)
            {
                if (e.Button == tbbSave)
                    child.ClickSaveMenu();

                else if (e.Button == tbbPrev)
                    child.ClickPreviousMenu();

                else if (e.Button == tbbNext)
                    child.ClickNextMenu();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            PixelDlg.GlobalMdiParent = this;
            SetTitleBar();

            base.OnLoad(e);
        }

        protected override void OnMdiChildActivate(System.EventArgs e)
        {
            SetTitleBar();
            base.OnMdiChildActivate(e);
        }

        protected void SetTitleBar()
        {
            Version ver = new Version(Application.ProductVersion);

            string titleBar = "{0} - MyPhotos MDI {1:#}.{2:#}";

            if (ActiveMdiChild is MainForm)
            {
                string albumTitle = ((MainForm)ActiveMdiChild).AlbumTitle;
                this.Text = String.Format(titleBar, albumTitle, ver.Major, ver.Minor);
            }
            else if (ActiveMdiChild is PixelDlg)
            {
                this.Text = String.Format(titleBar, "Pixel Data", ver.Major, ver.Minor);
            }
            else
            {
                this.Text = String.Format("MyPhotos MDI {0:#}.{1:#}", ver.Major, ver.Minor);
            }
        }

        private void menuArrange_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void menuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuPageSetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog dlg = new PageSetupDialog();
            dlg.Document = printDoc;
            dlg.ShowDialog();
        }

        private void menuPrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = printDoc;
            dlg.ShowDialog();
        }

        private void menuPrint_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.Document = printDoc;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            MainForm f = ActiveMdiChild as MainForm;

            if (f != null)
                f.PrintCurrentImage(e);
            else
                e.Cancel = true;
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutBox dlg = new AboutBox();
            Version ver = new Version(Application.ProductVersion);
            dlg.AboutText = String.Format("MyPhotos (MDI) " 
            + "Application, Version {0:#}.{1:#} "
            + "\nSample for Windows Forms "
            + "Programming with C#\"\nby "
            + "Erik Brown \nCopyright (C) 2001 "
            + "Manning Publications Co.", ver.Major, ver.Minor);
            dlg.Owner = this;
            dlg.Icon = this.Icon;
            dlg.Show();
        }

    }
}

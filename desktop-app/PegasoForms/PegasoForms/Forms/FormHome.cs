using PegasoForms.Classes;
using System;
using System.Windows.Forms;

namespace PegasoForms.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            this.Text = Constants.SYSTEM_TITLE;
            FormUtils.StartLayout(this, Constants.SYSTEM_ICON);

            StartComponents();
            FixedMaximized();
        }


        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new FormAbout().ShowDialog();      
        }

        private void FixedMaximized()
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
            }
        }
        
        private void FormHome_ResizeEnd(object sender, EventArgs e)
        {
            FixedMaximized();
        }
        
        private void StartComponents()
        {
            //MENU
            FormUtils.StartMenuItem(AboutToolStripMenuItem, Constants.ABOUT_IMAGE, Constants.ABOUT_MENU_TITLE);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_NCLBUTTONDBLCLK = 0x00A3;

            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                FixedMaximized();
            }
        }

    }
}

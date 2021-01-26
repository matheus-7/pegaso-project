using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PegasoModels;

namespace PegasoForms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            FixedMaximized();
        }


        private void FormHome_ResizeEnd(object sender, EventArgs e)
        {
            FixedMaximized();
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

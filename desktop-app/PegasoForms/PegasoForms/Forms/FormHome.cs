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
            //SETTINGS MENU
            FormUtils.StartMenuItem(SettingsToolStripMenuItem, Constants.SETTINGS_IMAGE, Constants.SETTINGS_MENU_TITLE);
                FormUtils.StartMenuItem(CompanyToolStripMenuItem, Constants.COMPANY_IMAGE, Constants.COMPANY_MENU_TITLE);
                FormUtils.StartMenuItem(EntitiesToolStripMenuItem, Constants.ENTITIES_IMAGE, Constants.ENTITIES_MENU_TITLE);

                //MATERIALS MENU
                FormUtils.StartMenuItem(MaterialsToolStripMenuItem, Constants.MATERIALS_IMAGE, Constants.MATERIALS_MENU_TITLE);
                    FormUtils.StartMenuItem(CategoriesToolStripMenuItem, Constants.CATEGORIES_IMAGE, Constants.CATEGORIES_MENU_TITLE);
                    FormUtils.StartMenuItem(ProductsToolStripMenuItem, Constants.PRODUCTS_IMAGE, Constants.PRODUCTS_MENU_TITLE);
                    FormUtils.StartMenuItem(UnitMeasurementsToolStripMenuItem, Constants.UNIT_MEASUREMENTS_IMAGE, Constants.UNIT_MEASUREMENTS_MENU_TITLE);
            
                FormUtils.StartMenuItem(UsersToolStripMenuItem, Constants.USERS_IMAGE, Constants.USERS_MENU_TITLE);


            //MOVEMENTS MENU
            FormUtils.StartMenuItem(MovementsToolStripMenuItem, Constants.MOVEMENTS_IMAGE, Constants.MOVEMENTS_MENU_TITLE);
            
            //REPORTS MENU
            FormUtils.StartMenuItem(ReportsToolStripMenuItem, Constants.REPORTS_IMAGE, Constants.REPORTS_MENU_TITLE);
            
            //ABOUT MENU
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

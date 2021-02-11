using PegasoForms.Classes;
using PegasoModels;
using PegasoModels.Models;
using System;
using System.Windows.Forms;

namespace PegasoForms.Forms
{
    public partial class FormHome : Form
    {
        public ImageList ImlTabs;

        public FormHome(User user)
        {
            InitializeComponent();

            this.Text = Constants.SYSTEM_TITLE;
            FormUtils.StartLayout(this, Constants.SYSTEM_ICON);

            StartComponents();
            FixedMaximized();

            Global.User = user;
        }


        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new FormAbout().ShowDialog();      
        }

        private void CompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTab(new FormCompany(), 1);
        }

        private void CreateTab(UserControl form, int imageIndex)
        {
            string tabTitle = form.Text;

            foreach (TabPage tab in tbcModules.TabPages)
            {
                if (tab.Name.Equals(tabTitle))
                {
                    tbcModules.SelectedTab = tab;
                    return;
                }
            }

            TabPage tabPage = new TabPage();
            tabPage.Name = tabTitle;
            tabPage.Text = tabTitle;
            tabPage.ImageIndex = imageIndex;
            tabPage.Controls.Add(form);

            tbcModules.TabPages.Add(tabPage);
            tbcModules.SelectedTab = tabPage;
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

            //IMAGE LIST
            StartImageList();
            
            //TAB CONTROL
            StartTabControl();
        }

        private void StartImageList()
        {
            ImlTabs = new ImageList();

            ImlTabs.Images.Add(Constants.SETTINGS_IMAGE);          //0
            ImlTabs.Images.Add(Constants.COMPANY_IMAGE);           //1
            ImlTabs.Images.Add(Constants.ENTITIES_IMAGE);          //2
            ImlTabs.Images.Add(Constants.MATERIALS_IMAGE);         //3
            ImlTabs.Images.Add(Constants.CATEGORIES_IMAGE);        //4
            ImlTabs.Images.Add(Constants.PRODUCTS_IMAGE);          //5
            ImlTabs.Images.Add(Constants.UNIT_MEASUREMENTS_IMAGE); //6
            ImlTabs.Images.Add(Constants.USERS_IMAGE);             //7
            ImlTabs.Images.Add(Constants.MOVEMENTS_IMAGE);         //8
            ImlTabs.Images.Add(Constants.REPORTS_IMAGE);           //9
            ImlTabs.Images.Add(Constants.ABOUT_IMAGE);             //10
        }

        private void StartTabControl()
        {
            tbcModules.ImageList = ImlTabs;
            tbcModules.Dock = DockStyle.Fill;
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTab(new FormUser(), 7);
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

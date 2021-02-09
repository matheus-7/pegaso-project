using PegasoForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegasoForms.Forms
{
    public partial class FormCompany : UserControl
    {
        public FormCompany()
        {
            InitializeComponent();

            this.Text = Constants.COMPANY_MENU_TITLE;
            this.Dock = DockStyle.Fill;
        }
    }

}

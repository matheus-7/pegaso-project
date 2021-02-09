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
    public partial class FormUser : UserControl
    {
        public FormUser()
        {
            InitializeComponent();

            this.Text = Constants.USERS_MENU_TITLE;
            this.Dock = DockStyle.Fill;
        }

    }
}

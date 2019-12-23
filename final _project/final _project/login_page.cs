using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final__project
{
    public partial class login_page :MaterialSkin.Controls.MaterialForm
    {
        user user = new user();
        public login_page()
        {
            InitializeComponent();
        }

        private void login_page_Load(object sender, EventArgs e)
        {
         
        }

        private void submitadmin_Click(object sender, EventArgs e)
        {
           
            string username=adminuser.Text;
            string password=adminpass.Text;
            if (user.check(username, password))
            {
                admin_page admin_page = new admin_page();
                admin_page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("something is else");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
namespace studentreg2
{
    public partial class update_info :MaterialSkin.Controls.MaterialForm
    {
        public update_info()
        {
            InitializeComponent();
        }

        private void update_info_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            user user = new user();
            string up_first_name = up_firstt.Text;
           string up_lest_name = up_lestt.Text;
           
      
            
            if(user.check(up_first_name,up_lest_name))
            {
                MessageBox.Show("user is found","found",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {       
                    MessageBox.Show("user is not found","not found",MessageBoxButtons.OK,MessageBoxIcon.Information);
                  
            }

        }

        private void up_first_Click(object sender, EventArgs e)
        {

        }

        private void up_firstt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

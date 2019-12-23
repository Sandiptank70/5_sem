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

namespace final__project
{
    public partial class update_info : Form
    {
        public update_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = update_fname.Text;
            string name = update_name.Text;
            string lname=update_lname.Text;
            string stud_std = update_standred.Text;
            string stud_class = update_class.Text;
            string query = "select * from student where'stud_fname'=fname AND 'stud_name'=name AND 'stud_lname'=lname AND 'std'=stud_std AND 'stud_class'=stud_class";
            MySqlCommand cmd = new MySqlCommand(query);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("found");
            }

        }
    }
}

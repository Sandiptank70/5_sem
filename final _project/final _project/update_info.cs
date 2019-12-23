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
        my_db db = new my_db();
        public update_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // db.closeConnection();
            string fname = update_fname.Text;
            string name = update_name.Text;
            string lname=update_lname.Text;
            string stud_std = update_standred.Text;
            string stud_class = update_class.Text;
          //  string query = 
            MySqlCommand cmd = new MySqlCommand("select * from student where'grno'="+fname,db.getConection);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@std", stud_std);
            cmd.Parameters.AddWithValue("@clsaa", stud_class);
          //  db.openConnection();
            MySqlDataReader drdata = cmd.ExecuteReader();
            if (drdata.Read())
            {
              //  db.closeConnection();
                MessageBox.Show("found");
            }

        }

        private void update_info_Load(object sender, EventArgs e)
        {
            db.openConnection();
        }
    }
}

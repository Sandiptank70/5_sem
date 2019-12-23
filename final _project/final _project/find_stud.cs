using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace final__project
{
    public partial class find_stud : Form
    {
        my_db db = new my_db();
        public find_stud()
        {
            InitializeComponent();
        }

        private void find_gr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GR = find_gr.Text;
            MySqlCommand find = new MySqlCommand("select * from student where grno="+GR, db.getConection);
            db.openConnection();
            MySqlDataReader datare = find.ExecuteReader();
            if (datare.Read())
            {
                db.closeConnection();
                MessageBox.Show("find");

            }
            else
            {
                db.closeConnection();
                MessageBox.Show("not find");
            }
        } 
    }
}

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
    public partial class view_data : Form
    {
        my_db db = new my_db();
        public view_data()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void view_standrad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void view_submit_Click(object sender, EventArgs e)
        {

            string std = view_standrad.Text;
           // string class123= view_class1.Text;
       //     MessageBox.Show(class123);
           MySqlDataAdapter data = new MySqlDataAdapter("select * from student where stud_std="+std,db.getConection);
            DataTable dtbl = new DataTable();
            data.Fill(dtbl);
            MessageBox.Show(dtbl.Rows.Count.ToString());
           dgvl1.DataSource = dtbl;
           dgvl1.Refresh();
            


        }

        private void view_data_Load(object sender, EventArgs e)
        {
            db.openConnection();
        }
    }
}

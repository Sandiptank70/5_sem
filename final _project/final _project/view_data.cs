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
        my_db my_db = new my_db();
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
            string CLass = view_class1.Text;
            


        }
    }
}

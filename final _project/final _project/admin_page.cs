using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final__project
{
    public partial class admin_page : Form
    {
        public admin_page()
        {
            InitializeComponent();
        }

        private void admin_page_Load(object sender, EventArgs e)
        {
           
        }

        private void student_Click(object sender, EventArgs e)
        {
            student_reg student_reg = new student_reg();
            student_reg.Show();
            this.Hide();
        }
    }
}

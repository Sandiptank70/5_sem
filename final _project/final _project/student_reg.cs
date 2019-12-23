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

namespace final__project
{
    public partial class student_reg :MaterialSkin.Controls.MaterialForm
    {
        public student_reg()
        {
            InitializeComponent();
        }

        private void student_reg_Load(object sender, EventArgs e)
        {

        }

        private void registion_Click(object sender, EventArgs e)
        {
            student_reg_form student_reg_form = new student_reg_form();
            student_reg_form.Show();
            this.Hide();
        }

        private void view_Click(object sender, EventArgs e)
        {
            view_data view_data = new view_data();
            view_data.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update_info update_info = new update_info();
            update_info.Show();
            this.Hide();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            
        }

        private void find_Click(object sender, EventArgs e)
        {
            find_stud find_stud = new find_stud();
            find_stud.Show();
            this.Hide();

        }
    }
}

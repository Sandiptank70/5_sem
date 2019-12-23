using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentreg2
{
    public partial class student_registration : MaterialSkin.Controls.MaterialForm
    {
        public student_registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void student_registration_Load(object sender, EventArgs e)
        {

        }

        private void new1_Click(object sender, EventArgs e)
        {
            student_form obj = new student_form();
            obj.Show();
            student_registration obj2 = new student_registration();
            obj2.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update_info update_info = new update_info();
            update_info.Show();
          
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}

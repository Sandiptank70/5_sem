using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentreg2
{
    public partial class student_form :MaterialSkin.Controls.MaterialForm
    {
        public student_form()
        {
            InitializeComponent();
        }

        private void student_form_Load(object sender, EventArgs e)
        {

        }
        public bool veri(string operation)
        {
            bool check = false;
            if (operation == "save")
            {
                if (faname.Text.Equals("")||Fname.Text.Equals("")||lname.Text.Equals("")||Mobile.Text.Equals("")||standrad.Text.Equals("")||class1.Text.Equals("")||eadd.Text.Equals("")||address1.Text.Equals("")||city1.Text.Equals(""))
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
          
           return check;
        }

        private void save_Click(object sender, EventArgs e)
        {
        
        
            string fnames = Fname.Text;
            string Lnames = lname.Text;
            string father=faname.Text;
            string Emails=eadd.Text;
            string  Mobiles=mo.Text;
            string Std=std.Text;
            string Class2=Class3.Text;
            string address=address1.Text;
            user user = new user();
            if (veri("save"))
            {
                //fname,lname,faname,Mobile,Std,Class2,Emails,address
                    if(user.insertUser(fnames,Lnames,father,Mobiles,Std,Class2,Emails,address))
                    {
                        MessageBox.Show("registration complated successfully ","Register",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                         MessageBox.Show("something wrong","Register",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
             }
            
       
        }

        private void std_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        }
    
}

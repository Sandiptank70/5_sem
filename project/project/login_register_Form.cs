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

namespace project
{
    public  partial class login_register_Form : Form
    {
        public login_register_Form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_register_Form_Load(object sender, EventArgs e)
        {
          
        }

        private void gotoregister_Click(object sender, EventArgs e)
        {
           timer1.Start();
            gotoregister.Enabled=false;
            alreadyaccount.Enabled=false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            timer2.Start();
            alreadyaccount.Enabled = false;
            gotoregister.Enabled = false;
        }

       

        private void buttonclose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonminize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void oldpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void newpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void oldusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panel2.Location.X > -500)
            {
                panel2.Location=new Point(panel2.Location.X -500,panel2.Location.Y);
            }
            else
            {
                timer1.Stop();
                alreadyaccount.Enabled=true;
                gotoregister.Enabled=true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel2.Location.X < 0)
            {
                panel2.Location = new Point(panel2.Location.X +  500, panel2.Location.Y);
            }
            else
            {
                timer2.Stop();
                alreadyaccount.Enabled = true;
                gotoregister.Enabled = true;
            }

        }

        public bool veri(string operation)
        {
            bool check=false;
            if(operation=="register")
            {
                if(newfirstname.Text.Equals("")||newlestname.Text.Equals("")||newpassword.Text.Equals("")||newusername.Text.Equals(""))
                {
                    check = false;
                }
                else
                {
                    check=true;
                }
            }
            else if(operation=="login")
            {
                if(oldusername.Text.Equals("")||oldpassword.Text.Equals(""))
                {
                    check=false;
                }
                else
                {
                    check=true;
                }
            }
            return check;
        }


        private void browse_Click(object sender, EventArgs e)
        {
           OpenFileDialog opf = new OpenFileDialog();
           opf.Filter="Select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
           if (opf.ShowDialog() == DialogResult.OK)
            {
                profile.Image = Image.FromFile(opf.FileName);
            }
            

        }

        private void rigister_Click(object sender, EventArgs e)
        {
            string fname = newfirstname.Text;
            string lname = newlestname.Text;
            string username = newusername.Text;
            string password = newpassword.Text;
            user user = new user();

            if (veri("rigister"))
            {
                MemoryStream pic= new MemoryStream();
                profile.Image.Save(pic, profile.Image.RawFormat);
                if(!user.usernameExists(username))
                {
                    if(user.insertUser(fname,lname,username,password,pic))
                    {
                        MessageBox.Show("registration complated successfully ","Register",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                         MessageBox.Show("something wrong","Register",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            else
                {
                     MessageBox.Show("this username already exists try another","invalid username",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        else
            {
                 MessageBox.Show("* required filds - username/password/profilepic","Register",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

       


        


    }
}

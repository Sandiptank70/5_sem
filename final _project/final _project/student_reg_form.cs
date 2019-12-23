using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace final__project
{
    public partial class student_reg_form : Form
    {
        my_db db = new my_db();
        public student_reg_form()
        {
            InitializeComponent();
        }

        private void student_reg_form_Load(object sender, EventArgs e)
        {
            
            
            
            db.openConnection();
        }
        private void brose_Click(object sender, EventArgs e)
        {


            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                profile.Image = Image.FromFile(opf.FileName);
            }


        }
        public bool veri(string operation)
        {
            bool check = false;
            if (operation == "student_submit")
            {
                if (textBoxfname.Text.Equals("") || textBoxmname.Text.Equals("") || textBoxlname.Text.Equals("") || textboxmother.Text.Equals("") || bodtext.Text.Equals("") || textboxaddress.Text.Equals("") || phone.Text.Equals("") || textboxmobile.Text.Equals("") || textBoxemail.Text.Equals("") || textBoxcast.Text.Equals("") || comboBoxstd.Text.Equals("") || textBoxbodis.Text.Equals("") || textBoxbop.Text.Equals("") || textBoxmotherton.Text.Equals("") || comboBoxcast.Text.Equals("") || Class.Text.Equals(""))
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



        private void student_submit_Click(object sender, EventArgs e)
        {

            string gr = grno.Text;
                string fname = textBoxfname.Text;
                string stud_name = textBoxmname.Text;
                string lname = textBoxlname.Text; 
                string mother = textboxmother.Text;
                string bod = bodtext.Text;
                string address = textboxaddress.Text;
                string phonef = textBoxphone.Text;
                string mobile = textboxmobile.Text;
                string email = textBoxemail.Text;
                string cast = textBoxcast.Text;
                string standrad = comboBoxstd.Text;
                string bodi = textBoxbodis.Text;
                string boplace = textBoxbop.Text;
                string mothertong = textBoxmotherton.Text;
                string standradofcast = comboBoxcast.Text;
               // string CLass = Class.Text;
                string rig_date = rigdate.Text;
                string stand_class = standred_class12.Text;

                if (veri("student_submit"))
                {
                    MemoryStream pic = new MemoryStream();
                    profile.Image.Save(pic, profile.Image.RawFormat);
                  
                    MySqlCommand cmd = new MySqlCommand("insert into student(grno,stud_fname,stud_name,stud_lname,mother_name,bod,address,phone,mobile,email,stud_cast,soc,bodis, bop, mother_ton,stud_std,stud_class, rig_date,image)values(@Gr,@fname,@name,@lname,@mother,@bod,@address,@phone,@mobile,@email,@cast,@soc,@boids,@bop,@mother_ton,@std,@stud_class,@rig_date,@pic)", db.getConection);
                    cmd.Parameters.AddWithValue("@Gr", gr);                 
                    cmd.Parameters.AddWithValue("@fname", fname);//,stud_class, rig_date
                    cmd.Parameters.AddWithValue("@cast", cast);//,@std_class,@rig_date
                    cmd.Parameters.AddWithValue("@mother", mother);
                    cmd.Parameters.AddWithValue("@bod", bod);
                    cmd.Parameters.AddWithValue("@name", stud_name);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phonef);
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.Parameters.AddWithValue("@soc", standradofcast);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@boids", bodi);
                    cmd.Parameters.AddWithValue("@bop", boplace);
                    cmd.Parameters.AddWithValue("@mother_ton", mothertong);
                    cmd.Parameters.AddWithValue("@std", standrad);
                    cmd.Parameters.AddWithValue("@stud_class", stand_class);
                    cmd.Parameters.AddWithValue("@rig_date", rig_date);
                    cmd.Parameters.AddWithValue("@pic", pic);
                    cmd.ExecuteNonQuery();

                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        //b.closeConnection();
                        MessageBox.Show("success");
                    }
                    else
                    {
                        //b.closeConnection();
                        MessageBox.Show("fail");
                    }

                }
                else
                {
                    MessageBox.Show("plese fill all colum");
                }
        
    }
    

            

        }

   

       }


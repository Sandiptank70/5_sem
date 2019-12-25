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
            string GR = update_gr.Text;
          //  string query = 
            MySqlCommand cmd = new MySqlCommand("select * from student where grno="+GR,db.getConection);
     
          //  db.openConnection();
            MySqlDataReader drdata = cmd.ExecuteReader();
            if (drdata.Read())
            {
                
                
                //  db.closeConnection();
                byte[] update_image = ((byte[])drdata["image"]);
                update_fname.Text = (drdata["stud_fname"].ToString());
                update_lname.Text = (drdata["stud_lname"].ToString());
                update_name.Text = (drdata["stud_name"].ToString());
                update_standred.Text = (drdata["stud_std"].ToString());
                update_soc.Text = (drdata["soc"].ToString());
                update_phone.Text = (drdata["phone"].ToString());
                update_mobile.Text = (drdata["mobile"].ToString());
                update_mname.Text = (drdata["mother_name"].ToString());
                update_class.Text = (drdata["stud_class"].ToString());
                id.Text = (drdata["id"].ToString());
                update_cast.Text = (drdata["stud_cast"].ToString());
                update_bod.Text = (drdata["bod"].ToString());
                update_bop.Text = (drdata["bop"].ToString());
                update_bodis.Text = (drdata["bodis"].ToString());
             //   update_add.Text = (drdata["address"].ToString());
                update_email.Text = (drdata["email"].ToString());

                drdata.Close();


            }
            else
            {
                MessageBox.Show("this gr number is not found");
            }

        }

        private void update_info_Load(object sender, EventArgs e)
        {
            db.openConnection();
        }

        private void update_Click(object sender, EventArgs e)
        {//, `stud_name` = @name, `stud_lname` = @lname,`mother_name` = @moname, `bod` =@bod,'address'=@add,'phone'=@phone,'mobile'=@mobile,'email'=@email,'stud_cast'=@cast,'soc'=@soc,'bodis'=@bodis,'bop'=@bop,'stud_std'=@std,'stud_class'=@studclass
            try
            {
                //"',mother_name='" + this.update_mname.Text +"',bod='" + this.update_bod.Text + "',address='" + this.update_add + "',phone='" +this.update_phone.Text + "'mobile='" + this.update_mobile.Text + "'email='" + this.update_email.Text + "'stud_cast='" + this.update_cast.Text + "'soc='" + this.update_soc.Text + "'bodis='" + this.update_bodis.Text + "'bop='" + this.update_bop.Text + "'stud_std='" + this.update_standred.Text + "'stud_class='" + this.update_class.Text +
                string Query = "update final.student set stud_fname='" + this.update_fname.Text + "',stud_name='" + this.update_name.Text + "',stud_lname='" + this.update_lname.Text + "',mother_name='" + this.update_mname.Text + "',bod='" + this.update_bod.Text + "',phone='"+this.update_phone.Text+"',mobile='"+this.update_mobile.Text+"',email='"+this.update_email.Text+"',stud_cast='"+this.update_cast.Text+"',soc='"+this.update_soc.Text+"',bodis='"+this.update_bodis.Text+"',stud_class='"+this.update_class.Text+"' where grno='" + this.update_gr.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, db.getConection);
                MySqlDataReader MyReader2;
                db.openConnection();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                db.closeConnection();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  

            
        }
    }
}

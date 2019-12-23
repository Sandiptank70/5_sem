using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
namespace studentreg2
{
    class user
    {
        my_db db = new my_db();


        public bool insertUser(string fname, string lname, string faname, string Mobile, string Std, string Class2, string Emails, string address)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student2` (`id`, `fname`, `lname`, `faname`, `mo`, `std`, `class`, `eadd`, `add`) VALUES (NULL,@fname,@lname,@faname,@mo,@std,@class,@eadd, @add)", db.getConection);
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@faname", MySqlDbType.VarChar).Value = faname;
            command.Parameters.Add("@mo", MySqlDbType.VarChar).Value = Mobile;
            command.Parameters.Add("@std", MySqlDbType.VarChar).Value = Std;
            command.Parameters.Add("@class", MySqlDbType.VarChar).Value = Class2;
            command.Parameters.Add("@eadd", MySqlDbType.VarChar).Value = Emails;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = address;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool check(string fname, string lname)
        {   
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student2` WHERE `fname` LIKE @fname AND `lname` LIKE @lname", db.getConection);
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            db.openConnection();
            MySqlDataReader dr = command.ExecuteReader();
            if (dr.Read())         
            {
                db.closeConnection();
                return true;
              
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }

}
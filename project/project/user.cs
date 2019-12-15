using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
namespace project
{
    class user
    {
        my_db db = new my_db();
        public bool usernameExists(string username)
        {
            string query = "SELECT * FROM `student` WHERE `username`=@user";
            MySqlCommand commend = new MySqlCommand(query, db.getConection);
            commend.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            MySqlDataAdapter adapter = new MySqlDataAdapter(commend);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insertUser(string fname, string lname, string username, string password, MemoryStream profile)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student` (`id`, `fname`, `lname`, `username`, `password`, `profile`) VALUES (NULL,@fname,@lname,@user,@pass,@pic)", db.getConection);
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", MySqlDbType.VarChar).Value = profile;
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

     }
}

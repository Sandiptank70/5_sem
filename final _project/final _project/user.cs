using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace final__project
{
    class user
    {
        my_db db = new my_db();
        public bool check(string username, string password)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `faculty` WHERE `username` LIKE @username AND `password` LIKE @password", db.getConection);
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
           
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

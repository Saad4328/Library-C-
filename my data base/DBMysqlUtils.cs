using MySql.Data.MySqlclient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_data_base
{
    class DBMySqlUtils
    {
        public static MySqlConnection
            
            GetDBConnection(string host,int port,string database,string username,string passwrd)
        {
            string connString = "seveur=" + host + ";Port " + port + ";Database+" + database + ";User+" + username + ";Password" + passwrd ;
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}

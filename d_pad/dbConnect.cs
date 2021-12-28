using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace d_pad
{
    class dbConnect
    {
        MySqlConnection connection = Initialize();
        public static MySqlConnection Initialize()
        {
            MySqlConnection connection;
            String connection_str;

            String server = "localhost";
            String database = "informationdb";
            String uid = "root";
            String password = "";



            connection_str = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connection_str);
            return connection;
        }
    }
}

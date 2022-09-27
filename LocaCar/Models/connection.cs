using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocaCar.Models
{
    internal class connection
    {
        private MySqlConnection conn;
        private string server;
        private string user;
        private string pass;
        private string db;

        public connection()
        {

        }


        private void Initializate()
        {
            server = "localhost";
            db = "login_bd";
            user = "root";
            pass = "";

            string connectionString;
            connectionString = "Data Source" + server + ";Database" + db + ";User Id=" + user + ";Password" + pass + ";SSL Mode=0";
            conn = new MySqlConnection(connectionString);


        }

    }
}

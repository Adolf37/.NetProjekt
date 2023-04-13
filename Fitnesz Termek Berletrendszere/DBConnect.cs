using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Fitnesz_Termek_Berletrendszere
{
    class DBConnect
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=fitness_data;convert zero datetime=True");
   
        public MySqlConnection GetConnection()
        { return connection; }  

        // fuggveny mely megnyissa a kapcsolatot
        public void OpenCon()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //fuggveny amely bezarja a kapcsolatot
        public void CloseCon()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

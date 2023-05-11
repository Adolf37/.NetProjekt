using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Fitnesz_Termek_Berletrendszere
{
 
    class GymClass
    {
        DBConnect connect = new DBConnect();

        //fuggveny amely lekerei a tipusokat (category)
        public DataTable getType()
        {
            string selectQuery = "SELECT * FROM `category`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // uj hozzaadasa

        public bool insertGym(string no, int type, string phone, string status)
        {
            string insertQuery = "INSERT INTO `gym`(`GymId`, `GymType`, `GymPhone`, `GymStatus`) VALUES (@no,@type,@ph,@sts)";
            MySqlCommand command = new MySqlCommand(insertQuery, connect.GetConnection());
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

        //fuggveny amely leker egy listat tablaba

        public DataTable getGymList()
        {
            string selectQuery = "SELECT * FROM `gym`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool editGym(string no, int type, string phone, string status)
        {
            string editQuery = "UPDATE `gym` SET `GymId`=@no,`GymType`=@type,`GymPhone`=@ph,`GymStatus`=@sts WHERE `GymId`=@no";
            MySqlCommand command = new MySqlCommand(editQuery, connect.GetConnection());
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

        public bool removeG(string id)
        {
            string removeQuery = "DELETE FROM `gym` WHERE `GymId`=@id";
            MySqlCommand command = new MySqlCommand(removeQuery, connect.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }


    }
}

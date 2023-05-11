using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Management;

namespace Fitnesz_Termek_Berletrendszere
{
    internal class ReservationClass
    {
        DBConnect connect = new DBConnect();

        public DataTable gymByType(int type)
        {
            string selectQuery = "SELECT * FROM `gym` WHERE `GymType`=@type AND `GymStatus`='Active'";
            MySqlCommand command = new MySqlCommand(selectQuery,connect.GetConnection());
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        //Tabla lekerese
        public DataTable getReserv()
        {
            string selectQuery = "SELECT * FROM `reservation`";
            MySqlCommand command = new MySqlCommand(selectQuery,connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;


        }

        public int typeByRoomNo(string gNo)
        {
            string selectQuery = "SELECT `GymType`FROM `gym` WHERE `GymId`=@gNo";
            MySqlCommand command = new MySqlCommand(selectQuery,connect.GetConnection());
            command.Parameters.Add("@gNo",MySqlDbType.VarChar).Value = gNo;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        //foglalas hozzaadasa
        public bool addReservation(string guestId, string gymNo, DateTime dateIn, DateTime dateOut)
        {
            string insertQuery = "INSERT INTO `reservation`(`GuestId`, `GymNo`, `DateIn`, `DateOut`) VALUES (@gId,@gNo,@dIn,@dOut)";
            MySqlCommand command = new MySqlCommand(insertQuery, connect.GetConnection());
            
            command.Parameters.Add("@gId", MySqlDbType.VarChar).Value = guestId;
            command.Parameters.Add("@gNo", MySqlDbType.VarChar).Value = gymNo;
            command.Parameters.Add("@dIn", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dOut", MySqlDbType.Date).Value = dateOut;

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

        public bool updateReservation(int reserveId,string guestId, string gymNo, DateTime dateIn, DateTime dateOut)
        {
            string insertQuery = "UPDATE `reservation` SET `GuestId`=@gId,`GymNo`=@gNo,`DateIn`=@dIn,`DateOut`=@dOut WHERE `ReservId`=@rId";
            MySqlCommand command = new MySqlCommand(insertQuery, connect.GetConnection());
           
            command.Parameters.Add("@gId", MySqlDbType.VarChar).Value = guestId;
            command.Parameters.Add("@gNo", MySqlDbType.VarChar).Value = gymNo;
            command.Parameters.Add("@dIn", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dOut", MySqlDbType.Date).Value = dateOut;
            command.Parameters.Add("@rId",MySqlDbType.Int32).Value = reserveId;

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

        public bool removeReserv(int id)
        {
            string removeQuery = "DELETE FROM `reservation` WHERE `ReservId`=@id";
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

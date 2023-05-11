using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Fitnesz_Termek_Berletrendszere
{
    class GuestClass
    {
        DBConnect connect =  new DBConnect();

        //beszurok az users tablaba hogy tudjon majd Login-elni
        public bool insertUser(string fname, string phone, string email)
        {
            string insertQuery = "INSERT INTO `users`(`nev`, `telefon`, `email`) VALUES (@fname,@phone,@email)";
            MySqlCommand command = new MySqlCommand(insertQuery, connect.GetConnection());

            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            //command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            //command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;


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
        public bool insertGuest(string id, string fname, string lname, string phone)
        {
            //beszurok a guest tablaba
            string insertQuery = "INSERT INTO `guest`(`GuestId`, `GuestFirstName`, `GuestLastName`, `GuestPhone`) VALUES (@id,@fname,@lname,@phone)";
            MySqlCommand command = new MySqlCommand(insertQuery,connect.GetConnection());
            command.Parameters.Add("@id",MySqlDbType.VarChar).Value= id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            

            connect.OpenCon();
            if(command.ExecuteNonQuery() == 1 ) {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

            
            
        }

        //Fuggveny amely lekeri az osszes klienset
        public DataTable getGuests()
        {
            string selectQuery = "SELECT * FROM `guest`";
            MySqlCommand command = new MySqlCommand(selectQuery,connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand= command;
            adapter.Fill(table);

            return table;
        }

        public bool editGuest(string id, string fname, string lname, string phone)
        {
            string editQuery = "UPDATE `guest` SET `GuestId`= @id,`GuestFirstName`=@fname,`GuestLastName`= @lname,`GuestPhone`= @phone WHERE `GuestId` = @id ";
            MySqlCommand command = new MySqlCommand(editQuery, connect.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;

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
        
        public bool removeGuest(string id)
        {
            string editQuery = "DELETE FROM `guest` WHERE `GuestId` = @id";
            MySqlCommand command = new MySqlCommand(editQuery, connect.GetConnection());
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

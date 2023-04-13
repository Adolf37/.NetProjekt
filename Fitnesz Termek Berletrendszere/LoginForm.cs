using System.Data;
using MySql.Data.MySqlClient;

namespace Fitnesz_Termek_Berletrendszere
{
    public partial class LoginForm : Form
    {
        DBConnect connect = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Orange;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text.Trim().Equals("") || TextBox_email.Text =="")
            {
                MessageBox.Show("Ird be a neved es az email cimed", "Hianyzo informacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string selectquery = "SELECT * FROM users WHERE nev = @usn AND email = @email ;";
                MySqlCommand command = new MySqlCommand(selectquery, connect.GetConnection());
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBox_username.Text;

                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = TextBox_email.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);


                if (table.Rows.Count > 0)
                {
                    //Main form mutatasa
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();

                }
                else
                {
                    MessageBox.Show("Nincs ilyen nev vagy email cim", "Rossz informacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
           

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            return;
        }
    }
}
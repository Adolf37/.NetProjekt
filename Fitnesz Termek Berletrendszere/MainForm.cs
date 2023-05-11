using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitnesz_Termek_Berletrendszere
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            panel_slider.Height = button_dashboard.Height;
            panel_slider.Top = button_dashboard.Top;

            panel_m.Controls.Clear();
            panel_m.Controls.Add(panel_slide);
        }

        private void button_rental_type_Click(object sender, EventArgs e)
        {
            panel_slider.Height = button_rental_type.Height - 10;
            panel_slider.Top = button_rental_type.Top;

            panel_m.Controls.Clear();
            GymForm gym = new GymForm();
            gym.TopLevel = false;
            gym.Dock= DockStyle.Right;
            gym.FormBorderStyle = FormBorderStyle.None;
            panel_m.Controls.Add(gym);
            gym.Show();
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            panel_slider.Height = button_client.Height;
            panel_slider.Top = button_client.Top;

            panel_m.Controls.Clear();
            GuestForm guest = new GuestForm();
            guest.TopLevel = false;
            guest.Dock = DockStyle.Right;
            guest.FormBorderStyle = FormBorderStyle.None;
            panel_m.Controls.Add(guest);
            guest.Show();
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

        private void button_logout_Click(object sender, EventArgs e)
        {
            panel_slider.Height = button_logout.Height;
            panel_slider.Top = button_logout.Top;

            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
            
        }

        private void button_reserve_Click(object sender, EventArgs e)
        {
            panel_slider.Height = button_reserve.Height;
            panel_slider.Top = button_reserve.Top;

            panel_m.Controls.Clear();
            ReservationForm reservation = new ReservationForm();
            reservation.TopLevel = false;
            reservation.Dock = DockStyle.Right;
            reservation.FormBorderStyle = FormBorderStyle.None;
            panel_m.Controls.Add(reservation);
            reservation.Show();


        }
    }
}

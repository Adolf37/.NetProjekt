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
        }

        private void button_rental_type_Click(object sender, EventArgs e)
        {
            panel_slider.Height = button_rental_type.Height - 10;
            panel_slider.Top = button_rental_type.Top;
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            panel_slider.Height = button_client.Height;
            panel_slider.Top = button_client.Top;
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
    }
}

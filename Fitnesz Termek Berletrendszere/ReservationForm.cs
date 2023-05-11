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
    public partial class ReservationForm : Form
    {
        GymClass gym = new GymClass();
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            comboBox_gymtype.DataSource = gym.getType();
            comboBox_gymtype.DisplayMember = "Label";
            comboBox_gymtype.ValueMember = "CategoryId";
        }
    }
}

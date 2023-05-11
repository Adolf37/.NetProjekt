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
    public partial class GymForm : Form
    {
        GymClass gym = new GymClass();
        public GymForm()
        {
            InitializeComponent();
        }

        private void GymForm_Load(object sender, EventArgs e)
        {
            comboBox_type.DataSource = gym.getType();
            comboBox_type.DisplayMember = "Label";
            comboBox_type.ValueMember = "CategoryId";

            getGymList();

            dataGridView_gym.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string no = textBox_Id.Text;
            int type = Convert.ToInt32(comboBox_type.SelectedValue.ToString());

            string ph = textBox_phone.Text;
            string status = radioButton_active.Checked ? "Active" : "Inactive";

            try
            {
                if (gym.insertGym(no, type, ph, status))
                {
                    MessageBox.Show("Added to the gym successfully", "Add Gym", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getGymList();

                    button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Can't add to the gym", "Add Gym", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            comboBox_type.SelectedIndex = 0;
            textBox_phone.Clear();
        }

        private void getGymList()
        {
            dataGridView_gym.DataSource = gym.getGymList();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string no = textBox_Id.Text;
            int type = Convert.ToInt32(comboBox_type.SelectedValue.ToString());

            string ph = textBox_phone.Text;
            string status = radioButton_active.Checked ? "Active" : "Inactive";

            try
            {
                if (gym.editGym(no, type, ph, status))
                {
                    MessageBox.Show("Update was successfully", "Update Gym", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getGymList();

                    button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Can't Update", "Update Gym", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void dataGridView_gym_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Id.Text = dataGridView_gym.CurrentRow.Cells[0].Value.ToString();
            comboBox_type.SelectedValue = dataGridView_gym.CurrentRow.Cells[1].Value.ToString();
            textBox_phone.Text = dataGridView_gym.CurrentRow.Cells[2].Value.ToString();

            string rButton = dataGridView_gym.CurrentRow.Cells[3].Value.ToString();
            if (rButton.Equals("Active"))
            {
                radioButton_active.Checked = true;
            }
            else
            {
                radioButton_inactive.Checked = true;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_Id.Text == "")
            {
                MessageBox.Show("ERROR-Required Field", "Id Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_Id.Text;


                    Boolean deleteGuest = gym.removeG(id);

                    if (deleteGuest)
                    {
                        MessageBox.Show("Gym remove was successfully!", "Gym Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getGymList();
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR- can't remove ", "Error Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

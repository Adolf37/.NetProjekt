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
        ReservationClass reservation = new ReservationClass();
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            comboBox_gymtype.DataSource = gym.getType();
            comboBox_gymtype.DisplayMember = "Label";
            comboBox_gymtype.ValueMember = "CategoryId";

            // gym megjelenitese tipus alapjan (legyen active a status)
            int type = Convert.ToInt32(comboBox_gymtype.SelectedValue.ToString());
            comboBox_gymno.DataSource = reservation.gymByType(type);

            comboBox_gymno.DisplayMember = "GymId";
            comboBox_gymno.ValueMember = "GymId";

            //foglalo lista megjelintes DataGrid-ben
            dataGridView_reserv.DefaultCellStyle.ForeColor = Color.Black;
            getReservTable();

        }

        public void getReservTable()
        {
            dataGridView_reserv.DataSource = reservation.getReserv();

        }

        private void comboBox_gymtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // gym megjelenitese tipus alapjan (legyen active a status)
                int type = Convert.ToInt32(comboBox_gymtype.SelectedValue.ToString());
                comboBox_gymno.DataSource = reservation.gymByType(type);

                comboBox_gymno.DisplayMember = "GymId";
                comboBox_gymno.ValueMember = "GymId";

            }
            catch(Exception)
            {
                //Semmi
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string guestId = textBox_guestid.Text;
                string gymNo = comboBox_gymno.SelectedValue.ToString();
                DateTime dIn = dateTimePicker_datein.Value;
                DateTime dOut = dateTimePicker_dateout.Value;

                //DATUM LEKEZELESE

                if (dIn < DateTime.Today)
                {
                    MessageBox.Show("Reservation day must be today or after", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dOut < dIn)
                {
                    MessageBox.Show("Date Out can't be smaller than Date Out", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    if (reservation.addReservation(guestId, gymNo, dIn, dOut))
                    {
                        MessageBox.Show("Reservation was Successfull", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getReservTable();
                    }
                    else
                    {
                        MessageBox.Show("Reservation failed", "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int reservId = Convert.ToInt32(textBox_reserveid.Text);
            try
            {
                if (reservation.removeReserv(reservId))
                {
                    MessageBox.Show("Remove was successfull", "Remove Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getReservTable();
                }
                else
                {
                    MessageBox.Show("Can't remove", "Remove Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_reserv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_reserveid.Text = dataGridView_reserv.CurrentRow.Cells[0].Value.ToString();
            textBox_guestid.Text = dataGridView_reserv.CurrentRow.Cells[1].Value.ToString();
            
            string gNo = dataGridView_reserv.CurrentRow.Cells[2].Value.ToString();
            comboBox_gymtype.SelectedValue = reservation.typeByRoomNo(gNo);
            comboBox_gymno.Text = gNo;


            dateTimePicker_datein.Text = dataGridView_reserv.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker_dateout.Text = dataGridView_reserv.CurrentRow.Cells[4].Value.ToString();
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_guestid.Clear();
            textBox_reserveid.Clear();
            comboBox_gymtype.SelectedValue = 1;
            dateTimePicker_datein.Value = DateTime.Now;
            dateTimePicker_dateout.Value = DateTime.Now;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBox_reserveid.Text);
                string guestId = textBox_guestid.Text;
                string gymNo = comboBox_gymno.SelectedValue.ToString();
                DateTime dIn = dateTimePicker_datein.Value;
                DateTime dOut = dateTimePicker_dateout.Value;

                //DATUM LEKEZELESE

                if (dIn < DateTime.Today)
                {
                    MessageBox.Show("Reservation day must be today or after", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dOut < dIn)
                {
                    MessageBox.Show("Date Out can't be smaller than Date Out", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    if (reservation.updateReservation(reservId,guestId, gymNo, dIn, dOut))
                    {
                        MessageBox.Show("Update was Successfull", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getReservTable();
                    }
                    else
                    {
                        MessageBox.Show("Update failed", "Update Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

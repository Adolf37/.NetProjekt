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
    public partial class GuestForm : Form
    {
        GuestClass guest = new GuestClass();
        public GuestForm()
        {
            InitializeComponent();
        }

        

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_phone.Clear();
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(textBox_Id.Text == "" | textBox_lname.Text =="" | textBox_fname.Text =="" | textBox_phone.Text == "")
            {
                MessageBox.Show("ERROR-Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_Id.Text;
                    string fname = textBox_fname.Text;
                    string lname = textBox_lname.Text;
                    string phone = textBox_phone.Text;

                    Boolean insertGuest = guest.insertGuest(id, fname, lname, phone);

                    if (insertGuest)
                    {
                        MessageBox.Show("New guest saved successfully!", "Guest Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR- guest not inserted ", "Error Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            dataGridView_Guest.DefaultCellStyle.ForeColor = Color.Black;
            getTable();
            
        }

        private void getTable()
        {
            dataGridView_Guest.DataSource = guest.getGuests();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_Id.Text == "" | textBox_lname.Text == "" | textBox_fname.Text == "" | textBox_phone.Text == "")
            {
                MessageBox.Show("ERROR-Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_Id.Text;
                    string fname = textBox_fname.Text;
                    string lname = textBox_lname.Text;
                    string phone = textBox_phone.Text;

                    Boolean editGuest = guest.editGuest(id, fname, lname, phone);

                    if (editGuest)
                    {
                        MessageBox.Show("Guest update successfull!", "Guest Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR- guest not updated ", "Error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       

        private void dataGridView_Guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Id.Text = dataGridView_Guest.CurrentRow.Cells[0].Value.ToString();
            textBox_fname.Text = dataGridView_Guest.CurrentRow.Cells[1].Value.ToString();
            textBox_lname.Text = dataGridView_Guest.CurrentRow.Cells[2].Value.ToString();
            textBox_phone.Text = dataGridView_Guest.CurrentRow.Cells[3].Value.ToString();
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


                    Boolean deleteGuest = guest.removeGuest(id);

                    if (deleteGuest)
                    {
                        MessageBox.Show("Guest removed successfully!", "Guest Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR- guest not deleted ", "Error Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

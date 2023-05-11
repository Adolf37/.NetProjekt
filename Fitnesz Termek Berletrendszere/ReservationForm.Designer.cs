namespace Fitnesz_Termek_Berletrendszere
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_reserveid = new System.Windows.Forms.TextBox();
            this.textBox_guestid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView_Guest = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_gymtype = new System.Windows.Forms.ComboBox();
            this.comboBox_gymno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_datein = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateout = new System.Windows.Forms.DateTimePicker();
            this.panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Guest)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Gym No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reserve id:";
            // 
            // textBox_reserveid
            // 
            this.textBox_reserveid.Location = new System.Drawing.Point(300, 347);
            this.textBox_reserveid.Name = "textBox_reserveid";
            this.textBox_reserveid.Size = new System.Drawing.Size(125, 34);
            this.textBox_reserveid.TabIndex = 13;
            // 
            // textBox_guestid
            // 
            this.textBox_guestid.Location = new System.Drawing.Point(300, 396);
            this.textBox_guestid.Name = "textBox_guestid";
            this.textBox_guestid.Size = new System.Drawing.Size(125, 34);
            this.textBox_guestid.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gym type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Guest id:";
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.button_clean);
            this.panel_button.Controls.Add(this.button_delete);
            this.panel_button.Controls.Add(this.button_update);
            this.panel_button.Controls.Add(this.button_save);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 549);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(944, 104);
            this.panel_button.TabIndex = 22;
            // 
            // button_clean
            // 
            this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clean.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clean.ForeColor = System.Drawing.Color.Orange;
            this.button_clean.Image = ((System.Drawing.Image)(resources.GetObject("button_clean.Image")));
            this.button_clean.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_clean.Location = new System.Drawing.Point(584, 3);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(165, 85);
            this.button_clean.TabIndex = 4;
            this.button_clean.Text = "Clean";
            this.button_clean.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_clean.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_delete.ForeColor = System.Drawing.Color.Orange;
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete.Location = new System.Drawing.Point(394, 0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(171, 85);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_update.ForeColor = System.Drawing.Color.Orange;
            this.button_update.Image = ((System.Drawing.Image)(resources.GetObject("button_update.Image")));
            this.button_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_update.Location = new System.Drawing.Point(199, 3);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(189, 85);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update";
            this.button_update.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_save.ForeColor = System.Drawing.Color.Orange;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_save.Location = new System.Drawing.Point(27, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(144, 85);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Add";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Guest
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView_Guest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Guest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Guest.ColumnHeadersHeight = 29;
            this.dataGridView_Guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Guest.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Guest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Guest.Location = new System.Drawing.Point(115, 118);
            this.dataGridView_Guest.Name = "dataGridView_Guest";
            this.dataGridView_Guest.RowHeadersVisible = false;
            this.dataGridView_Guest.RowHeadersWidth = 51;
            this.dataGridView_Guest.RowTemplate.Height = 29;
            this.dataGridView_Guest.Size = new System.Drawing.Size(729, 201);
            this.dataGridView_Guest.TabIndex = 23;
            this.dataGridView_Guest.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Guest.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Guest.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Guest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Guest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Guest.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Guest.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Guest.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Guest.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Guest.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_Guest.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Guest.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Guest.ThemeStyle.HeaderStyle.Height = 29;
            this.dataGridView_Guest.ThemeStyle.ReadOnly = false;
            this.dataGridView_Guest.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Guest.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Guest.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_Guest.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Guest.ThemeStyle.RowsStyle.Height = 29;
            this.dataGridView_Guest.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Guest.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 101);
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(348, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "Manage Reservation";
            // 
            // comboBox_gymtype
            // 
            this.comboBox_gymtype.FormattingEnabled = true;
            this.comboBox_gymtype.Location = new System.Drawing.Point(591, 344);
            this.comboBox_gymtype.Name = "comboBox_gymtype";
            this.comboBox_gymtype.Size = new System.Drawing.Size(138, 35);
            this.comboBox_gymtype.TabIndex = 21;
            // 
            // comboBox_gymno
            // 
            this.comboBox_gymno.FormattingEnabled = true;
            this.comboBox_gymno.Location = new System.Drawing.Point(591, 395);
            this.comboBox_gymno.Name = "comboBox_gymno";
            this.comboBox_gymno.Size = new System.Drawing.Size(138, 35);
            this.comboBox_gymno.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date in:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 27;
            this.label7.Text = "Date out:";
            // 
            // dateTimePicker_datein
            // 
            this.dateTimePicker_datein.Location = new System.Drawing.Point(235, 455);
            this.dateTimePicker_datein.Name = "dateTimePicker_datein";
            this.dateTimePicker_datein.Size = new System.Drawing.Size(250, 34);
            this.dateTimePicker_datein.TabIndex = 28;
            // 
            // dateTimePicker_dateout
            // 
            this.dateTimePicker_dateout.Location = new System.Drawing.Point(639, 455);
            this.dateTimePicker_dateout.Name = "dateTimePicker_dateout";
            this.dateTimePicker_dateout.Size = new System.Drawing.Size(250, 34);
            this.dateTimePicker_dateout.TabIndex = 29;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(944, 653);
            this.Controls.Add(this.dateTimePicker_dateout);
            this.Controls.Add(this.dateTimePicker_datein);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_gymno);
            this.Controls.Add(this.comboBox_gymtype);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Guest);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_reserveid);
            this.Controls.Add(this.textBox_guestid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.panel_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Guest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label6;
        private Label label1;
        private TextBox textBox_reserveid;
        private TextBox textBox_guestid;
        private Label label2;
        private Label label3;
        private Panel panel_button;
        private Button button_clean;
        private Button button_delete;
        private Button button_update;
        private Button button_save;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Guest;
        private Panel panel1;
        private Label label5;
        private ComboBox comboBox_gymtype;
        private ComboBox comboBox_gymno;
        private Label label4;
        private Label label7;
        private DateTimePicker dateTimePicker_datein;
        private DateTimePicker dateTimePicker_dateout;
    }
}
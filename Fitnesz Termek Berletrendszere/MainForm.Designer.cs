namespace Fitnesz_Termek_Berletrendszere
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_client = new System.Windows.Forms.Button();
            this.button_rental_type = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.panel_slider = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_slide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_client);
            this.panel1.Controls.Add(this.button_rental_type);
            this.panel1.Controls.Add(this.button_dashboard);
            this.panel1.Controls.Add(this.panel_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 700);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 118);
            this.button1.TabIndex = 3;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_client
            // 
            this.button_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_client.ForeColor = System.Drawing.Color.Black;
            this.button_client.Image = ((System.Drawing.Image)(resources.GetObject("button_client.Image")));
            this.button_client.Location = new System.Drawing.Point(0, 343);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(138, 118);
            this.button_client.TabIndex = 2;
            this.button_client.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_client.UseVisualStyleBackColor = true;
            this.button_client.Click += new System.EventHandler(this.button_client_Click);
            // 
            // button_rental_type
            // 
            this.button_rental_type.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_rental_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rental_type.ForeColor = System.Drawing.Color.Black;
            this.button_rental_type.Image = ((System.Drawing.Image)(resources.GetObject("button_rental_type.Image")));
            this.button_rental_type.Location = new System.Drawing.Point(0, 215);
            this.button_rental_type.Name = "button_rental_type";
            this.button_rental_type.Size = new System.Drawing.Size(138, 128);
            this.button_rental_type.TabIndex = 1;
            this.button_rental_type.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_rental_type.UseVisualStyleBackColor = true;
            this.button_rental_type.Click += new System.EventHandler(this.button_rental_type_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_dashboard.ForeColor = System.Drawing.Color.Black;
            this.button_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("button_dashboard.Image")));
            this.button_dashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_dashboard.Location = new System.Drawing.Point(0, 125);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(138, 90);
            this.button_dashboard.TabIndex = 0;
            this.button_dashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_dashboard.UseVisualStyleBackColor = true;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(138, 125);
            this.panel_main.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_slide
            // 
            this.panel_slide.Controls.Add(this.panel_slider);
            this.panel_slide.Controls.Add(this.pictureBox4);
            this.panel_slide.Controls.Add(this.pictureBox3);
            this.panel_slide.Controls.Add(this.pictureBox2);
            this.panel_slide.Controls.Add(this.label_exit);
            this.panel_slide.Controls.Add(this.label1);
            this.panel_slide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_slide.Location = new System.Drawing.Point(138, 0);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(962, 700);
            this.panel_slide.TabIndex = 1;
            // 
            // panel_slider
            // 
            this.panel_slider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_slider.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_slider.Location = new System.Drawing.Point(6, 125);
            this.panel_slider.Name = "panel_slider";
            this.panel_slider.Size = new System.Drawing.Size(11, 97);
            this.panel_slider.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(157, 364);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(370, 300);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(648, 215);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(348, 436);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(591, 294);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_exit.ForeColor = System.Drawing.Color.Orange;
            this.label_exit.Location = new System.Drawing.Point(932, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 28);
            this.label_exit.TabIndex = 1;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fitness managment systeme";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panel_slide);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_slide.ResumeLayout(false);
            this.panel_slide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button_client;
        private Button button_rental_type;
        private Button button_dashboard;
        private Panel panel_main;
        private PictureBox pictureBox1;
        private Panel panel_slide;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label_exit;
        private Label label1;
        private PictureBox pictureBox4;
        private Panel panel_slider;
        private Button button1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}
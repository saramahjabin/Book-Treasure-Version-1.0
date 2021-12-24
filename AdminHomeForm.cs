using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookTreasure
{
    public partial class AdminHomeForm : Form
    {
        PictureBox p;

        public AdminHomeForm()
        {
            InitializeComponent();
            //label2.BackColor.ToArgb(155, Color.Black);
        }


        private void Informationbutton_Click_1(object sender, EventArgs e)
        {
            InformationForm f = new InformationForm();
            this.Hide();
            f.Show();
        }

        private void EmployeeAppointbutton_Click_1(object sender, EventArgs e)
        {
            EmployeeAppointForm f9 = new EmployeeAppointForm();
            this.Hide();
            f9.Show();
        }

        private void BookUploadRqstbutton_Click(object sender, EventArgs e)
        {
            BookInfoForm f = new BookInfoForm();
            f.Show();
            this.Close();
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            ProfileForm f = new ProfileForm();
            f.Show();
        }

        private void passwordChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordchangeForm f = new PasswordchangeForm();
            f.Show();
        }

        private void ogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are logging out.", "Book Treasure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton1.Checked = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }
    }
}

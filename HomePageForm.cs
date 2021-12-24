using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookTreasure.Repositories;
using System.Data.SqlClient;
using System.IO;

namespace BookTreasure
{
    public partial class HomePageForm : Form
    {

        DatabaseAccess con;
        string sql, name;
        int ID;
        SqlDataReader reader;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Irin\source\repos\BookTreasure\DB\BTUserInfo.mdf;Integrated Security=True;Connect Timeout=30");
        public HomePageForm()
        {
            InitializeComponent();
        }


        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            BookdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataSet ds = new DataSet();
            DataView dv = new DataView();
            sql = "SELECT Id, Book_Name, Writer_Name  from BookInfo where Book_Name like '%" + SearchTextBox.Text + "%';";
            con = new DatabaseAccess();
            con.GetData(sql).Fill(ds);
            dv = new DataView(ds.Tables[0]);
            BookdataGridView.DataSource = dv;
            con.Dispose();
        }

        public void downloadFile(string file)
        {
            conn.Open();
            bool em = false;
            using (cmd = new SqlCommand("select Src_File from BookInfo where Id ='" + ID + "'",conn)){
                using(reader = cmd.ExecuteReader(CommandBehavior.Default))
                {
                    if (reader.Read())
                    {
                        em = true;
                        byte[] filedata = (byte[])reader.GetValue(0);
                        using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.ReadWrite))
                        {
                            using(BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(filedata);
                                bw.Close();
                            }
                            MessageBox.Show("finished downloaded files", "Book Treasure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (em == false)
                            {
                                MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            reader.Close();
                        }
                    }
                }
            }
            conn.Close();
        }

        private void Downloadbutton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF Documents (*.pdf) |*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to download this file?", "Book Treasure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialog == DialogResult.Yes)
                    {
                        string filename = sfd.FileName;
                        downloadFile(filename);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            ProfileForm f4 = new ProfileForm();
            f4.Show();
        }

        private void DonateButton_Click_1(object sender, EventArgs e)
        {
            DonateForm f6 = new DonateForm();
            f6.Show();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            BookdataGridView.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            label1.Hide();
            label9.Hide();
            label10.Hide();
            label2.Hide();
            toolStrip1.Show();
            Downloadbutton.Show();
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
            this.Close();
        }

        private void AboutUsbutton_Click(object sender, EventArgs e)
        {
            AboutUsForm f = new AboutUsForm();
            f.Show();
            this.Hide();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            toolStrip1.Hide();
            Downloadbutton.Hide();
            BookdataGridView.Hide();
            con = new DatabaseAccess();
            sql = "Select Name from CommonUserInfo where Email = '" + LoginForm.email + "'";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            name = dtbl.Rows[0][0].ToString();
            label1.Text = "Hello " + name + ", Welcome Back !!";
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            toolStrip1.Hide();
            Downloadbutton.Hide();
            BookdataGridView.Hide();
            label1.Show();
            label9.Show();
            label10.Show();
            label2.Show();
        }

        private void BookdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(BookdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}

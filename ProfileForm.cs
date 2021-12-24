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
using System.IO;
using System.Data.SqlClient;


namespace BookTreasure
{
    public partial class ProfileForm : Form
    {

        DatabaseAccess con;
        string sql;
        //SqlDataAdapter da;
        public ProfileForm()
        {
            InitializeComponent();
            this.con = new DatabaseAccess();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfileEditForm f5 = new ProfileEditForm();
            this.Hide();
            f5.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
           
                con = new DatabaseAccess();
                sql = "Select ID from LoginInfo WHERE Email = '" + LoginForm.email + "';";
                DataTable dtbl = new DataTable();
                con.GetData(sql).Fill(dtbl);
                string ID = dtbl.Rows[0][0].ToString();
                string DESIGNATION = ID.Substring(0, 2);
            try
            {
                if (DESIGNATION == "CU")
                {
                    sql = "Select * from CommonUserInfo WHERE Email = '" + LoginForm.email + "';";
                    SqlDataReader reader = con.GetReaderData(sql);
                    reader.Read();
                    NametextBox.Text = reader["Name"].ToString();
                    EmailtextBox.Text = reader["Email"].ToString();
                    DOBtextBox.Text = reader["DOB"].ToString();
                    CountrytextBox.Text = reader["COUNTRY_NAME"].ToString();
                   /* byte[] img = (byte[])reader["Image"];
                    //string s = reader[7].ToString();
                   // Bitmap b = new Bitmap(reader[6].ToString());
                    pictureBox1.Image = null;
                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        //this.pictureBox1.Image = b;
                         MemoryStream ms = new MemoryStream(img);
                        // pictureBox1.Image = Image.FromStream(ms);
                        Bitmap b = new Bitmap(Image.FromStream(ms));
                        this.pictureBox1.Image = b;
                    }*/

                    reader.Close();
                }
                else if (DESIGNATION == "EM")
                {
                    sql = "Select * from EmployeeInfo WHERE Email = '" + LoginForm.email + "';";
                    SqlDataReader reader = con.GetReaderData(sql);
                    reader.Read();
                    NametextBox.Text = reader["Name"].ToString();
                    EmailtextBox.Text = reader["EMAIL"].ToString();
                    DOBtextBox.Text = reader["DOB"].ToString();
                    CountrytextBox.Text = reader["COUNTRY_NAME"].ToString();
                    /*byte[] img = (byte[])reader[6];
                    if (img == null)
                    {
                        ProfilepictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        ProfilepictureBox.Image = Image.FromStream(ms);
                    }
                    reader.Close();*/
                }
                else if (DESIGNATION == "AD")
                {
                    sql = "Select * from AdminInfo WHERE Email = '" + LoginForm.email + "';";
                    SqlDataReader reader = con.GetReaderData(sql);
                    reader.Read();
                    NametextBox.Text = reader["Name"].ToString();
                    EmailtextBox.Text = reader["Email"].ToString();
                    DOBtextBox.Text = reader["DOB"].ToString();
                    CountrytextBox.Text = reader["COUNTRY_NAME"].ToString();
                   /* byte[] img = (byte[])reader[6];
                    ProfilepictureBox.Image = null;
                    if (img == null)
                    {
                        ProfilepictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        ProfilepictureBox.Image = Image.FromStream(ms);
                    }*/
                    reader.Close();
                    con.Dispose();
                }


            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }

        }

    }
}

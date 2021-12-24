using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using BookTreasure.Repositories;


namespace BookTreasure
{
    public partial class ProfileEditForm : Form
    {
        DatabaseAccess con;
        string sql;
        string imagelocation = "";
        public ProfileEditForm()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
             OpenFileDialog dialog = new OpenFileDialog();
             dialog.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
             if(dialog.ShowDialog()== DialogResult.OK)
             {
                 imagelocation = dialog.FileName.ToString();
                 UserpictureBox.ImageLocation = imagelocation;
             }
        }

        private void ConformButton_Click(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
             byte[] images = null;
             FileStream Stream = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
             BinaryReader brs = new BinaryReader(Stream);
             images = brs.ReadBytes((int)Stream.Length);
            sql = "Select ID from LoginInfo WHERE Email = '" + LoginForm.email + "';";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            string ID = dtbl.Rows[0][0].ToString();
            string DESIGNATION = ID.Substring(0, 2);
            if (DESIGNATION == "CU")
            {
                sql = "UPDATE CommonUserInfo SET  Name = '" + NametextBox.Text + "', Email = '" + EmailtextBox.Text + "', DOB = '" + DOBdateTimePicker.Text + "',Image = '" + images + "', COUNTRY_NAME = '" + CountrytextBox.Text + "'  WHERE Email = '" + LoginForm.email + "'; ";
                con.ExecuteQuery(sql);
                MessageBox.Show("Information Updated");
            }
            else if (DESIGNATION == "EM")
            {
                sql = "UPDATE EmployeeInfo SET  Name = '" + NametextBox.Text + "', EMAIL = '" + EmailtextBox.Text + "', DOB = '" + DOBdateTimePicker.Text + "',Image = '" + images + "', COUNTRY_NAME = '" + CountrytextBox.Text + "'  WHERE EMAIL = '" + LoginForm.email + "'; ";
                con.ExecuteQuery(sql);
                MessageBox.Show("Information Updated");
            }
            else if (DESIGNATION == "AD")
            {
                sql = "UPDATE AdminInfo SET  Name = '" + NametextBox.Text + "', Email = '" + EmailtextBox.Text + "', DOB = '" + DOBdateTimePicker.Text + "',Image = '" + images + "', COUNTRY_NAME = '" + CountrytextBox.Text + "'  WHERE Email = '" + LoginForm.email + "'; ";
                con.ExecuteQuery(sql);
                MessageBox.Show("Information Updated");
            } 
             con.Dispose();
        }

        private void ProfileEditForm_Load(object sender, EventArgs e)
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
                    DOBdateTimePicker.Text = reader["DOB"].ToString();
                    CountrytextBox.Text = reader["COUNTRY_NAME"].ToString();
                    /*byte[] img = (byte[])reader[6];
                    if (img == null)
                    {
                        UserpictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        UserpictureBox.Image = Image.FromStream(ms);
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
                    DOBdateTimePicker.Text = reader["DOB"].ToString();
                    CountrytextBox.Text = reader["COUNTRY_NAME"].ToString();
                    /*byte[] img = (byte[])reader[6];
                    if (img == null)
                    {
                        UserpictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        UserpictureBox.Image = Image.FromStream(ms);
                    }*/
                    reader.Close();
                }
                else if (DESIGNATION == "AD")
                {
                    sql = "Select * from AdminInfo WHERE Email = '" + LoginForm.email + "';";
                    SqlDataReader reader = con.GetReaderData(sql);
                    reader.Read();
                    NametextBox.Text = reader["Name"].ToString();
                    EmailtextBox.Text = reader["Email"].ToString();
                    DOBdateTimePicker.Text = reader["DOB"].ToString();
                    CountrytextBox.Text = reader["COUNTRY_NAME"].ToString();
                    /*byte[] img = (byte[])reader[6];
                    if (img == null)
                    {
                        UserpictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        UserpictureBox.Image = Image.FromStream(ms);
                    }*/
                    reader.Close();
                    con.Dispose();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            ProfileForm f4 = new ProfileForm();
            this.Hide();
            f4.Show();
        }
    }
}

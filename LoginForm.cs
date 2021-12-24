using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using BookTreasure.Repositories;

namespace BookTreasure
{
    public partial class LoginForm : Form

    {
        public static string email, pass;
        DatabaseAccess con;
        string sql;
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public LoginForm()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
                sql = "select ID from LoginInfo where Email ='" + textEmail.Text.Trim() + "' and Password='" + HashClass.Hash(textPassword.Text.Trim()) + "'";
                DataTable dtbl = new DataTable();
                con.GetData(sql).Fill(dtbl);
                email = textEmail.Text.Trim();
                pass = textPassword.Text.Trim();
                textEmail.Text = "";
                textPassword.Text = "";



                if (dtbl.Rows.Count == 1)
            {
 
                    sql = "select * from LoginInfo where Email ='" + email + "' and Block_Status = 0 ";
                    DataTable dt = new DataTable();
                    con.GetData(sql).Fill(dt);
                if (dt.Rows.Count==1)
                {

                    try
                    {
                        string ID = dtbl.Rows[0][0].ToString();
                        string DESIGNATION = ID.Substring(0, 2);
                        if (DESIGNATION == "CU")
                        {
                            HomePageForm f = new HomePageForm();
                            f.Show();
                            this.Hide();

                        }
                        else if (DESIGNATION == "EM")
                        {
                            EmployeeHomeForm f = new EmployeeHomeForm();
                            f.Show();
                            this.Hide();


                        }
                        else if (DESIGNATION == "AD")
                        {
                            AdminHomeForm f = new AdminHomeForm();
                            this.Hide();
                            f.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Your account has been blocked. If you have any query contact to our customer service. Customer Service No.- 02748765 .");
                    textEmail.Text = "";
                    textPassword.Text = "";
                }
            }

                else
                {
                    MessageBox.Show("Invalid Email or Password!");
                }

            con.Dispose();
        }

        private void ForgotPassinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassForm f = new ForgotPassForm();
            this.Close();
            f.Show();
        }


        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textEmail.Text, pattern) == false)
            {
                textEmail.Focus();
                errorProvider1.SetError(this.textEmail, "Invalid Email");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(textEmail.Text) == true)
            {
                textEmail.Focus();
                errorProvider2.SetError(this.textEmail, "Email can not be empty!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void Hidebutton_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '\0')
            {
                Showbutton.BringToFront();
                textPassword.PasswordChar = '*';
            }
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '*')
            {
                Hidebutton.BringToFront();
                textPassword.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpForm f7 = new SignUpForm();
            this.Hide();
            f7.Show();
        }

    }
}

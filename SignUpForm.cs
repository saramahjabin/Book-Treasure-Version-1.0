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
using BookTreasure.Repositories;
using System.Text.RegularExpressions;

namespace BookTreasure
{
    public partial class SignUpForm : Form
    {
        DatabaseAccess con;
        string sql;
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void ConformButton_Click(object sender, EventArgs e)
        {
            if (PasswordtextBox.Text == CPasswordtextBox.Text)
            {

                if (DesignationcomboBox.Text == "Common User")
                {
                    if (string.IsNullOrEmpty(NametextBox.Text) == true || string.IsNullOrEmpty(textEmail.Text) == true || string.IsNullOrEmpty(DesignationcomboBox.Text) == true || string.IsNullOrEmpty(PasswordtextBox.Text) == true || string.IsNullOrEmpty(CPasswordtextBox.Text) == true)
                    {
                        MessageBox.Show("Please fill up the informations.");
                    }
                    else
                    {
                        con = new DatabaseAccess();
                        sql = "INSERT INTO CommonUserInfo (Name, Email) VALUES ('" + NametextBox.Text.Trim() + "','" + textEmail.Text.Trim() + "')";
                        con.ExecuteQuery(sql);
                        sql = "INSERT INTO LoginInfo (ID, Email, Password) values((Select USERID from CommonUserInfo where Email = '" + textEmail.Text.Trim() + "'),'" + textEmail.Text.Trim() + "', '" + HashClass.Hash(PasswordtextBox.Text.Trim()) + "')";
                        con.ExecuteQuery(sql);
                        con.Dispose();
                        MessageBox.Show("Account Created");
                    }
                }
                else if (DesignationcomboBox.Text == "Employee")
                {
                    if (string.IsNullOrEmpty(NametextBox.Text) == true || string.IsNullOrEmpty(textEmail.Text) == true || string.IsNullOrEmpty(DesignationcomboBox.Text) == true || string.IsNullOrEmpty(PasswordtextBox.Text) == true || string.IsNullOrEmpty(PinCodetextBox.Text) == true)
                    {
                        MessageBox.Show("Please fill up the informations.");
                    }
                    else
                    {
                        con = new DatabaseAccess();
                        sql = "INSERT INTO Employee_Request VALUES ('" + NametextBox.Text.Trim() + "','" + textEmail.Text.Trim() + "','" + PasswordtextBox.Text.Trim() + "','" + PinCodetextBox.Text.Trim() + "')";
                        con.ExecuteQuery(sql);
                        con.Dispose();
                        MessageBox.Show("Account Createation request has been forwarded to the administration.You will be noified through email.");
                        con.Dispose();
                    }
                }
                LoginForm f = new LoginForm();
                f.Show();
                this.Close();
            }
            else
            {
                PassErrorLabel.Text = "You must enter the same password twice to conform.";
                PasswordtextBox.Text = "";
                CPasswordtextBox.Text = "";
            }
           
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            label6.Hide();
            PinCodetextBox.Hide();
            label12.Hide();
        }

        private void DesignationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DesignationcomboBox.SelectedItem =="Employee")
            {
                label6.Show();
                PinCodetextBox.Show();
                label12.Show();
            }
            else
            {
                label6.Hide();
                PinCodetextBox.Hide();
                label12.Hide();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
            sql = "Select * from loginInfo where Email = '" + textEmail.Text.Trim() + "'";
            DataTable dt = new DataTable();
            con.GetData(sql).Fill(dt);
            con.Dispose();
            if (dt.Rows.Count>0)
            {
                textEmail.Focus();
                errorProvider3.SetError(this.textEmail, "An account already exist with this email.Enter an unique email.");
            }
            else
            {
                errorProvider3.Clear();
            }
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
    }
}

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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace BookTreasure
{
    public partial class ForgotPassForm : Form
    {
        DatabaseAccess con;
        int count=0;
        string sql,email;
        EmailSend se = new EmailSend();
        public ForgotPassForm()
        {
            InitializeComponent();
        }


        private void ForgotPassForm_Load(object sender, EventArgs e)
        {
            checkBox1.Hide();
            label2.Hide();
            CodetextBox.Hide();
            label4.Hide();
            CodeErrortextBox.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            NewPasstextBox.Hide();
            Showbutton.Hide();
            ShowbuttonC.Hide();
            Hidebutton.Hide();
            HidebuttonC.Hide();
            Continuebutton.Hide();
            Confrombutton.Hide();
        }

        private void Continuebutton_Click(object sender, EventArgs e)
        {
            if (CodetextBox.Text == se.pin.ToString()) 
            {
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                NewPasstextBox.Show();
                Confrombutton.Show();
                Showbutton.Show();
                ShowbuttonC.Show();
                Hidebutton.Show();
                HidebuttonC.Show();
                label2.Hide();
                Continuebutton.Hide();
                checkBox1.Hide();
            }
            else
            {
                CodeErrortextBox.Text = "Code doesn't match.";
                if (checkBox1.Checked)
                {
                    CodetextBox.Text = "";
                    CodeErrortextBox.Text = "";
                    se.GetSendEmail(Operator.codesend).Invoke(email);
                    checkBox1.Checked = false;
                    count++;

                    if (count >= 3)
                    {
                        con = new DatabaseAccess();
                        sql = "Update LoginInfo set Block_Status = 1 where Email = '" + email + "'";
                        con.ExecuteQuery(sql);
                        con.Dispose();
                        MessageBox.Show("Your account has been blocked. If you have any query contact to our customer service. Customer Service No.- 02748765 .");
                        Application.Exit();
                    }

                }    
                
            }
        }

        private void Confrombutton_Click(object sender, EventArgs e)
        {
            if (NewPasstextBox.Text == ConformPasstextBox.Text)
            {
                con = new DatabaseAccess();
                sql = "Update LoginInfo set Password = '"+ HashClass.Hash(NewPasstextBox.Text.Trim()) + "' where Email = '" + email + "'";
                con.ExecuteQuery(sql);
                con.Dispose();
                MessageBox.Show("You password is updated. Now log in with this new passowrd.");
                LoginForm f = new LoginForm();
                f.Show();
                this.Close();
            }
            else
            {
                NewPasstextBox.Text = "";
                ConformPasstextBox.Text = "";
                MessageBox.Show("You have to enter the same passowrd twice to conform. Try again!");

            }
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            if (NewPasstextBox.PasswordChar == '*')
            {
                Hidebutton.BringToFront();
                NewPasstextBox.PasswordChar = '\0';
            }
        }

        private void Hidebutton_Click(object sender, EventArgs e)
        {
            if (NewPasstextBox.PasswordChar == '\0')
            {
                Showbutton.BringToFront();
                NewPasstextBox.PasswordChar = '*';
            }
        }

        private void ShowbuttonC_Click(object sender, EventArgs e)
        {
            if (ConformPasstextBox.PasswordChar == '*')
            {
                Hidebutton.BringToFront();
                ConformPasstextBox.PasswordChar = '\0';
            }
        }

        private void HidebuttonC_Click(object sender, EventArgs e)
        {
            if (ConformPasstextBox.PasswordChar == '\0')
            {
                Showbutton.BringToFront();
                ConformPasstextBox.PasswordChar = '*';
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        private void EmailtexBox_MouseClick(object sender, MouseEventArgs e)
        {
            EmailErrortextBox.Text = "";
        }

        private void SendEmailbutton_Click(object sender, EventArgs e)
        {
            email = EmailtexBox.Text.Trim();
                con = new DatabaseAccess();
                sql = "select ID from LoginInfo where Email = '" + email + "'";
                DataTable dtbl = new DataTable();
                con.GetData(sql).Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                se.GetSendEmail(Operator.codesend).Invoke(email);
                label2.Show();
                label4.Show();
                CodetextBox.Show();
                CodeErrortextBox.Show();
                Continuebutton.Show();
                con.Dispose();
                SendEmailbutton.Hide();
                checkBox1.Show();
            }
                else
                {
                    EmailErrortextBox.Text = "No account match that information. Please enter a valid email.";
                }
            EmailtexBox.Text = "";
            
        }
    }
}

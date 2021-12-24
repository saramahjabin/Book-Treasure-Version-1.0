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

namespace BookTreasure
{
    public partial class PasswordchangeForm : Form
    {
        DatabaseAccess con;
        string sql;
        public PasswordchangeForm()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (CurrentPasstextBox.Text == LoginForm.pass)
            {
                if (NewPasstextBox.Text == ConformNewPasstextBox.Text)
                {
                    con = new DatabaseAccess();
                    sql = "Update LoginInfo set Password = '" + HashClass.Hash(NewPasstextBox.Text.Trim() )+ "' where Email = '" + LoginForm.email + "'";
                    con.ExecuteQuery(sql);
                    DialogResult dialog = MessageBox.Show("Password Changed", "Book Treasure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        this.Close();
                    }
                    con.Dispose();
                }
                else
                {
                    ErrortextBox.Text = "You must enter the same password twice to conform.";
                    NewPasstextBox.Text = "";
                    ConformNewPasstextBox.Text = "";
                }
            }
            else
            {
                PassErrorBox.Text = "You must enter a valid password. Try again!";
                CurrentPasstextBox.Text = "";
            }
        }

        private void CurrentPasstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PassErrorBox.Text = " ";
        }
    }
}

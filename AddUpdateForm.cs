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
    public partial class AddUpdateForm : Form
    {
        DatabaseAccess con;
        string sql;
        public AddUpdateForm()
        {
            InitializeComponent();
        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {
            if (InformationForm.instance.Bstatus == "Add")
            {
                if (InformationForm.instance.Istatus == "LoginInfo")
                {
                    label1.Hide();
                    NametextBox.Hide();
                    label3.Hide();
                    DOBdatePicker.Hide();
                    label4.Hide();
                    CountryNametextBox.Hide();
                    Updatebutton.Hide();
                }
                else
                {
                    label6.Hide();
                    IDtextBox.Hide();
                    PasswordtextBox.Hide();
                    label5.Hide();
                    Updatebutton.Hide();
                }
            }

            else
            {
                if (InformationForm.instance.Istatus == "LoginInfo")
                {
                    label1.Hide();
                    NametextBox.Hide();
                    label3.Hide();
                    DOBdatePicker.Hide();
                    label4.Hide();
                    CountryNametextBox.Hide();
                    IDtextBox.Text = InformationForm.instance.ID;
                    EmailtextBox.Text = InformationForm.instance.Email;
                    PasswordtextBox.Text = InformationForm.instance.Pass;
                    Insertbutton.Hide();
                }
                else
                {
                    label6.Hide();
                    IDtextBox.Hide();
                    PasswordtextBox.Hide();
                    label5.Hide();
                    NametextBox.Text = InformationForm.instance.name;
                    EmailtextBox.Text = InformationForm.instance.Email;
                    DOBdatePicker.Text = InformationForm.instance.DOB;
                    CountryNametextBox.Text = InformationForm.instance.CountryName;
                    Insertbutton.Hide();
                }
            }
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
            if (InformationForm.instance.Istatus == "Employee")
            {
                sql = "INSERT INTO EmployeeInfo (Name, EMAIL,DOB,COUNTRY_NAME,Appointed_AdminID) VALUES ('" + NametextBox.Text.Trim() + "','" + EmailtextBox.Text.Trim() + "','" + DOBdatePicker.Text + "','" + CountryNametextBox.Text.Trim() + "',( select AdminID from AdminInfo where Email = '" + LoginForm.email + "'))";
                con.ExecuteQuery(sql);
                DialogResult dialog = MessageBox.Show("Information Added. Now you need to add password if you want to validate the account.","Book Treasure",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else if(InformationForm.instance.Istatus == "LoginInfo")
            {
                sql = "INSERT INTO LoginInfo (ID, Email, Password) VALUES ('"+IDtextBox.Text+"','" + EmailtextBox.Text.Trim() + "','" + HashClass.Hash(PasswordtextBox.Text.Trim()) + "')";
                con.ExecuteQuery(sql);
                DialogResult dialog = MessageBox.Show("Information Added.", "Book Treasure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                sql = "INSERT INTO CommonUserInfo (Name, Email,DOB,COUNTRY_NAME) VALUES ('" + NametextBox.Text.Trim() + "','" + EmailtextBox.Text.Trim() + "','" + DOBdatePicker.Text + "','" + CountryNametextBox.Text.Trim() + "')";
                con.ExecuteQuery(sql);
                DialogResult dialog = MessageBox.Show("Information Added. Now you need to add password if you want to validate the account.", "Book Treasure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
            }
            
            con.Dispose();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
            if (InformationForm.instance.Istatus == "Employee")
            {
                sql = "Update EmployeeInfo set Name ='" + NametextBox.Text.Trim() + "', EMAIL= '" + EmailtextBox.Text.Trim() + "', DOB = '" + DOBdatePicker.Text + "', COUNTRY_NAME = '" + CountryNametextBox.Text.Trim() + "'  where EmployeeID = '" + InformationForm.instance.ID+ "'";
                con.ExecuteQuery(sql);
            }
            else if(InformationForm.instance.Istatus == "LoginInfo")
            {
                sql = "Update LoginInfo set Email = '" + EmailtextBox.Text.Trim() + "', Password = '" + HashClass.Hash(PasswordtextBox.Text.Trim()) + "' where Email = '" + InformationForm.instance.Email + "'";
                con.ExecuteQuery(sql);
            }
            else
            {
                sql = "Update CommonUserInfo set Name ='" + NametextBox.Text.Trim() + "', Email = '" + EmailtextBox.Text.Trim() + "', DOB = '" + DOBdatePicker.Text + "', COUNTRY_NAME = '" + CountryNametextBox.Text.Trim() + "'  where USERID = '" + InformationForm.instance.ID + "'";
                con.ExecuteQuery(sql);
            }
            DialogResult dialog = MessageBox.Show("Information Updated", "Book Treasure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                this.Close();
            }
            con.Dispose();
        }
    }
}

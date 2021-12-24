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
    public partial class EmployeeHomeForm : Form
    {
        DatabaseAccess con;
        string sql, name, Istatus;
        public EmployeeHomeForm()
        {
            InitializeComponent();
        }

        private void BookUploadRqstbutton_Click(object sender, EventArgs e)
        {
            EmBookUpRqstDetailsForm f = new EmBookUpRqstDetailsForm();
            f.Show();
            this.Hide();
        }

        private void Informationbutton_Click(object sender, EventArgs e)
        {
            toolStrip2.Show();
            label1.Hide();
            label2.Hide();
            label9.Hide();
            label10.Hide();
        }

        private void LoginInfoButton_Click(object sender, EventArgs e)
        {
            Istatus = "LoginInfo";
            con = new DatabaseAccess();
            sql = "SELECT * from LoginInfo ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            UserdataGridView.DataSource = dtbl;
            con.Dispose();
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Istatus == "LoginInfo")
            {
                UserdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                sql = "SELECT *  from LoginInfo where Email like '%" + SearchTextBox.Text + "%';";
                con = new DatabaseAccess();
                con.GetData(sql).Fill(ds);
                dv = new DataView(ds.Tables[0]);
                UserdataGridView.DataSource = dv;
                con.Dispose();

            }
            else
            {
                UserdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                sql = "SELECT USERID, Name, Email, DOB, COUNTRY_NAME  from CommonUserInfo where Name like '%" + SearchTextBox.Text + "%';";
                con = new DatabaseAccess();
                con.GetData(sql).Fill(ds);
                dv = new DataView(ds.Tables[0]);
                UserdataGridView.DataSource = dv;
                con.Dispose();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (Istatus == "LoginInfo")
            {
                UserdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                sql = "SELECT *  from LoginInfo where Email like '%" + SearchTextBox.Text + "%';";
                con = new DatabaseAccess();
                con.GetData(sql).Fill(ds);
                dv = new DataView(ds.Tables[0]);
                UserdataGridView.DataSource = dv;
                con.Dispose();

            }
            else
            {
                UserdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                sql = "SELECT USERID, Name, Email, DOB, COUNTRY_NAME  from CommonUserInfo where Name like '%" + SearchTextBox.Text + "%';";
                con = new DatabaseAccess();
                con.GetData(sql).Fill(ds);
                dv = new DataView(ds.Tables[0]);
                UserdataGridView.DataSource = dv;
                con.Dispose();
            }
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

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            ProfileForm f = new ProfileForm();
            f.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            toolStrip2.Hide();
            label1.Show();
            label2.Show();
            label9.Show();
            label10.Show();
        }

        private void BookInfoButton_Click(object sender, EventArgs e)
        {
            EmBookInfo f = new EmBookInfo();
            f.Show();
            this.Close();
        }

        private void UsertoolStripButton_Click(object sender, EventArgs e)
        {
            Istatus = "Common User";
            con = new DatabaseAccess();
            sql = "SELECT USERID, Name, Email, DOB, COUNTRY_NAME  from CommonUserInfo ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            UserdataGridView.DataSource = dtbl;
            con.Dispose();
        }

        private void EmployeeHomeForm_Load(object sender, EventArgs e)
        {
            toolStrip2.Hide();
            con = new DatabaseAccess();
            sql = "Select Name from EmployeeInfo where EMAIL = '" + LoginForm.email + "'";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            name = dtbl.Rows[0][0].ToString();
            label1.Text = "Hello " + name + ". Have a look on your works.";
        }
    }
}

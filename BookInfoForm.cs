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
    public partial class BookInfoForm : Form
    {
        DatabaseAccess con;
        string sql, status;
        int ID;
        public BookInfoForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminHomeForm f = new AdminHomeForm();
            f.Show();
            this.Close();
        }

        private void BookRqstDropDownButton_Click(object sender, EventArgs e)
        {
            status = "Book Request";
            con = new DatabaseAccess();
            sql = "SELECT DonationReqest_ID, Donor_ID, Book_Name, Writer_Name, Status, Approved_EmployeeID  from Book_Donation_RequestInfo ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            BookdataGridView.DataSource = dtbl;
            con.Dispose();
        }

        private void ApproveRqstMenuItem_Click(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
            sql = "SELECT DonationReqest_ID, Donor_ID, Book_Name, Writer_Name, Status, Approved_EmployeeID  from Book_Donation_RequestInfo where Status = 1 ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            BookdataGridView.DataSource = dtbl;
            con.Dispose();
        }

        private void NonApprovedRqstMenuItem_Click(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
            sql = "SELECT DonationReqest_ID, Donor_ID, Book_Name, Writer_Name, Status, Approved_EmployeeID  from Book_Donation_RequestInfo where Status = 0 ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            BookdataGridView.DataSource = dtbl;
            con.Dispose();
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (status == "Books")
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
            else
            {
                BookdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                sql = "SELECT DonationReqest_ID, Donor_ID, Book_Name, Writer_Name, Status, Approved_EmployeeID  from Book_Donation_RequestInfo where DonationReqest_ID like '%" + SearchTextBox.Text + "%';";
                con = new DatabaseAccess();
                con.GetData(sql).Fill(ds);
                dv = new DataView(ds.Tables[0]);
                BookdataGridView.DataSource = dv;
                con.Dispose();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (status == "Books")
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
            else
            {
                BookdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                sql = "SELECT DonationReqest_ID, Donor_ID, Book_Name, Writer_Name, Status, Approved_EmployeeID  from Book_Donation_RequestInfo where DonationReqest_ID like '%" + SearchTextBox.Text + "%';";
                con = new DatabaseAccess();
                con.GetData(sql).Fill(ds);
                dv = new DataView(ds.Tables[0]);
                BookdataGridView.DataSource = dv;
                con.Dispose();
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            DonateForm f = new DonateForm();
            f.Show();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
            sql = "Delete from BookInfo where Id = '" + ID + "'";
            con.ExecuteQuery(sql);
            MessageBox.Show("information deleted.");
            con.Dispose();
        }

        private void BookdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status == "Books")
            {
                ID = Convert.ToInt32(BookdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void BookInfoButton_Click(object sender, EventArgs e)
        {
            status = "Books";
            con = new DatabaseAccess();
            sql = "SELECT Id, Book_Name, Writer_Name  from BookInfo ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            BookdataGridView.DataSource = dtbl;
            con.Dispose();
        }
    }
}

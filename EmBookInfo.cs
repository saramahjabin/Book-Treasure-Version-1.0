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
    public partial class EmBookInfo : Form
    {
        DatabaseAccess con;
        string sql;
        int ID;
        public EmBookInfo()
        {
            InitializeComponent();
        }

        private void EmBookInfo_Load(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
            sql = "SELECT Id, Book_Name, Writer_Name  from BookInfo ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            BookdataGridView.DataSource = dtbl;
            con.Dispose();
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

        private void SearchButton_Click(object sender, EventArgs e)
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
            ID = Convert.ToInt32(BookdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EmployeeHomeForm f = new EmployeeHomeForm();
            f.Show();
            this.Close();
        }
    }
}

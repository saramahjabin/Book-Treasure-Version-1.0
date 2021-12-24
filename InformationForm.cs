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



namespace BookTreasure
{
    public partial class InformationForm : Form
    {
        public static InformationForm instance;
        DatabaseAccess con;
        string sql;
        public string Bstatus, Istatus,name, Email,DOB, CountryName,ID,Pass;

        public InformationForm()
        {
            InitializeComponent();
            instance = this;
            

        }

        private void UsertoolStripButton_Click(object sender, EventArgs e)//done
        {
            Istatus = "Common User";
            con = new DatabaseAccess();
            sql = "SELECT USERID, Name, Email, DOB, COUNTRY_NAME  from CommonUserInfo ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            UserdataGridView.DataSource = dtbl;
            con.Dispose();
        }

        private void EmployeetoolStripButton_Click(object sender, EventArgs e)//done
        {
            Istatus = "Employee";
            con = new DatabaseAccess();
            sql = "SELECT EmployeeID, Name, EMAIL, DOB, COUNTRY_NAME, Hire_Date, Appointed_AdminID  from EmployeeInfo ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            UserdataGridView.DataSource = dtbl;
            con.Dispose();
        }


        private void SearchButton_Click(object sender, EventArgs e)//done
        {
            if (Istatus == "Employee")
            {
                UserdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                sql = "SELECT EmployeeID, Name, EMAIL, DOB, COUNTRY_NAME,Hire_Date, Appointed_AdminID  from EmployeeInfo where Name like '%" + SearchTextBox.Text + "%';";
                con = new DatabaseAccess();
                con.GetData(sql).Fill(ds);
                dv = new DataView(ds.Tables[0]);
                UserdataGridView.DataSource = dv;
                con.Dispose();

            }
            else if (Istatus == "LoginInfo")
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

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)//done
        {
            if (Istatus == "Employee")
            {
                UserdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                sql = "SELECT EmployeeID, Name, EMAIL, DOB, COUNTRY_NAME, Hire_Date, Appointed_AdminID  from EmployeeInfo where Name like '%" + SearchTextBox.Text + "%';";
                con = new DatabaseAccess();
                con.GetData(sql).Fill(ds);
                dv = new DataView(ds.Tables[0]);
                UserdataGridView.DataSource = dv;
                con.Dispose();
                
            }
            else if (Istatus == "LoginInfo")
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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Bstatus = "Add";
            AddUpdateForm f = new AddUpdateForm();
            f.Show();

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

        private void UserdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Istatus == "LoginInfo")
            {
                ID = ID = UserdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Email = UserdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Pass = UserdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else
            {
                // ID = Convert.ToInt32(UserdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                ID = UserdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                name = UserdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Email = UserdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                DOB = UserdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                CountryName = UserdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete this record?", "Book Treasure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                con = new DatabaseAccess();
                if (Istatus == "Employee")
                {
                    sql = "Delete from EmployeeInfo where EmployeeID = '" + ID + "'";
                    con.ExecuteQuery(sql);
                }
                else if(Istatus == "LoginInfo"){
                    sql = "Delete from LoginInfo where Email = '" + Email + "'";
                    con.ExecuteQuery(sql);
                }
                else
                {
                    sql = "Delete from CommonUserInfo where USERID = '" + ID + "'";
                    con.ExecuteQuery(sql);
                }
                MessageBox.Show("Information Deleted");
                con.Dispose();
            }
        }

        private void InformationForm_Load(object sender, EventArgs e) 
        {
            con = new DatabaseAccess();
            sql = "SELECT USERID, Name, Email, DOB, COUNTRY_NAME  from CommonUserInfo ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            UserdataGridView.DataSource = dtbl;
            con.Dispose();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Bstatus = "Update";
            AddUpdateForm f = new AddUpdateForm();
            f.Show();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            AdminHomeForm f = new AdminHomeForm();
            f.Show();
            this.Close();
        }

    }
}

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

namespace BookTreasure
{
    public partial class EmployeeAppointForm : Form
    {
        DatabaseAccess con;
        string sql, email,Password;
        public static string name;
        int ID, rqst;
        EmailSend se = new EmailSend();
        public EmployeeAppointForm()
        {
            InitializeComponent();
        }

        private void EmployeeAppointForm_Load(object sender, EventArgs e)
        {
            EmployeeRqstGridView.Hide();
            Approvebutton.Hide();
            Declinebutton.Hide();
            c.Hide();
            con = new DatabaseAccess();
            sql = "select Id, Name, Email, PinCode from Employee_Request";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            rqst = dtbl.Rows.Count;
            Employee_rqst_label.Text = "You have " + dtbl.Rows.Count.ToString() + " pending employee requests.";
            EmployeeRqstGridView.DataSource = dtbl;
            con.Dispose();

        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            
            if (rqst == 0)
            {
                c.Text = "No Pending requests to review!";
                c.Show();
            }
            else
            {
                EmployeeRqstGridView.Show();
                Approvebutton.Show();
                Declinebutton.Show();
            }
            Hidebutton.BringToFront();

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            AdminHomeForm f = new AdminHomeForm();
            f.Show();
            this.Close();
        }

        private void Hidebutton_Click(object sender, EventArgs e)
        {
            EmployeeRqstGridView.Hide();
            Approvebutton.Hide();
            Declinebutton.Hide();
            c.Hide();
            Viewbutton.BringToFront();
        }

        private void Declinebutton_Click(object sender, EventArgs e)
        {

            se.GetSendEmail(Operator.rqstdelete).Invoke(email);
            con = new DatabaseAccess();
            sql = "Delete from Employee_Request where Id = " + ID + "";
            con.ExecuteQuery(sql);
            con.Dispose();
        }

        private void Approvebutton_Click(object sender, EventArgs e)
        {
            se.GetSendEmail(Operator.rqstaccept).Invoke(email);
            con = new DatabaseAccess();

            sql = "Insert into EmployeeInfo (Name,EMAIL, Appointed_AdminID) values ('" + name + "','" + email + "',( select AdminID from AdminInfo where Email = '"+LoginForm.email+"'))";
            con.ExecuteQuery(sql);
            sql = "select Password from Employee_Request where Id =" + ID + "";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            Password = HashClass.Hash(dtbl.Rows[0][0].ToString());
            sql = "Insert into LoginInfo (ID, Email, Password) values((Select EmployeeID from EmployeeInfo where EMAIL = '" + email + "'),'" + email+ "', '"+Password+"')";
            con.ExecuteQuery(sql);
            sql = "Delete from Employee_Request where Id = " + ID + "";
            con.ExecuteQuery(sql);
            con.Dispose();
        }

        private void EmployeeRqstGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(EmployeeRqstGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            email = EmployeeRqstGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            name = EmployeeRqstGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}

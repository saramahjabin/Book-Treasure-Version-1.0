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
using System.Data.SqlClient;
using System.IO;

namespace BookTreasure
{
    public partial class EmBookUpRqstDetailsForm : Form
    {
        DatabaseAccess con;
        string sql,ID, name, writer, approved_emoloyee_id;
        int rqst;
        SqlDataReader reader;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Irin\source\repos\BookTreasure\DB\BTUserInfo.mdf;Integrated Security=True;Connect Timeout=30");
        public EmBookUpRqstDetailsForm()
        {
            InitializeComponent();
        }

        private void EmBookUpRqstDetailsForm_Load(object sender, EventArgs e)
        {
            BookRqstGridView.Hide();
            Approvebutton.Hide();
            Declinebutton.Hide();
            Textlabel.Hide();
            axAcroPDF1.Hide();
            Closebutton.Hide();
            Viewbutton.Hide();
            con = new DatabaseAccess();
            sql = "select DonationReqest_ID, Donor_ID, Book_Name, Writer_Name from Book_Donation_RequestInfo where Status ='False' ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            rqst = dtbl.Rows.Count;
            Book_rqst_label.Text = "You have " + dtbl.Rows.Count.ToString() + " pending book upload requests.";
            BookRqstGridView.DataSource = dtbl;
            con.Dispose();
        }

        private void ViewDetailsbutton_Click(object sender, EventArgs e)
        {
            if (rqst == 0)
            {
                Textlabel.Text = "No Pending requests to review!";
                Textlabel.Show();
            }
            else
            {
                BookRqstGridView.Show();
                Approvebutton.Show();
                Declinebutton.Show();
                Viewbutton.Show();
            }
            Hidebutton.BringToFront();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            EmployeeHomeForm f = new EmployeeHomeForm();
            f.Show();
            this.Close();
        }

        private void Hidebutton_Click(object sender, EventArgs e)
        {
            BookRqstGridView.Hide();
            Approvebutton.Hide();
            Declinebutton.Hide();
            Viewbutton.Hide();
            Textlabel.Hide();
            ViewDetailsbutton.BringToFront();
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            Hidebutton.Hide();
            Closebutton.Show();
            axAcroPDF1.Show();
            string filename = "C:\'Users\'Irin\'downloads\'bbjfhdj.pdf";
            viewFile(filename);
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Hide();
            axAcroPDF1.Refresh();
            Hidebutton.Show();
            Closebutton.Hide();
        }

        private void Declinebutton_Click(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
            sql = "Delete from Book_Donation_RequestInfo where DonationReqest_ID = '" + ID + "'";
            con.ExecuteQuery(sql);
            MessageBox.Show("information deleted.");
            con.Dispose();
        }

        private void Approvebutton_Click(object sender, EventArgs e)
        {
            con = new DatabaseAccess();
            sql = "Select ID from LoginInfo WHERE Email = '" + LoginForm.email + "'; ";
            DataTable dtbl = new DataTable();
            con.GetData(sql).Fill(dtbl);
            approved_emoloyee_id = dtbl.Rows[0][0].ToString();
            sql = "Update Book_Donation_RequestInfo set Status = 1, Approved_EmployeeID ='"+ approved_emoloyee_id + "'  where DonationReqest_ID = '" + ID + "'";
            con.ExecuteQuery(sql);
            sql = "Update BookInfo set DonationReqest_ID= '" + ID + "' where (Book_Name = '" + name + "' and Writer_Name ='" + writer + "')";
            con.ExecuteQuery(sql);
            MessageBox.Show("Success");
            con.Dispose();
        }

        private void BookRqstGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = BookRqstGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            name = BookRqstGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            writer = BookRqstGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        public void viewFile(string file)
        {
            conn.Open();
            bool em = false;
            using (cmd = new SqlCommand("select Src_File from Book_Donation_RequestInfo where DonationReqest_ID ='" + ID + "'", conn))
            {
                using (reader = cmd.ExecuteReader(CommandBehavior.Default))
                {
                    if (reader.Read())
                    {
                        em = true;
                        byte[] filedata = (byte[])reader.GetValue(0);
                        using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(filedata);
                                bw.Close();
                                axAcroPDF1.src = file;
                                axAcroPDF1.Refresh();
                            }
                            if (em == false)
                            {
                                MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            reader.Close();
                        }
                    }
                }
            }
            conn.Close();
        }
    }
}

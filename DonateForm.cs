using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using BookTreasure.Repositories;

namespace BookTreasure
{
    public partial class DonateForm : Form
    {
        //DatabaseAccess conn;
        public static  byte[] contents;
        string donor_id;
       SqlCommand cmd;
       SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Irin\source\repos\BookTreasure\DB\BTUserInfo.mdf;Integrated Security=True;Connect Timeout=30");
        public DonateForm()
        {
            InitializeComponent();
        }

        private void Upload(string file)
        {

            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select ID from LoginInfo  WHERE Email = '" + LoginForm.email + "';",con);
            DataTable dtbl = new DataTable();
            ad.Fill(dtbl);
            donor_id = dtbl.Rows[0][0].ToString();
            FileStream stream = File.OpenRead(file);
            contents = new byte[stream.Length];
            stream.Read(contents, 0, (int)stream.Length);
            stream.Close();
            /* sql = "insert into BookInfo(Book_Name,Writer_Name,Src_File) " +
                 "values('" + BookNametextBox.Text + "','" + WritertextBox.Text + "','" + contents + "')";
             con.ExecuteQuery(sql);*/

            using (cmd = new SqlCommand("insert into Book_Donation_RequestInfo(Donor_ID, Book_Name,Writer_Name,Src_File) " +
                "values(@d,@name,@writerName,@file)", this.con));
            {
                cmd.Parameters.AddWithValue("@d", donor_id);
                cmd.Parameters.AddWithValue("@name", BookNametextBox.Text);
                cmd.Parameters.AddWithValue("@writerName", WritertextBox.Text);
                cmd.Parameters.AddWithValue("@file", contents);
                cmd.ExecuteNonQuery();
            }

            using (cmd = new SqlCommand("insert into BookInfo(Book_Name,Writer_Name,Src_File) " +
    "values(@name,@writerName,@file)", this.con)) ;
            {
                cmd.Parameters.AddWithValue("@name", BookNametextBox.Text);
                cmd.Parameters.AddWithValue("@writerName", WritertextBox.Text);
                cmd.Parameters.AddWithValue("@file", contents);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Success");

            con.Close();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
          using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents (*.pdf) |*.pdf", ValidateNames = true })
            {
                if(dlg.ShowDialog()== DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Are you want to upload this file?", "Book Treasure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string filename = dlg.FileName;
                        Upload(filename);
                    }
                }
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTreasure.Repositories 
{
    class DatabaseAccess : IDisposable
    {
        private SqlConnection con;
        private SqlCommand command;

        public DatabaseAccess()
        {
            try
            {
                this.con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Irin\source\repos\BookTreasure\DB\BTUserInfo.mdf;Integrated Security=True;Connect Timeout=30");
                this.con.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public SqlDataReader GetReaderData(string sql)
        {
            this.command = new SqlCommand(sql, this.con);
            return this.command.ExecuteReader();
        }

        public SqlDataAdapter GetData(string sql)
        {
            return new SqlDataAdapter(sql, this.con);
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.con);
            return this.command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.con.Close();
        }
    }
}
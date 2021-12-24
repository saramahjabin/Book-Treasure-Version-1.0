using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookTreasure
{
    public partial class FormFront : System.Windows.Forms.Form
    {
        public FormFront()
        {
            InitializeComponent();
        }

        private void FormFront_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
            timer1.Enabled = false;
        }
    }
}

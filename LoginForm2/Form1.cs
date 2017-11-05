using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string expectedUsername = "Kaas";
            string expectedPassword = "123";

            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            if (expectedUsername != inputUsername && expectedPassword != inputPassword)
            {
                MessageBox.Show("Username or password is incorrect");
            }
            else
            {
                MessageBox.Show("You're logged in...");
            }
        }
    }
}

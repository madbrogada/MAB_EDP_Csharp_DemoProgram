using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAB_EDP_Csharp_DemoProgram
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            bool isAuthenticated = dbManager.AuthenticateUser(txtUsername.Text, txtPassword.Text);

            if (isAuthenticated)
            {
                MessageBox.Show("Login Successful. Click OK to view Application's Dashboard", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                frmDashboard dashboard = new frmDashboard(); 
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed. Please check your username and password.","Invalid Credentials",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you want to close the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (answer == DialogResult.Yes)
            {
                // User chose Yes, close the application
                Application.Exit();
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MessageBox.Show(Application.StartupPath);
            MessageBox.Show(now.ToString());
        }
    }
}

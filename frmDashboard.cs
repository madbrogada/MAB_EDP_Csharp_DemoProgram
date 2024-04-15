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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmLogin loginwidow = new frmLogin();
            this.Close();
            loginwidow.ShowDialog();

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.ShowDialog();

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void listOfUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountList userlist = new frmAccountList();
            userlist.ShowDialog();
        }
    }
}

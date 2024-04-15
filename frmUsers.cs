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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
            txtUserSearchUpdate.KeyDown += new KeyEventHandler(txtUserSearchUpdate_KeyDown);
        }
        private bool AreTextboxesFilled(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (AreTextboxesFilled(txtUsername, txtPassword, txtEmail))
            {
                var dbManager = new DBManager();
                dbManager.InsertUser(txtUsername.Text, txtPassword.Text, txtEmail.Text);
                MessageBox.Show("User added successfully!","Sucess!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes(this);
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.","Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearTextBoxes(c);  // Recursive call for containers
                }
            }
        }

        private void txtUserSearchUpdate_Click(object sender, EventArgs e)
        {
        
        }

            private void txtUserSearchUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // to prevent the ding sound
                var dbManager = new DBManager();
                var user = dbManager.SearchUserByUsername(txtUserSearchUpdate.Text.Trim());

                if (user != null)
                {
                    txtUsernameUpdate.Text = user.Username;
                    txtPasswordUpdate.Text = user.password;
                    txtEmailUpdate.Text = user.Email;
                }
                else
                {
                    MessageBox.Show("User not found.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearTextBoxes(this);
                }
            }
        }

        private void btnUpdateUserProfile_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            dbManager.UpdateUser(txtUsernameUpdate.Text, txtPasswordUpdate.Text, txtEmailUpdate.Text);
            MessageBox.Show("User profile updated!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes(this);
        }

        private void txtUserSearchUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            var user = dbManager.SearchUserByUsername(txtDeleteSearch.Text.Trim());

            if (user != null)
            {
                var answer = MessageBox.Show("Delete this account?\r\n\n" + user.Username + "-" + user.Email, "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {

                    dbManager.DeleteUser(txtDeleteSearch.Text);
                    MessageBox.Show("Account Deleted!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes(this);
                }
        
            }
            else
            {
                MessageBox.Show("User not found.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeleteSearch.Focus();
            }
        }
    }
}

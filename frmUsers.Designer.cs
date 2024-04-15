namespace MAB_EDP_Csharp_DemoProgram
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabAddUser = new System.Windows.Forms.TabPage();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUpdateUser = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsernameUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateUserProfile = new System.Windows.Forms.Button();
            this.txtEmailUpdate = new System.Windows.Forms.TextBox();
            this.txtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserSearchUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabDeleteUser = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtDeleteSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlUser.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.tabUpdateUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabDeleteUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Controls.Add(this.tabAddUser);
            this.tabControlUser.Controls.Add(this.tabUpdateUser);
            this.tabControlUser.Controls.Add(this.tabDeleteUser);
            this.tabControlUser.Location = new System.Drawing.Point(12, 12);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(418, 311);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabAddUser
            // 
            this.tabAddUser.BackColor = System.Drawing.Color.Silver;
            this.tabAddUser.Controls.Add(this.txtEmail);
            this.tabAddUser.Controls.Add(this.label3);
            this.tabAddUser.Controls.Add(this.btnAddUser);
            this.tabAddUser.Controls.Add(this.txtPassword);
            this.tabAddUser.Controls.Add(this.label2);
            this.tabAddUser.Controls.Add(this.txtUsername);
            this.tabAddUser.Controls.Add(this.label1);
            this.tabAddUser.Location = new System.Drawing.Point(4, 29);
            this.tabAddUser.Name = "tabAddUser";
            this.tabAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUser.Size = new System.Drawing.Size(410, 278);
            this.tabAddUser.TabIndex = 0;
            this.tabAddUser.Text = "Add User";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(25, 201);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(346, 48);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Save Account";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(146, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(146, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // tabUpdateUser
            // 
            this.tabUpdateUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabUpdateUser.Controls.Add(this.groupBox1);
            this.tabUpdateUser.Controls.Add(this.txtUserSearchUpdate);
            this.tabUpdateUser.Controls.Add(this.label4);
            this.tabUpdateUser.Location = new System.Drawing.Point(4, 29);
            this.tabUpdateUser.Name = "tabUpdateUser";
            this.tabUpdateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateUser.Size = new System.Drawing.Size(410, 278);
            this.tabUpdateUser.TabIndex = 1;
            this.tabUpdateUser.Text = "Update User Profile";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsernameUpdate);
            this.groupBox1.Controls.Add(this.btnUpdateUserProfile);
            this.groupBox1.Controls.Add(this.txtEmailUpdate);
            this.groupBox1.Controls.Add(this.txtPasswordUpdate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(21, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtUsernameUpdate
            // 
            this.txtUsernameUpdate.Enabled = false;
            this.txtUsernameUpdate.Location = new System.Drawing.Point(119, 24);
            this.txtUsernameUpdate.Name = "txtUsernameUpdate";
            this.txtUsernameUpdate.Size = new System.Drawing.Size(235, 27);
            this.txtUsernameUpdate.TabIndex = 18;
            // 
            // btnUpdateUserProfile
            // 
            this.btnUpdateUserProfile.Location = new System.Drawing.Point(21, 151);
            this.btnUpdateUserProfile.Name = "btnUpdateUserProfile";
            this.btnUpdateUserProfile.Size = new System.Drawing.Size(334, 43);
            this.btnUpdateUserProfile.TabIndex = 17;
            this.btnUpdateUserProfile.Text = "Update Account Profile";
            this.btnUpdateUserProfile.UseVisualStyleBackColor = true;
            this.btnUpdateUserProfile.Click += new System.EventHandler(this.btnUpdateUserProfile_Click);
            // 
            // txtEmailUpdate
            // 
            this.txtEmailUpdate.Location = new System.Drawing.Point(119, 104);
            this.txtEmailUpdate.Name = "txtEmailUpdate";
            this.txtEmailUpdate.Size = new System.Drawing.Size(237, 27);
            this.txtEmailUpdate.TabIndex = 16;
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.Location = new System.Drawing.Point(119, 64);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(237, 27);
            this.txtPasswordUpdate.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Username:";
            // 
            // txtUserSearchUpdate
            // 
            this.txtUserSearchUpdate.Location = new System.Drawing.Point(204, 22);
            this.txtUserSearchUpdate.Name = "txtUserSearchUpdate";
            this.txtUserSearchUpdate.Size = new System.Drawing.Size(191, 27);
            this.txtUserSearchUpdate.TabIndex = 1;
            this.txtUserSearchUpdate.TextChanged += new System.EventHandler(this.txtUserSearchUpdate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search by Username:";
            // 
            // tabDeleteUser
            // 
            this.tabDeleteUser.BackColor = System.Drawing.Color.Gray;
            this.tabDeleteUser.Controls.Add(this.btnDeleteUser);
            this.tabDeleteUser.Controls.Add(this.txtDeleteSearch);
            this.tabDeleteUser.Controls.Add(this.label5);
            this.tabDeleteUser.Location = new System.Drawing.Point(4, 29);
            this.tabDeleteUser.Name = "tabDeleteUser";
            this.tabDeleteUser.Size = new System.Drawing.Size(410, 278);
            this.tabDeleteUser.TabIndex = 2;
            this.tabDeleteUser.Text = "Delete User";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(28, 185);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(360, 60);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete Account";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtDeleteSearch
            // 
            this.txtDeleteSearch.Location = new System.Drawing.Point(206, 27);
            this.txtDeleteSearch.Name = "txtDeleteSearch";
            this.txtDeleteSearch.Size = new System.Drawing.Size(183, 27);
            this.txtDeleteSearch.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search by Username:";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 341);
            this.Controls.Add(this.tabControlUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Manager";
            this.tabControlUser.ResumeLayout(false);
            this.tabAddUser.ResumeLayout(false);
            this.tabAddUser.PerformLayout();
            this.tabUpdateUser.ResumeLayout(false);
            this.tabUpdateUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabDeleteUser.ResumeLayout(false);
            this.tabDeleteUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabAddUser;
        private System.Windows.Forms.TabPage tabUpdateUser;
        private System.Windows.Forms.TabPage tabDeleteUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserSearchUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsernameUpdate;
        private System.Windows.Forms.Button btnUpdateUserProfile;
        private System.Windows.Forms.TextBox txtEmailUpdate;
        private System.Windows.Forms.TextBox txtPasswordUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtDeleteSearch;
        private System.Windows.Forms.Label label5;
    }
}
namespace ISAD157_Coursework
{
    partial class Form1
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
            this.lblUsers = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.lstBoxUsers = new System.Windows.Forms.ListBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtHometown = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtRelStatus = new System.Windows.Forms.TextBox();
            this.txtTownOrCity = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.lstBoxFriends = new System.Windows.Forms.ListBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblFriends = new System.Windows.Forms.Label();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.btnDeleteFriend = new System.Windows.Forms.Button();
            this.lstBoxWorkplaces = new System.Windows.Forms.ListBox();
            this.lstBoxTo = new System.Windows.Forms.ListBox();
            this.lstBoxFrom = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstBoxSchools = new System.Windows.Forms.ListBox();
            this.txtMsgText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(23, 154);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(72, 26);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "Users";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(216, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearchUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearchUser.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUser.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSearchUser.Location = new System.Drawing.Point(29, 207);
            this.txtSearchUser.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(177, 29);
            this.txtSearchUser.TabIndex = 3;
            // 
            // lstBoxUsers
            // 
            this.lstBoxUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstBoxUsers.FormattingEnabled = true;
            this.lstBoxUsers.ItemHeight = 22;
            this.lstBoxUsers.Location = new System.Drawing.Point(29, 251);
            this.lstBoxUsers.Margin = new System.Windows.Forms.Padding(5);
            this.lstBoxUsers.Name = "lstBoxUsers";
            this.lstBoxUsers.Size = new System.Drawing.Size(257, 642);
            this.lstBoxUsers.TabIndex = 4;
            this.lstBoxUsers.SelectedIndexChanged += new System.EventHandler(this.lstUser_SelectedIndexChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(386, 92);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(226, 28);
            this.txtUserID.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(386, 136);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(226, 28);
            this.txtUserName.TabIndex = 6;
            // 
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(386, 176);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(226, 28);
            this.txtHometown.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(386, 216);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(226, 28);
            this.txtGender.TabIndex = 8;
            // 
            // txtRelStatus
            // 
            this.txtRelStatus.Location = new System.Drawing.Point(386, 256);
            this.txtRelStatus.Name = "txtRelStatus";
            this.txtRelStatus.Size = new System.Drawing.Size(226, 28);
            this.txtRelStatus.TabIndex = 9;
            // 
            // txtTownOrCity
            // 
            this.txtTownOrCity.Location = new System.Drawing.Point(386, 296);
            this.txtTownOrCity.Name = "txtTownOrCity";
            this.txtTownOrCity.Size = new System.Drawing.Size(226, 28);
            this.txtTownOrCity.TabIndex = 10;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddUser.Enabled = false;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(296, 253);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(71, 34);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditUser.Enabled = false;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.Location = new System.Drawing.Point(296, 297);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(71, 34);
            this.btnEditUser.TabIndex = 12;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // lstBoxFriends
            // 
            this.lstBoxFriends.FormattingEnabled = true;
            this.lstBoxFriends.ItemHeight = 22;
            this.lstBoxFriends.Location = new System.Drawing.Point(386, 374);
            this.lstBoxFriends.Name = "lstBoxFriends";
            this.lstBoxFriends.Size = new System.Drawing.Size(282, 400);
            this.lstBoxFriends.TabIndex = 13;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(296, 341);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(71, 34);
            this.btnDeleteUser.TabIndex = 14;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // lblFriends
            // 
            this.lblFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFriends.AutoSize = true;
            this.lblFriends.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriends.Location = new System.Drawing.Point(381, 336);
            this.lblFriends.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.lblFriends.Name = "lblFriends";
            this.lblFriends.Size = new System.Drawing.Size(88, 26);
            this.lblFriends.TabIndex = 15;
            this.lblFriends.Text = "Friends";
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddFriend.Enabled = false;
            this.btnAddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFriend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.Location = new System.Drawing.Point(676, 374);
            this.btnAddFriend.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(66, 34);
            this.btnAddFriend.TabIndex = 16;
            this.btnAddFriend.Text = "Add";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFriend
            // 
            this.btnDeleteFriend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteFriend.Enabled = false;
            this.btnDeleteFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFriend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFriend.Location = new System.Drawing.Point(676, 418);
            this.btnDeleteFriend.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteFriend.Name = "btnDeleteFriend";
            this.btnDeleteFriend.Size = new System.Drawing.Size(66, 34);
            this.btnDeleteFriend.TabIndex = 17;
            this.btnDeleteFriend.Text = "Delete";
            this.btnDeleteFriend.UseVisualStyleBackColor = true;
            // 
            // lstBoxWorkplaces
            // 
            this.lstBoxWorkplaces.FormattingEnabled = true;
            this.lstBoxWorkplaces.ItemHeight = 22;
            this.lstBoxWorkplaces.Location = new System.Drawing.Point(790, 92);
            this.lstBoxWorkplaces.Name = "lstBoxWorkplaces";
            this.lstBoxWorkplaces.Size = new System.Drawing.Size(198, 312);
            this.lstBoxWorkplaces.TabIndex = 18;
            // 
            // lstBoxTo
            // 
            this.lstBoxTo.FormattingEnabled = true;
            this.lstBoxTo.ItemHeight = 22;
            this.lstBoxTo.Location = new System.Drawing.Point(1021, 92);
            this.lstBoxTo.Name = "lstBoxTo";
            this.lstBoxTo.Size = new System.Drawing.Size(198, 312);
            this.lstBoxTo.TabIndex = 19;
            // 
            // lstBoxFrom
            // 
            this.lstBoxFrom.FormattingEnabled = true;
            this.lstBoxFrom.ItemHeight = 22;
            this.lstBoxFrom.Location = new System.Drawing.Point(1252, 92);
            this.lstBoxFrom.Name = "lstBoxFrom";
            this.lstBoxFrom.Size = new System.Drawing.Size(198, 312);
            this.lstBoxFrom.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(785, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Workplaces";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1016, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1247, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 419);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Schools";
            // 
            // lstBoxSchools
            // 
            this.lstBoxSchools.FormattingEnabled = true;
            this.lstBoxSchools.ItemHeight = 22;
            this.lstBoxSchools.Location = new System.Drawing.Point(790, 457);
            this.lstBoxSchools.Name = "lstBoxSchools";
            this.lstBoxSchools.Size = new System.Drawing.Size(198, 290);
            this.lstBoxSchools.TabIndex = 24;
            // 
            // txtMsgText
            // 
            this.txtMsgText.Location = new System.Drawing.Point(1021, 457);
            this.txtMsgText.Name = "txtMsgText";
            this.txtMsgText.Size = new System.Drawing.Size(429, 290);
            this.txtMsgText.TabIndex = 26;
            this.txtMsgText.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1016, 419);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Message Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMsgText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstBoxSchools);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxFrom);
            this.Controls.Add(this.lstBoxTo);
            this.Controls.Add(this.lstBoxWorkplaces);
            this.Controls.Add(this.btnDeleteFriend);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.lblFriends);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.lstBoxFriends);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtTownOrCity);
            this.Controls.Add(this.txtRelStatus);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtHometown);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lstBoxUsers);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Facebook Database System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.ListBox lstBoxUsers;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtHometown;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtRelStatus;
        private System.Windows.Forms.TextBox txtTownOrCity;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.ListBox lstBoxFriends;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblFriends;
        private System.Windows.Forms.Button btnAddFriend;
        private System.Windows.Forms.Button btnDeleteFriend;
        private System.Windows.Forms.ListBox lstBoxWorkplaces;
        private System.Windows.Forms.ListBox lstBoxTo;
        private System.Windows.Forms.ListBox lstBoxFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstBoxSchools;
        private System.Windows.Forms.RichTextBox txtMsgText;
        private System.Windows.Forms.Label label5;
    }
}


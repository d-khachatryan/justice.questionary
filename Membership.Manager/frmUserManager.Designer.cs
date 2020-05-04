namespace AspNetMembershipMgr
{
    partial class frmUserManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rolesTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.appRoles = new System.Windows.Forms.CheckedListBox();
            this.assignedUsers = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbRoleUser = new System.Windows.Forms.ToolStripButton();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.appUsers = new System.Windows.Forms.CheckedListBox();
            this.userRoles = new System.Windows.Forms.CheckedListBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.TsbCreateUser = new System.Windows.Forms.ToolStripButton();
            this.TsbDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.TsbUserRole = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.tsbChangePassword = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.rolesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.usersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.rolesTab);
            this.tabControl1.Controls.Add(this.usersTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 512);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Visible = false;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // rolesTab
            // 
            this.rolesTab.Controls.Add(this.splitContainer1);
            this.rolesTab.Controls.Add(this.toolStrip1);
            this.rolesTab.Location = new System.Drawing.Point(4, 27);
            this.rolesTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rolesTab.Name = "rolesTab";
            this.rolesTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rolesTab.Size = new System.Drawing.Size(672, 481);
            this.rolesTab.TabIndex = 1;
            this.rolesTab.Text = "Դերեր";
            this.rolesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 29);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.appRoles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.assignedUsers);
            this.splitContainer1.Size = new System.Drawing.Size(666, 448);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // appRoles
            // 
            this.appRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appRoles.FormattingEnabled = true;
            this.appRoles.Location = new System.Drawing.Point(0, 0);
            this.appRoles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appRoles.Name = "appRoles";
            this.appRoles.Size = new System.Drawing.Size(221, 448);
            this.appRoles.TabIndex = 9;
            this.toolTip1.SetToolTip(this.appRoles, "Lists all the roles existing in\r\ncurrently selected application.");
            this.appRoles.SelectedIndexChanged += new System.EventHandler(this.appRoles_SelectedIndexChanged);
            // 
            // assignedUsers
            // 
            this.assignedUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignedUsers.FormattingEnabled = true;
            this.assignedUsers.Location = new System.Drawing.Point(0, 0);
            this.assignedUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assignedUsers.Name = "assignedUsers";
            this.assignedUsers.Size = new System.Drawing.Size(440, 448);
            this.assignedUsers.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbRoleUser});
            this.toolStrip1.Location = new System.Drawing.Point(3, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(666, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbRoleUser
            // 
            this.TsbRoleUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbRoleUser.Image = ((System.Drawing.Image)(resources.GetObject("TsbRoleUser.Image")));
            this.TsbRoleUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbRoleUser.Name = "TsbRoleUser";
            this.TsbRoleUser.Size = new System.Drawing.Size(23, 22);
            this.TsbRoleUser.Text = "toolStripButton3";
            this.TsbRoleUser.Click += new System.EventHandler(this.applyRolesBtn_Click);
            // 
            // usersTab
            // 
            this.usersTab.Controls.Add(this.splitContainer2);
            this.usersTab.Controls.Add(this.toolStrip2);
            this.usersTab.Location = new System.Drawing.Point(4, 27);
            this.usersTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersTab.Name = "usersTab";
            this.usersTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersTab.Size = new System.Drawing.Size(672, 481);
            this.usersTab.TabIndex = 2;
            this.usersTab.Text = "Օգտվողներ";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 29);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.appUsers);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.userRoles);
            this.splitContainer2.Size = new System.Drawing.Size(666, 448);
            this.splitContainer2.SplitterDistance = 221;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // appUsers
            // 
            this.appUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appUsers.FormattingEnabled = true;
            this.appUsers.Location = new System.Drawing.Point(0, 0);
            this.appUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appUsers.Name = "appUsers";
            this.appUsers.Size = new System.Drawing.Size(221, 448);
            this.appUsers.TabIndex = 6;
            this.toolTip1.SetToolTip(this.appUsers, "Lists all the users present in\r\nthe selected application.");
            this.appUsers.SelectedIndexChanged += new System.EventHandler(this.appUsers_SelectedIndexChanged);
            // 
            // userRoles
            // 
            this.userRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userRoles.FormattingEnabled = true;
            this.userRoles.Location = new System.Drawing.Point(0, 0);
            this.userRoles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userRoles.Name = "userRoles";
            this.userRoles.Size = new System.Drawing.Size(440, 448);
            this.userRoles.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbCreateUser,
            this.TsbDeleteUser,
            this.TsbUserRole,
            this.tsbChangePassword});
            this.toolStrip2.Location = new System.Drawing.Point(3, 4);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(666, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // TsbCreateUser
            // 
            this.TsbCreateUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("TsbCreateUser.Image")));
            this.TsbCreateUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCreateUser.Name = "TsbCreateUser";
            this.TsbCreateUser.Size = new System.Drawing.Size(23, 22);
            this.TsbCreateUser.Text = "toolStripButton1";
            this.TsbCreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // TsbDeleteUser
            // 
            this.TsbDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("TsbDeleteUser.Image")));
            this.TsbDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbDeleteUser.Name = "TsbDeleteUser";
            this.TsbDeleteUser.Size = new System.Drawing.Size(23, 22);
            this.TsbDeleteUser.Text = "toolStripButton2";
            this.TsbDeleteUser.Click += new System.EventHandler(this.RemoveUser_Click);
            // 
            // TsbUserRole
            // 
            this.TsbUserRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbUserRole.Image = ((System.Drawing.Image)(resources.GetObject("TsbUserRole.Image")));
            this.TsbUserRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbUserRole.Name = "TsbUserRole";
            this.TsbUserRole.Size = new System.Drawing.Size(23, 22);
            this.TsbUserRole.Text = "toolStripButton4";
            this.TsbUserRole.Click += new System.EventHandler(this.applyUserBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // TimerMain
            // 
            this.TimerMain.Enabled = true;
            this.TimerMain.Interval = 500;
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // tsbChangePassword
            // 
            this.tsbChangePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangePassword.Image")));
            this.tsbChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangePassword.Name = "tsbChangePassword";
            this.tsbChangePassword.Size = new System.Drawing.Size(23, 22);
            this.tsbChangePassword.Text = "toolStripButton1";
            this.tsbChangePassword.Click += new System.EventHandler(this.tsbChangePassword_Click);
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 512);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Օգտվողների կառավարման պատուհան";
            this.tabControl1.ResumeLayout(false);
            this.rolesTab.ResumeLayout(false);
            this.rolesTab.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.usersTab.ResumeLayout(false);
            this.usersTab.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage usersTab;
        private System.Windows.Forms.CheckedListBox appUsers;
        private System.Windows.Forms.CheckedListBox assignedUsers;
        private System.Windows.Forms.CheckedListBox appRoles;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox userRoles;
        private System.Windows.Forms.Timer TimerMain;
        private System.Windows.Forms.TabPage rolesTab;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbRoleUser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton TsbCreateUser;
        private System.Windows.Forms.ToolStripButton TsbDeleteUser;
        private System.Windows.Forms.ToolStripButton TsbUserRole;
        private System.Windows.Forms.ToolStripButton tsbChangePassword;
    }
}


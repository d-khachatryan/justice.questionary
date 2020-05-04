using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;
using System.Collections;
using System.Configuration.Provider;
using System.Linq;
/**
 * 
 */
namespace AspNetMembershipMgr
{

    public partial class frmUserManager : Form
    {
        private Facade facade;
        private string strConnectionString;
        private string strLanguage;

        public frmUserManager(string language, string connectionString)
        {
            strLanguage = language;
            InitializeComponent();
            strConnectionString = connectionString;

            facade = new Facade();
        }

        private void ClearCheckedItems(CheckedListBox clb)
        {
            foreach (int i in clb.CheckedIndices)
            {
                clb.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void ShowTabs(bool show)
        {
            tabControl1.TabPages.Remove(rolesTab);
            tabControl1.TabPages.Remove(usersTab);
            if (show)
            {
                tabControl1.TabPages.Add(rolesTab);
                tabControl1.TabPages.Add(usersTab);
            }
        }

        

        private void removeRole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (appRoles.CheckedIndices.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show(this, "Are you sure you want to delete selected roles?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        List<string> items = new List<string>();
                        foreach (object item in appRoles.CheckedItems)
                        {
                            string val = item.ToString();
                            Roles.DeleteRole(val, true);
                            items.Add(val);
                        }
                        foreach (string s in items) appRoles.Items.Remove(s);
                        ClearCheckedItems(assignedUsers);
                        MessageBox.Show(this, "Selected role(s) deleted!");
                    }
                    catch (ProviderException ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Please select the role(s) to be deleted!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserDetailsForm f = new UserDetailsForm();
            DialogResult s = f.ShowDialog(this);
            if (DialogResult.OK == s)
            {
                Membership.CreateUser(f.UserDetails.UserName, f.UserDetails.Password, f.UserDetails.Email);
                appUsers.Items.Add(f.UserDetails.UserName);
                //this.vaspnetUserBindingSource.DataSource = from p in mdb.vaspnet_Users select p;
                //MessageBox.Show(this, "New user hs been added!");
            }
        }

        private void removeUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (appUsers.CheckedIndices.Count < 1)
            {
                MessageBox.Show(this, "Please select the users to be deleted!");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show(this, "Delete checked users?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                List<string> uu = new List<string>();
                foreach (string ss in appUsers.CheckedItems)
                {
                    uu.Add(ss);
                }
                //uu.AddRange(appUsers.CheckedItems.Cast<string>());
                facade.RemoveUsers(uu);
                foreach (string ss in uu)
                {
                    appUsers.Items.Remove(ss);
                }
                ClearCheckedItems(userRoles);
                MessageBox.Show(this, "Changes have been applied!");
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    appUsers.Items.Clear();
                    assignedUsers.Items.Clear();
                    List<string> users = facade.GetAllUsers();
                    appUsers.Items.AddRange(users.ToArray());
                    assignedUsers.Items.AddRange(users.ToArray());
                    break;
                case 1:
                    string[] roles = Roles.GetAllRoles();
                    userRoles.Items.Clear();
                    userRoles.Items.AddRange(roles);
                    break;
                default:
                    break;
            }
        }

        private void appRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appRoles.SelectedIndices.Count == 0) return;
            string[] users = Roles.GetUsersInRole(appRoles.SelectedItem.ToString());
            ClearCheckedItems(assignedUsers);
            for (int i = 0; i < users.Length; i++)
            {
                int x = assignedUsers.Items.IndexOf(users[i]);
                assignedUsers.SetItemCheckState(x, CheckState.Checked);
            }
        }

        private void appUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appUsers.SelectedIndices.Count == 0) return;
            string user = appUsers.SelectedItem.ToString();
            string[] roles = Roles.GetRolesForUser(user);
            ClearCheckedItems(userRoles);
            for (int i = 0; i < roles.Length; i++)
            {
                int x = userRoles.Items.IndexOf(roles[i]);
                userRoles.SetItemCheckState(x, CheckState.Checked);
            }
        }

        private void applyUserBtn_Click(object sender, EventArgs e)
        {
            if (appUsers.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Please select a user first!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult r = MessageBox.Show(this, "Are you sure?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) return;
            string user = appUsers.SelectedItem.ToString();
            for (int i = 0; i < userRoles.Items.Count; i++)
            {
                string role = userRoles.Items[i].ToString();
                if (userRoles.GetItemCheckState(i) == CheckState.Checked)
                {
                    if (!Roles.IsUserInRole(user, role))
                        Roles.AddUserToRole(user, role);
                }
                else
                {
                    if (Roles.IsUserInRole(user, role))
                        Roles.RemoveUserFromRole(user, role);
                }
            }
            //if (unlock.Checked) Membership.GetUser(user).UnlockUser();
            //MessageBox.Show(this, "Changes applied!");
        }

        private void applyRolesBtn_Click(object sender, EventArgs e)
        {
            if (appRoles.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Please select a role first!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult r = MessageBox.Show(this, "Are you sure?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) return;
            string role = appRoles.SelectedItem.ToString();
            for (int i = 0; i < assignedUsers.Items.Count; i++)
            {
                string user = assignedUsers.Items[i].ToString();
                if (assignedUsers.GetItemCheckState(i) == CheckState.Checked)
                {
                    if (!Roles.IsUserInRole(user, role))
                        Roles.AddUserToRole(user, role);
                }
                else
                {
                    if (Roles.IsUserInRole(user, role))
                        Roles.RemoveUserFromRole(user, role);
                }
            }
            MessageBox.Show(this, "Changes applied!");
        }

        private void TimerMain_Tick(object sender, EventArgs e)
        {
            this.TimerMain.Enabled = false;

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                facade.Init(strConnectionString);
                tabControl1.Visible = true;
                string appName = @"\";
                Membership.ApplicationName = appName;
                Roles.ApplicationName = appName;
                appRoles.Items.Clear();
                appUsers.Items.Clear();             
                appRoles.Items.AddRange(facade.GetAllRoles());
                ShowTabs(true);
                tabControl1.SelectTab("rolesTab");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetailsForm f = new UserDetailsForm();
            DialogResult s = f.ShowDialog(this);
            if (DialogResult.OK == s)
            {
                Membership.CreateUser(f.UserDetails.UserName, f.UserDetails.Password, f.UserDetails.Email);
                appUsers.Items.Add(f.UserDetails.UserName);
            }
        }

              private void RemoveSelectedRole_Click(object sender, EventArgs e)
        {
            if (appRoles.CheckedIndices.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show(this, "Are you sure you want to delete selected roles?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        List<string> items = new List<string>();
                        foreach (object item in appRoles.CheckedItems)
                        {
                            string val = item.ToString();
                            Roles.DeleteRole(val, true);
                            items.Add(val);
                        }
                        foreach (string s in items) appRoles.Items.Remove(s);
                        ClearCheckedItems(assignedUsers);
                        MessageBox.Show(this, "Selected role(s) deleted!");
                    }
                    catch (ProviderException ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Please select the role(s) to be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            UserDetailsForm f = new UserDetailsForm();
            DialogResult s = f.ShowDialog(this);
            if (DialogResult.OK == s)
            {
                Membership.CreateUser(f.UserDetails.UserName, f.UserDetails.Password, f.UserDetails.Email);
                appUsers.Items.Add(f.UserDetails.UserName);
                MessageBox.Show(this, "Նոր օգտվողի գրառումը ստեղծված է");
                
            }
        }

        private void RemoveUser_Click(object sender, EventArgs e)
        {
            if (appUsers.CheckedIndices.Count < 1)
            {
                MessageBox.Show(this, "Please select the users to be deleted!");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show(this, "Delete checked users?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                List<string> uu = new List<string>();
                foreach (string ss in appUsers.CheckedItems)
                {
                    uu.Add(ss);
                }
                //uu.AddRange(appUsers.CheckedItems.Cast<string>());
                facade.RemoveUsers(uu);
                foreach (string ss in uu)
                {
                    appUsers.Items.Remove(ss);
                }
                ClearCheckedItems(userRoles);
                MessageBox.Show(this, "Changes have been applied!");
            }
        }

        private void tsbChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                frmChangePassword frm = new frmChangePassword(strLanguage, strConnectionString);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}

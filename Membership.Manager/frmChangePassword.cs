using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;

namespace AspNetMembershipMgr
{
    public partial class frmChangePassword : Form
    {
        private Facade facade;

        public frmChangePassword(string language, string connectionString)
        {
            InitializeComponent();
            facade = new Facade();
            facade.Init(connectionString);
            string appName = @"\";
            Membership.ApplicationName = appName;
            Roles.ApplicationName = appName;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!this.TxtPassword.Text.Equals(this.TxtConfirmPassword.Text))
            {
                MessageBox.Show(this, "Ծածկագիրը և հաստատել ծածկագիրը դաշտերը չեն համապատասխանում",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MembershipUser mu = Membership.GetUser(this.TxtUserName.Text);
                mu.ChangePassword(mu.ResetPassword(), this.TxtPassword.Text);
            }
        }
    }
}

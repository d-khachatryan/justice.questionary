using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Web.Security;

namespace AspNetMembershipMgr
{
    public partial class frmLogin : Form
    {
        public string strUserName;
        private Facade facade;

        public frmLogin(string language, string connectionString)
        {
            InitializeComponent();
            this.AcceptButton = this.btnLogin;
            facade = new Facade();
            facade.Init(connectionString);
            string appName = @"\";
            Membership.ApplicationName = appName;
            Roles.ApplicationName = appName;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(this.userName.Text, this.password.Text))
            {
                strUserName = this.userName.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Գործարկողը կամ ծածկագիրը սխալ է", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }


}

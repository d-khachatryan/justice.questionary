using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AspNetMembershipMgr
{
    /// <summary>
    /// User details form for new user creation.
    /// </summary>
    public partial class UserDetailsForm : Form
    {
        /// <summary>
        /// Details of the users.
        /// </summary>
        public UserDto UserDetails { get; set; }
        /// <summary>
        /// C'tor.
        /// </summary>
        public UserDetailsForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!password.Text.Equals(password2.Text))
            {
                MessageBox.Show(this, "Re-typed password must match the first one!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UserDetails = new UserDto(userName.Text, password.Text, email.Text);
                Dispose();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(userName, "User name cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(userName, "");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void password2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(password2.Text) ||
                !password.Text.Equals(password2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(password2, "Password cannot be empty and re-typed password must match!");
                errorProvider1.SetError(password, "Password cannot be empty and re-typed password must match!");
            }
            else
            {
                errorProvider1.SetError(password2, "");
                errorProvider1.SetError(password, "");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void email_Validating(object sender, CancelEventArgs e)
        {
            string em = email.Text;
            if (string.IsNullOrEmpty(em) || em.IndexOf('@') == -1 || em.IndexOf('.') == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(email, "Email is invalid!");
            }
            else
            {
                errorProvider1.SetError(email, "");
            }
        }

    }
    /// <summary>
    /// 
    /// </summary>
    public class UserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserDto(string userNm, string password, string email)
        {
            UserName = userNm;
            Password = password;
            Email = email;
        }
    }
}

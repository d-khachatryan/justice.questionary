using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Web.Security;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AspNetMembershipMgr
{
    /// <summary>
    /// Facade which implements major business logic methods.
    /// </summary>
    public class Facade
    {
        /// <summary>
        /// Connection string for ASPNETDB.
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// List of all the applications in the DB.
        /// </summary>
        public List<string> Apps { get; set; }
        /// <summary>
        /// Initializes the facade instance.
        /// </summary>
        public void Init(string connString)
        {       
            
            ConnectionStringSettings s = new ConnectionStringSettings("Mainnamespace.My.MySettings.SqlConnectionstring", connString);
            string exePath = System.IO.Path.Combine(Environment.CurrentDirectory, "J-Questionary [V3].exe");
            Configuration conf = ConfigurationManager.OpenExeConfiguration(exePath);
            //Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            conf.ConnectionStrings.ConnectionStrings.Clear();
            conf.ConnectionStrings.ConnectionStrings.Add(s);
            conf.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            ConfigurationManager.RefreshSection("system.web");
            
            ConnectionString = connString;    
                    
            try
            {
                // Ensure that Membership and Roles are initialized
                Membership.GetNumberOfUsersOnline();
                Roles.ApplicationName = Membership.ApplicationName;

                string sql = "select distinct ApplicationName from aspnet_Applications";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    Apps = new List<string>();
                    while (r.Read())
                    {
                        Apps.Add(r.GetString(0));
                    }
                    r.Close();
                }
            }
            finally
            {
                //conf.ConnectionStrings.ConnectionStrings.Clear();
                //conf.Save(ConfigurationSaveMode.Modified);
            }
        }
        /// <summary>
        /// Checks whether the given application is already present in the DB.
        /// </summary>
        /// <param name="appName">Name of the application to be checked.</param>
        /// <returns>true if given application if found, else false.</returns>
        internal bool IsAppPresent(string appName)
        {
            string sql = "select count(*) from aspnet_Applications where ApplicationName = @app";
            int appCount = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@app", appName);
                conn.Open();
                appCount = (Int32)cmd.ExecuteScalar();
            }
            return (appCount == 1);
        }
        /// <summary>
        /// Returns all the roles which are present in the given application.
        /// </summary>
        /// <returns>Array of role names.</returns>
        public string[] GetAllRoles()
        {
            return Roles.GetAllRoles();
        }
        /// <summary>
        /// Adds the given role to current application.
        /// </summary>
        /// <param name="roleName">Role to be added.</param>
        public void AddRole(string roleName)
        {
            Roles.CreateRole(roleName);
        }
        /// <summary>
        /// Returns all the users present in current application.
        /// </summary>
        /// <returns>List of user names.</returns>
        public List<string> GetAllUsers()
        {
            List<string> users = new List<string>();
            foreach (MembershipUser u in Membership.GetAllUsers())
            {
                users.Add(u.UserName);
            }
            return users;
        }
        /// <summary>
        /// Removes the given users from current application.
        /// </summary>
        /// <param name="users">List of users to be removed.</param>
        public void RemoveUsers(IEnumerable<string> users)
        {
            foreach(string u in users)
            {
                Membership.DeleteUser(u, true);
            }
        }
    }
}

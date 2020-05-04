using System.Data.SqlClient;
using System.Web.Security;
using Justice.Questionary.Data.StoreDataSetTableAdapters;

namespace Justice.Questionary.Data.StoreDataSetTableAdapters
{
    public partial class vQuestionT1TableAdapter
    {
        public vQuestionT1TableAdapter(SqlConnection connection)
        {
            this.SetConnection(connection);
            this.ClearBeforeFill = true;
        }

        public void SetConnection(SqlConnection connection)
        {
            this._connection = connection;
        }
    }

    public partial class vQuestionT2TableAdapter
    {
        public vQuestionT2TableAdapter(SqlConnection connection)
        {
            this.SetConnection(connection);
            this.ClearBeforeFill = true;
        }

        public void SetConnection(SqlConnection connection)
        {
            this._connection = connection;
        }
    }

    public partial class vQuestionT3TableAdapter
    {
        public vQuestionT3TableAdapter(SqlConnection connection)
        {
            this.SetConnection(connection);
            //this.ClearBeforeFill = true;
        }

        public void SetConnection(SqlConnection connection)
        {
            this._connection = connection;
        }
    }

    public partial class vQuestionXTableAdapter
    {
        public vQuestionXTableAdapter(SqlConnection connection)
        {
            this.SetConnection(connection);
            //this.ClearBeforeFill = true;
        }

        public void SetConnection(SqlConnection connection)
        {
            this._connection = connection;
        }
    }
}

namespace Justice.Questionary.Data
{

    public static class GlobalClass
    {
        public static int IntCommandTimeout = 120;
        public static string UserName;

        public static int checkUserStatus()
        {
            //permission block
            string[] roles = Roles.GetRolesForUser(GlobalClass.UserName);
            int intStatus = 0;
            for (int i = 0; i < roles.Length; i++)
            {
                if (roles[i].ToString() == "manager" || roles[i].ToString() == "administrator")
                {
                    intStatus = 1;
                }
            }
            //permission block
            return intStatus;
        }
    }
}

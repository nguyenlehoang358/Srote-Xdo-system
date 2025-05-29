using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STORE_X.LOGIN
{
    public partial class DatabaseLogin
    {
        private static string connectionString = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=STORE_X;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STORE_X
{
    internal class Connection_Database
    {
        private SqlConnection con;
        private SqlCommand _cmd;
        public SqlCommand CMD { get { return _cmd; } set { _cmd = value; } }
        public SqlConnection Connection { get { return con; } }
        private string error;
        public string Error { get { return error; } set { error = value; } }
        string strcon;
        public Connection_Database()
        {
            strcon = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=STORE_X;Integrated Security=True";
            con = new SqlConnection(strcon);
        }

        public bool openCon()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        public bool closeCon()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using STORE_X.Modify;
using STORE_X.Object;

namespace STORE_X.Ctrl
{
    internal class Customers_BLL
    {
        Customers_DAL Cus_Modify = new Customers_DAL();
        public DataTable getData()
        {
            return Cus_Modify.GetData();
        }

        public bool addData(Customer customer) 
        {
            return Cus_Modify.AddData(customer);
        }

        public bool updataData(Customer customer) 
        {
            return Cus_Modify.UPDATEData(customer);
        }

        public bool deleteData(String IDC) 
        {
            return Cus_Modify.DELETEData(IDC);
        }

    }
}

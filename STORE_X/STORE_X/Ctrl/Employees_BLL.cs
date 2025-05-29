using STORE_X.Modify;
using STORE_X.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STORE_X.Ctrl
{
    internal class Employees_BLL
    {
        Employees_DAL Em_Modify = new Employees_DAL();
        public DataTable getData()
        {
            return Em_Modify.GetData();
        }

        public bool addData(Employee employee)
        {
            return Em_Modify.AddData(employee);
        }

        public bool updataData(Employee employee)
        {
            return Em_Modify.UPDATEData(employee);
        }

        public bool deleteData(String IDE)
        {
            return Em_Modify.DELETEData(IDE);
        }   
    }
}

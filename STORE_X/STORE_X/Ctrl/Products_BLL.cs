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
    internal class Products_BLL
    {
        private Products_DAL products_Modify = new Products_DAL();

        public DataTable GetAllProducts()
        {
            return products_Modify.GetAllProducts();
        }

        public bool AddProduct(Product product) 
        {
            return products_Modify.AddProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return products_Modify.UpdateProduct(product);
        }

        public bool DeleteProduct(int productID)
        {
            return products_Modify.DeleteProduct(productID);
        }
    }
}

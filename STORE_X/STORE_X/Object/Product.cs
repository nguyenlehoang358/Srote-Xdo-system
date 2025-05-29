using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STORE_X.Object
{
    public class Product
    {
        public Product(int productID, string productName, string productImage, string productCompany, string productPrice, int productQuatity)
        {
            ProductID = productID;
            ProductName = productName;
            ProductImage = productImage;
            ProductCompany = productCompany;
            ProductPrice = productPrice;
            ProductQuatity = productQuatity;
        }

        public Product() { }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string ProductCompany { get; set; }
        public string ProductPrice { get; set; }
        public int ProductQuatity { get; set; }
    }
}

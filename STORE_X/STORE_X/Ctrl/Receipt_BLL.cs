using STORE_X.Modify;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STORE_X.Ctrl
{
    public class Receipt_BLL
    {
        private Receipt_DAL receipt_DAL = new Receipt_DAL();

        public DataTable GetAllRECEIPT()
        {
            return receipt_DAL.GetAllRECEIPT();
        }

        public bool AddRECEIPT(DateTime receiptDATE, int receiptQuantity, decimal receiptPrice, int productID)
        {
            if (receiptQuantity <= 0) throw new ArgumentException("Số lượng nhập phải lớn hơn 0.");
            if (receiptPrice <= 0) throw new ArgumentException("Giá nhập phải lớn hơn 0.");
            return receipt_DAL.AddRECEIPT(receiptDATE, receiptQuantity, receiptPrice, productID);
        }

        public bool UpdateRECEIPT(int receiptID, DateTime receiptDATE, int receiptQuantity, decimal receiptPrice, int productID)
        {
            if (receiptQuantity <= 0) throw new ArgumentException("Số lượng nhập phải lớn hơn 0.");
            if (receiptPrice <= 0) throw new ArgumentException("Giá nhập phải lớn hơn 0.");
            return receipt_DAL.UpdateRECEIPT(receiptID, receiptDATE, receiptQuantity, receiptPrice, productID);
        }

        public bool DeleteRECEIPT(int receiptID)
        {
            return receipt_DAL.DeleteRECEIPT(receiptID);
        }
    }
}

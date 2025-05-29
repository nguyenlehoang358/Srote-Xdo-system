using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STORE_X.Object;

namespace STORE_X.Modify
{
    public class Receipt_DAL
    {
        private DatabaseStore databaseStore = new DatabaseStore();

        public DataTable GetAllRECEIPT()
        {
            string query = "SELECT * FROM RECEIPT";
            return databaseStore.ExecuteQuery(query);
        }

        public bool AddRECEIPT(DateTime receiptDATE, int receiptQuantity, decimal receiptPrice, int productID)
        {
            string query = "INSERT INTO RECEIPT (ReceiptDATE, ReceiptQuantity, ReceiptPrice, ProductID) VALUES (@ReceiptDATE, @ReceiptQuantity, @ReceiptPrice, @ProductID)";
            SqlParameter[] parameters = {
            new SqlParameter("@ReceiptDATE", receiptDATE),
            new SqlParameter("@ReceiptQuantity", receiptQuantity),
            new SqlParameter("@ReceiptPrice", receiptPrice),
            new SqlParameter("@ProductID", productID)
        };
            return databaseStore.ExecuteQuery(query, parameters).Rows.Count > 0;
        }

        public bool UpdateRECEIPT(int receiptID, DateTime receiptDATE, int receiptQuantity, decimal receiptPrice, int productID)
        {
            string query = "UPDATE RECEIPT SET ReceiptDATE = @ReceiptDATE, ReceiptQuantity = @ReceiptQuantity, ReceiptPrice = @ReceiptPrice, ProductID = @ProductID WHERE ReceiptID = @ReceiptID";
            SqlParameter[] parameters = {
            new SqlParameter("@ReceiptDATE", receiptDATE),
            new SqlParameter("@ReceiptQuantity", receiptQuantity),
            new SqlParameter("@ReceiptPrice", receiptPrice),
            new SqlParameter("@ProductID", productID),
            new SqlParameter("@ReceiptID", receiptID)
        };
            return databaseStore.ExecuteQuery(query, parameters).Rows.Count > 0;
        }

        public bool DeleteRECEIPT(int receiptID)
        {
            string query = "DELETE FROM RECEIPT WHERE ReceiptID = @ReceiptID";
            SqlParameter[] parameters = { new SqlParameter("@MaPhieuNhap", receiptID) };
            return databaseStore.ExecuteQuery(query, parameters).Rows.Count > 0;
        }
    }
}

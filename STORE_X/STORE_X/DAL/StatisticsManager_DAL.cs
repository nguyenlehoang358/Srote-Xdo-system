using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STORE_X.Modify
{
    public class StatisticsManager_DAL
    {
        private DatabaseStore databaseStore = new DatabaseStore();

        public DataTable GetProductImportStatistics()
        {
            string query = "SELECT ProductID, SUM(ReceiptQuantity) AS TotalQuantity FROM RECEIPT GROUP BY ProductID";
            return databaseStore.ExecuteQuery(query);
        }

        public DataTable GetRevenueStatistics(string period)
        {
            string query = "";
            if (period == "day")
            {
                query = "SELECT i.InvoiceSoldDate AS NgayBanHang, SUM(id.InvoiceTotal) AS TongDoanhThu FROM dbo.INVOICEDetail id JOIN dbo.INVOICE i ON id.InvoiceID = i.InvoiceID GROUP BY i.InvoiceSoldDate ORDER BY NgayBanHang;)";
            }
            else if (period == "month")
            {
                query = "SELECT YEAR(i.InvoiceSoldDate) AS Nam, MONTH(i.InvoiceSoldDate) AS Thang, SUM(id.InvoiceTotal) AS TongDoanhThu FROM dbo.INVOICEDetail id JOIN dbo.INVOICE i ON id.InvoiceID = i.InvoiceID GROUP BY YEAR(i.InvoiceSoldDate), MONTH(i.InvoiceSoldDate) ORDER BY Nam, Thang;)";
            }
            else if (period == "year")
            {
                query = "SELECT YEAR(i.InvoiceSoldDate) AS Nam, SUM(id.InvoiceTotal) AS TongDoanhThu FROM dbo.INVOICEDetail id JOIN dbo.INVOICE i ON id.InvoiceID = i.InvoiceID GROUP BY YEAR(i.InvoiceSoldDate) ORDER BY Nam;)";
            }
            return databaseStore.ExecuteQuery(query);
        }

        public DataTable GetProfitStatistics()
        {
            string query = "SELECT p.ProductID AS MaSanPham, p.ProductName AS TenSanPham, SUM(r.ReceiptQuantity) AS TongSoLuongNhap FROM dbo.RECEIPT r JOIN dbo.PRODUCTS p ON r.ProductID = p.ProductID GROUP BY p.ProductID, p.ProductName ORDER BY TongSoLuongNhap DESC;";
            return databaseStore.ExecuteQuery(query);
        }

        public DataTable GetInvoiceDetails()
        {
            string query = "SELECT p.ProductID AS MaSanPham, p.ProductName AS TenSanPham, SUM(id.InvoiceTotal) - SUM(r.ReceiptQuantity * r.ReceiptPrice) AS LoiNhuan FROM dbo.INVOICEDetail id JOIN dbo.PRODUCTS p ON id.ProductID = p.ProductID LEFT JOIN dbo.RECEIPT r ON p.ProductID = r.ProductID GROUP BY p.ProductID, p.ProductName ORDER BY LoiNhuan DESC;";
            /*SqlParameter[] parameters = { new SqlParameter("@InvoiceID", invoiceId) };*/
            return databaseStore.ExecuteQuery(query); /*, parameters);*/
        }

        public DataTable GetInvoiceInfo()
        {
            string query = "SELECT e.EmployeesID AS MaNhanVien, e.EmployeeName AS TenNhanVien, SUM(id.InvoiceTotal) - SUM(r.ReceiptQuantity * r.ReceiptPrice) AS LoiNhuan FROM dbo.INVOICEDetail id JOIN dbo.INVOICE i ON id.InvoiceID = i.InvoiceID JOIN dbo.EMPLOYEES e ON i.EmployeesID = e.EmployeesID LEFT JOIN dbo.RECEIPT r ON id.ProductID = r.ProductID GROUP BY e.EmployeesID, e.EmployeeName ORDER BY LoiNhuan DESC;";
            /*SqlParameter[] parameters = { new SqlParameter("@InvoiceID", invoiceId) };*/
            return databaseStore.ExecuteQuery(query);
        }
    }
}

using QuanLyBanXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return CustomerDAO.instance;
            }
            private set
            {
                CustomerDAO.instance = value;
            }
        }
        private CustomerDAO() { }

        public List<Customer> getCustomerByCMND(int CMND,string Name)
        {
            List<Customer> list = new List<Customer>();

            string query = string.Format("SELECT * FROM dbo.KhachHang WHERE CMND = {0} AND TenKH = N'{1}'",CMND,Name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }

            return list;
        }
        public bool EditCustomer(string TenKH, string NgaySinnh, string CMND, string SDT, string DiaChi, string HoKhau)
        {
            string query = string.Format("EXECUTE dbo.USP_Edit_ThongTinKhachHang @TenKH = N'{0}' , @DiaChiKH = N'{1}' , @HoKhauKH = N'{2}' , @SDT = {3} , @CMND = {4} , @NgaySinh = '{5}'",TenKH, DiaChi, HoKhau, SDT, CMND, NgaySinnh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<Customer> getListCustomer()
        {
            List<Customer> list = new List<Customer>();

            string query = "SELECT * FROM dbo.KhachHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }

            return list;
        }

    }
      
}

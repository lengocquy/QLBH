using QuanLyBanXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return KhachHangDAO.instance;
            }
            private set
            {
                KhachHangDAO.instance = value;
            }
        }

        public List<KhachHang> getListTenKH()
        {
            List<KhachHang> list = new List<KhachHang>();

            string query = "SELECT TenKH FROM dbo.KhachHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang KH = new KhachHang(item,0);
                list.Add(KH);
            }

            return list;
        }

        public List<KhachHang> getListKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();

            string query = "SELECT * FROM dbo.KhachHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang KH = new KhachHang(item);
                list.Add(KH);
            }

            return list;
        }

     
    }
}

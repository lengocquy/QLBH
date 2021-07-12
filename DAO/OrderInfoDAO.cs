using QuanLyBanXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DAO
{
    public class OrderInfoDAO
    {
        private static OrderInfoDAO instance;


        public static OrderInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderInfoDAO();
                return instance;
            }
            private set
            {
                OrderInfoDAO.instance = value;
            }
        }

        private OrderInfoDAO() { }

        public List<OrderInfo> getListOrderInfo()
        {
            List<OrderInfo> list = new List<OrderInfo>();

            string query = "SELECT * FROM dbo.view_Order";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            foreach (DataRow item in data.Rows)
            {
                OrderInfo orderInfo = new OrderInfo(item);
                list.Add(orderInfo);
            }

            return list;
        }

        public bool EditOrderInfo(string TenKH,string NgaySinnh,string NgayBan,string CMND,string SDT,string DiaChi,string HoKhau,string TenXe,string TenDongXe,string MauXe,double Thanhtien)
        {
            string query = string.Format("EXECUTE dbo.USP_Edit_ThongTinHoaDonVaThongTinKhachHang @Tenxe = N'{0}',  @TenDongXe = N'{1}', @Mauxe = N'{2}', @Thanhtien = {3} , @TenKH = N'{4}' , @DiaChiKH = N'{5}' , @HoKhauKH = N'{6}' , @SDT = {7} , @CMND = {8} , @NgaySinh = '{9}' , @NgayBan = '{10}'",TenXe,TenDongXe,MauXe,Thanhtien,TenKH,DiaChi,HoKhau,SDT,CMND,NgaySinnh,NgayBan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<OrderInfo> SearchOrderByTenKH(string name)
        {
            List<OrderInfo> list = new List<OrderInfo>();

            string query = string.Format("SELECT * FROM dbo.view_Order WHERE dbo.fuConvertToUnsign1(TenKH) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            foreach (DataRow item in data.Rows)
            {
                OrderInfo orderInfo = new OrderInfo(item);
                list.Add(orderInfo);
            }

            return list;
        }


        // mũa thôi. chứ sài getlistorderinfo được
        public List<OrderInfo> getListOrderInfoBydate(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            //string query = string.Format("EXECUTE dbo.USP_ThongKe @NgayBatDau = {0} ,  @NgayKetThua = {1}", NgayBatDau,NgayKetThuc);           
            //return DataProvider.Instance.ExecuteQuery(query);

            //return DataProvider.Instance.ExecuteQuery("EXECUTE dbo.USP_ThongKe @NgayBatDau , @NgayKetThuc", new object[] { NgayBatDau,NgayKetThuc});

            List<OrderInfo> list = new List<OrderInfo>();
            
            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE dbo.USP_ThongKe @NgayBatDau , @NgayKetThuc", new object[] { NgayBatDau, NgayKetThuc });


            foreach (DataRow item in data.Rows)
            {
                OrderInfo orderInfo = new OrderInfo(item);
                list.Add(orderInfo);
            }

            return list;

        }
        
    }

   
}

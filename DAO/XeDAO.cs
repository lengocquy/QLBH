using QuanLyBanXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DAO
{
    public class XeDAO
    {
        private static XeDAO instance;

        public static XeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new XeDAO();
                return XeDAO.instance;
            }
            private set
            {
                XeDAO.instance = value;
            }
        }

        public List<Xe> getListXe()
        {
            List<Xe> list = new List<Xe>();

            string query = "SELECT * FROM dbo.Xe";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe xe = new Xe(item);
                list.Add(xe);
            }
            return list;
        }

        public List<Xe> getListXeByDongXeId(int id)
        {
            List<Xe> list = new List<Xe>();

            //string query = "SELECT * FROM dbo.Xe  WHERE idDongXe = " + id;

            string query = "SELECT TenXe FROM dbo.Xe WHERE idDongXe = " + id + " GROUP BY TenXe";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe xe = new Xe(item,0);
                list.Add(xe);
            }

            return list;        
        }

        public List<Xe> getListXeByTenXe(string TenXe,int id)
        {
            List<Xe> list = new List<Xe>();
            string query = "SELECT * FROM dbo.Xe WHERE TenXe = N'" + TenXe + "' AND idDongXe = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe xe = new Xe(item);
                list.Add(xe);
            }
            return list;
        }

        public List<Xe> getListThanhTienByMau(string Mau, int id,string TenXe)
        {
            List<Xe> list = new List<Xe>();
            string query = "SELECT * FROM dbo.Xe WHERE TenXe = N'" + TenXe + "' AND idDongXe = " + id + " AND MauXe = N'" + Mau + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe xe = new Xe(item);
                list.Add(xe);
            }

            return list;
        }

        // chỉnh sửa datatime data thành tring date
        public bool Inser(string TenKH,string date,string DiaChi,int CMND,int SDT,string HoKhau,string TenXe,string mauXe,double thanhTien,int idDongXe)
        {
            string query = string.Format("EXECUTE dbo.USP_ThemDH_And_HoaDon @TenKH = N'{0}', @NgaySinh = '{1}',@DiaChi = N'{2}',@CMND = {3}, @SDT = {4},@HoKhau = N'{5}',@Tenxe = N'{6}',@mauXe = N'{7}',@ThanhTien = {8},@IdDoongXe = {9}",TenKH,date,DiaChi,CMND,SDT,HoKhau,TenXe,mauXe,thanhTien,idDongXe);         
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InserWHenAvailableIDKH(string TenXe, string mauXe, double thanhTien, int idDongXe,int IDKH)
        {
            string query = string.Format("EXEC dbo.USP_ThemDH_And_HoaDon_Khi_Co_IDKH @Tenxe = N'{0}',@mauXe = N'{1}',@ThanhTien = {2}, @IdDoongXe = {3},@IdKH = {4} ",TenXe,mauXe,thanhTien,idDongXe,IDKH );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Xe> IsQuantityZero(string tenxe, string mauxe, double giatien, int id)
        {
            List<Xe> list = new List<Xe>();
            //string query = string.Format("SELECT * FROM dbo.Xe,dbo.DongXe WHERE TenXe = N'{0}' AND MauXe = N'{1}' AND ThanhTien = {2} AND idDongXe = {3} GROUP BY SoLuong", tenxe, mauxe, giatien, id);
            string query = string.Format("SELECT * FROM dbo.Xe WHERE TenXe = N'{0}' AND ThanhTien = {1} AND idDongXe = {2} AND MauXe = N'{3}'",tenxe,giatien,id,mauxe);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe xe = new Xe(item);
                list.Add(xe);
            }

            return list;
        }

        public List<Xe> getListXeByDongXeName(string Name,int id)
        {
            List<Xe> list = new List<Xe>();


            string query = "SELECT X.TenXe FROM dbo.Xe AS X,dbo.DongXe AS Dx WHERE x.idDongXe = " + id + " AND Dx.TenDongXe = N'" + Name + "' GROUP BY X.TenXe";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe xe = new Xe(item,1);
                list.Add(xe);
            }

            return list;
        }
    }
}

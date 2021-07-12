using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DTO
{
    public class Xe
    {
        public Xe(int id, string tenxe,string mauxe,int thanhtien,int iddongxe,int soluong)
        {
            this.ID = id;
            this.TenXe = tenxe;
            this.MauXe = mauxe;
            this.ThanhTien = thanhTien;
            this.IDDongXe = iddongxe;
            this.SoLuong = soluong;
        }
        public Xe(DataRow row,int i)
        {
            this.TenXe = row["TenXe"].ToString();
        }
        public Xe(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TenXe = row["TenXe"].ToString();
            this.MauXe = row["MauXe"].ToString();
            this.ThanhTien = (float)(Convert.ToDouble(row["ThanhTien"].ToString()));
            this.IDDongXe = (int)row["idDongXe"];
            this.SoLuong = (int)row["SoLuong"];
        }

        private int iD;
        private string tenXe;
        private string mauXe;
        private float thanhTien;
        private int iDDongXe;
        private string tinhTrang;
        private int soLuong;
        private int namSX;
        private int soGhe;
        private string hopSo;

        public int ID { get ; set ; }
        public string TenXe { get ; set ; }
        
        public float ThanhTien { get ; set ; }
        public int IDDongXe { get ; set ; }
        public string MauXe { get ; set ; }
        public string TinhTrang { get ; set ; }
        public int SoLuong { get ; set ; }
        public int NamSX { get ; set ; }
        public int SoGhe { get ; set ; }
        public string HopSo { get ; set ; }
    }
}

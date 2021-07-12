using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DTO
{
    public class OrderInfo
    {
        private string tenKH;
        private string cMND;
        private string dongXe;
        private string tenXe;
        private string mauXe;

        private double thanhTien;

        private DateTime ngayLap;

        public string TenKH { get ; set ; }
        public string CMND { get ; set ; }
        public string DongXe { get ; set ; }
        public string TenXe { get ; set ; }
        public string MauXe { get ; set ; }
        public double ThanhTien { get ; set ; }
        public DateTime NgayLap { get ; set ; }
        

        public OrderInfo(DataRow row)
        {
            this.TenKH = row["TenKH"].ToString();
            this.CMND = row["CMND"].ToString();
            this.DongXe = row["TenDongXe"].ToString();
            this.TenXe = row["TenXe"].ToString();
            this.MauXe = row["MauXe"].ToString();
            //this.ThanhTien = (float)(Convert.ToDouble(row["ThanhTien"].ToString()));
            this.ThanhTien = Convert.ToDouble(row["ThanhTien"]);
        
            this.NgayLap = (DateTime)row["NgayBan"];
        }

        public OrderInfo(string tenKH, string cmnd,string dongXe,string tenXe, string mauXe, float thanhTien,DateTime ngayBan)
        {
            this.TenKH = TenKH;
            this.CMND = cmnd;
            this.DongXe = dongXe;
            this.TenXe = tenXe;
            this.MauXe = mauXe;
    
            this.ThanhTien = thanhTien;
            this.NgayLap = ngayBan;
        }
    }
}

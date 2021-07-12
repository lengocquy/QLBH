using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DTO
{
    public class KhachHang
    {
        private int iD;
        private string name;
        private string address;
        private int sDT;
        private string hoKhau;
        private int cMND;
        private DateTime brithDate;

        public int ID { get ; set ; }
        public string Name { get; set ; }
        public string Address { get ; set; }
        public int SDT { get ; set ; }
        public string HoKhau { get ; set ; }
        public int CMND { get ; set ; }
        public DateTime BrithDate { get ; set ; }



        public KhachHang(int id,string name,string address,int sdt,string hokhau,int cmnd,DateTime brithdate)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.SDT = sdt;
            this.HoKhau = hokhau;
            this.CMND = cmnd;
            this.BrithDate = brithdate;
        }

        public KhachHang(DataRow row,int i)
        {
            this.Name = row["TenKH"].ToString();
        }

        public KhachHang(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["TenKH"].ToString();
            this.Address = row["DiaChi"].ToString();
            this.SDT = (int)row["SDT"];
            this.HoKhau = row["HoKhau"].ToString();
            this.CMND = (int)row["CMND"];
            this.BrithDate = (DateTime)row["NgaySinh"];
        }

    }
}

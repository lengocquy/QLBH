using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DTO
{
    public class Customer
    {
        private string name;
        private int cMND;
        private DateTime birthDate;
        private string address;        
        private string hoKhau;
        private int sDT;

        public string Name { get ; set ; }
        public int CMND { get ; set ; }
        public DateTime BirthDate { get ;set; }
        public int SDT { get ; set ; }
        public string HoKhau { get ; set; }
        public string Address { get ; set ; }
        


        public Customer(string name,int cmnd, DateTime birthDate,string address,string hoKhau,int sdt)
        {
            this.Name = name;
            this.CMND = cmnd;
            this.BirthDate = birthDate;
            this.Address = address;
            this.HoKhau = hoKhau;
            this.SDT = sdt;
        }

        public Customer(DataRow row)
        {
            this.Name = row["TenKH"].ToString();
            this.CMND = (int)row["CMND"];
            this.BirthDate = (DateTime)row["NgaySinh"];
            this.Address = row["DiaChi"].ToString();
            this.HoKhau = row["HoKhau"].ToString();
            this.SDT = (int)row["SDT"];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DTO
{
    public class DongXe
    {
        public DongXe(int id,string tendongxe)
        {
            this.ID = id;
            this.TenDongXe = tendongxe;
        }
        
        public DongXe(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TenDongXe = row["TenDongXe"].ToString();
        }
        private string tenDongXe;


        private int iD;

        public int ID { get ; set; }
        public string TenDongXe { get ; set ; }
    }
}

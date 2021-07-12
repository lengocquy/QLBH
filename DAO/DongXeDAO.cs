using QuanLyBanXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DAO
{
    class DongXeDAO
    {
        private static DongXeDAO instance;

        public static DongXeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DongXeDAO();
                return DongXeDAO.instance;
            }
            private set
            {
                DongXeDAO.instance = value;
            }
        }
        private DongXeDAO() { }

        public List<DongXe> GetListDongXe()
        {
 
            List<DongXe> list = new List<DongXe>();

            string query = "SELECT * FROM dbo.DongXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DongXe dongXe = new DongXe(item);
                list.Add(dongXe);
            }

            return list;
        }
   
 
    }
}

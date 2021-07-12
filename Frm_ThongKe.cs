using QuanLyBanXe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanXe
{
    public partial class Frm_ThongKe : Form
    {
        public Frm_ThongKe()
        {
            InitializeComponent();
            loadDateTimePicker();
            loadOrderInfo();
        }

        #region Method

        void loadOrderInfo()
        {
            dtgwOrderThongKe.DataSource = OrderInfoDAO.Instance.getListOrderInfo();
        }

        void loadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year,today.Month,1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void loadListOrderInfoByDate(DateTime NgayBatDau,DateTime NgayKetThuc)
        {
            dtgwOrderThongKe.DataSource = OrderInfoDAO.Instance.getListOrderInfoBydate(NgayBatDau, NgayKetThuc);
        }
        #endregion


        #region Event

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            loadListOrderInfoByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        #endregion

        private void dtgwOrderThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}

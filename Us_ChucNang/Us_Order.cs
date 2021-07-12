using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanXe.DTO;
using QuanLyBanXe.DAO;

namespace QuanLyBanXe.Us_ChucNang
{
    public partial class Us_Order : UserControl
    {
        public Us_Order()
        {
            InitializeComponent();
            
            load();
        }


        #region Method
        void load()
        {
            loadDataOrder();
            addListTenKHToTextboxSearch();
        }
        public void loadDataOrder()
        {
            List<OrderInfo> orderInfos = OrderInfoDAO.Instance.getListOrderInfo();
            dtgwOrder.DataSource = orderInfos;

        }

        List<OrderInfo> SearchOrderByTenKH(string name)
        {
            List<OrderInfo> list = OrderInfoDAO.Instance.SearchOrderByTenKH(name);

            return list;
        }

        void addListTenKHToTextboxSearch()
        {
            List<KhachHang> list = KhachHangDAO.Instance.getListTenKH();
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (KhachHang item in list)
            {
                data.Add(item.Name);
            }
            tbxSearch.AutoCompleteCustomSource = data;
        }


        #endregion

        #region Evetn


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (Frm_ThongKe fr = new Frm_ThongKe())
            {
                fr.ShowDialog();
            }
        }
        private void btnSeeDetailOrder_Click(object sender, EventArgs e)
        {
            if (SaveOrderInfo.isChecked != true)
            {
                MessageBox.Show("mày chưa chọn click cái cc", "Trửi óc chó", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (Frm_SeeOrderDetail fr = new Frm_SeeOrderDetail())
            {
                List<Customer> customers = CustomerDAO.Instance.getCustomerByCMND(Convert.ToInt32(SaveOrderInfo.CMND), SaveOrderInfo.Name);

                fr.tbxTenKH.Text = SaveOrderInfo.Name;
                fr.dtpkNgaySinh.DataBindings.Add(new Binding("Value", customers, "BirthDate", true, DataSourceUpdateMode.Never));
                fr.tbxDiaChi.DataBindings.Add(new Binding("Text", customers, "Address", true, DataSourceUpdateMode.Never));
                fr.tbxHoKhau.DataBindings.Add(new Binding("Text", customers, "HoKhau", true, DataSourceUpdateMode.Never));
                fr.tbxSDT.DataBindings.Add(new Binding("Text", customers, "SDT", true, DataSourceUpdateMode.Never));
                fr.tbxCMND.Text = SaveOrderInfo.CMND;
                fr.cbxDongXe.Text = SaveOrderInfo.DongXe;
                fr.cbxTenXe.Text = SaveOrderInfo.TenXe;
                fr.cbxMauXe.Text = SaveOrderInfo.Mau;
                fr.dtpkNgayBan.Text = SaveOrderInfo.NgayBan;
                fr.ShowDialog();

                loadDataOrder();
            }

            
            

            

        }

        private void dtgwOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SaveOrderInfo.isChecked = true;


            int index = dtgwOrder.CurrentRow.Index;

            SaveOrderInfo.Name = dtgwOrder.Rows[index].Cells[0].Value.ToString();
            SaveOrderInfo.CMND = dtgwOrder.Rows[index].Cells[1].Value.ToString();
            SaveOrderInfo.DongXe = dtgwOrder.Rows[index].Cells[2].Value.ToString();
            SaveOrderInfo.TenXe = dtgwOrder.Rows[index].Cells[3].Value.ToString();
            SaveOrderInfo.Mau = dtgwOrder.Rows[index].Cells[4].Value.ToString();
            SaveOrderInfo.ThanhTien = dtgwOrder.Rows[index].Cells[5].Value.ToString();
            SaveOrderInfo.NgayBan = dtgwOrder.Rows[index].Cells[6].Value.ToString();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataOrder();
        }


        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                tbxSearch.Text = "Tìm kiếm theo tên khách hàng";
                tbxSearch.ForeColor = Color.Silver;
            }
        }

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "Tìm kiếm theo tên khách hàng")
            {
                tbxSearch.Text = "";
                tbxSearch.ForeColor = Color.White;
            }
        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            dtgwOrder.DataSource = SearchOrderByTenKH(tbxSearch.Text);

            if (tbxSearch.Text == "")
            {
                loadDataOrder();
            }
        }

        #endregion


    }
}

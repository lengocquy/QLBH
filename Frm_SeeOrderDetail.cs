using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;
using QuanLyBanXe.Us_ChucNang;
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
    public partial class Frm_SeeOrderDetail : Form
    {
        

        public Frm_SeeOrderDetail()
        {
            InitializeComponent();

            load();

            

           
        }

        #region Method
        void load()
        {
            loadTenDongXE();           
        }
        
        void loadTenDongXE()
        {
            List<DongXe> dongXe = DongXeDAO.Instance.GetListDongXe();
            cbxDongXe.DataSource = dongXe.ToList();
            cbxDongXe.DisplayMember = "TenDongXe";
        }
        void getListTenXeByDongXeID(int id)
        {
            List<Xe> listXe = XeDAO.Instance.getListXeByDongXeId(id);
            cbxTenXe.DataSource = listXe.ToList();
            cbxTenXe.DisplayMember = "TenXe";
        }
        void getListMauXeByTenXe(string TenXe, int id)
        {
            List<Xe> listMau = XeDAO.Instance.getListXeByTenXe(TenXe, id);
            cbxMauXe.DataSource = listMau.ToList();
            cbxMauXe.DisplayMember = "MauXe";
            
        }
        void getListThanhTienByMau(string Mau, int id, string TenXe)
        {
            List<Xe> listTien = XeDAO.Instance.getListThanhTienByMau(Mau, id, TenXe);
            cbxThanhTien.DataSource = listTien.ToList();
            cbxThanhTien.DisplayMember = "ThanhTien";
        }


      
  
        #endregion

        #region Event

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxDongXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cbx = sender as ComboBox;

            if (cbx.SelectedItem == null)
                return;

            DongXe selected = cbx.SelectedItem as DongXe;

            id = selected.ID;


            getListTenXeByDongXeID(id);
        }

        private void cbxTenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TenXe;
            int id = 0;
            ComboBox cbx = sender as ComboBox;

            if (cbx.SelectedItem == null)
                return;

            Xe selected = cbx.SelectedItem as Xe;

            id = (cbxDongXe.SelectedItem as DongXe).ID;
            TenXe = selected.TenXe.ToString();


            getListMauXeByTenXe(TenXe, id);
        }

        private void cbxMauXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            string tenMau;
            string ten;
            ComboBox cbx = sender as ComboBox;

            if (cbx.SelectedItem == null)
                return;

            Xe selected = cbx.SelectedItem as Xe;
            tenMau = selected.MauXe;
            id = selected.IDDongXe;
            ten = selected.TenXe;
            getListThanhTienByMau(tenMau, id, ten);
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            FunctionProcessing.DeleteSpaceExcessInTextbox(tbxDiaChi);
            FunctionProcessing.DeleteSpaceExcessInTextbox(tbxHoKhau);

            string TenKH = tbxTenKH.Text;
            string CMND = tbxCMND.Text;
            string NgaySinh = dtpkNgaySinh.Value.ToString("MM/dd/yyyy");
            string DiaChi = tbxDiaChi.Text;
            string HoKhau = tbxHoKhau.Text;
            string SDT = tbxSDT.Text;
            string DongXe = (cbxDongXe.SelectedItem as DongXe).TenDongXe;
            string TenXe = (cbxTenXe.SelectedItem as Xe).TenXe;
            string MauXe = (cbxMauXe.SelectedItem as Xe).MauXe;
            string NgayBan = dtpkNgayBan.Value.ToString("MM/dd/yyyy");
            double Thanhtien = (cbxThanhTien.SelectedItem as Xe).ThanhTien;
            int ID = (cbxDongXe.SelectedItem as DongXe).ID;

            if (FunctionProcessing.IsQuantityZero(TenXe, MauXe, Thanhtien, ID) <= 0)
            {
                MessageBox.Show("Hiện tại trong kho đã tạm hết xe", "Thông báo");
                return;
            }
            if (OrderInfoDAO.Instance.EditOrderInfo(TenKH, NgaySinh, NgayBan, CMND, SDT, DiaChi, HoKhau, TenXe, DongXe, MauXe, Thanhtien))
            {
                MessageBox.Show("Bạn thêm đếu thành công");
                this.Close();  
            }
            else
            {
                MessageBox.Show("Lỗi CMNR");
            }
        }

        private void tbxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionProcessing.OnlyNumber(e);
        }

        private void tbxCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionProcessing.OnlyNumber(e);
        }

        #endregion

    }
}

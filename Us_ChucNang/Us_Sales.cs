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
using System.Drawing.Printing;

namespace QuanLyBanXe.Us_ChucNang
{
    public partial class Us_Sales : UserControl
    {      
        public Us_Sales()
        {
            InitializeComponent();

            load();
        }

        #region Mothod

        void load()
        {
            loadTenDongXE();
           
        }

        void loadLaiPage()
        {
            load();
            tbxCMND.Text = "";
            tbxDiaChi.Text = "";
            tbxHoKhau.Text = "";
            tbxSDT.Text = "";
            tbxTenKH.Text = "";
            dtpkNgaySinh.Value = DateTime.Now;
        }



        void inserDonHang(string Name, string BirthDate, string Address,string HoKhau,int CMND,int SDT,string DongXe,string TenXe,string MauXe,float GiaTien,int ID)
        {
            int IDKH = 0;
            if (IsKhachHangContainsInDatabase(Name, SDT, CMND, Address, HoKhau, BirthDate, ref IDKH))
            {
                if (XeDAO.Instance.InserWHenAvailableIDKH(TenXe, MauXe, GiaTien, ID, IDKH))
                {
                    MessageBox.Show("Huy yêu thư lắm LOL LOL LOL");
                    loadLaiPage();
                }
                else
                {
                    MessageBox.Show("thư đếu yêu huy");
                }
            }
            else
            {
                if (XeDAO.Instance.Inser(Name, BirthDate, Address, CMND, SDT, HoKhau, TenXe, MauXe, GiaTien, ID))
                {
                    MessageBox.Show("Huy yêu thư lắm");
                    loadLaiPage();
                }
                else
                {
                    MessageBox.Show("thư đếu yêu huy");
                }
            }
            
        }

        void loadTenDongXE()
        {
            List<DongXe> dongXe = DongXeDAO.Instance.GetListDongXe();
            cbxDongXe.DataSource = dongXe;
            cbxDongXe.DisplayMember = "TenDongXe";
            
        }

        void getListTenXeByDongXeID(int id)
        {
            List<Xe> listXe = XeDAO.Instance.getListXeByDongXeId(id);
         
            cbxTenXe.DataSource = listXe.ToList();

            if (listXe.Count == 0)
            {
                cbxTenXe.Text = "";
                cbxMauXe.Text = "";
                cbxThanhTien.Text = "";
            }
            cbxTenXe.DisplayMember = "TenXe";
        }

        void getListMauXeByTenXe(string TenXe,int id)
        {
            List<Xe> listMau = XeDAO.Instance.getListXeByTenXe(TenXe,id);
            cbxMauXe.DataSource = listMau.ToList();


            cbxMauXe.DisplayMember = "MauXe";
        }

        void getListThanhTienByMau(string Mau,int id,string TenXe)
        {
            List<Xe> listTien = XeDAO.Instance.getListThanhTienByMau(Mau, id, TenXe);
            cbxThanhTien.DataSource = listTien.ToList();


            cbxThanhTien.DisplayMember = "ThanhTien";
        }
     

        bool IsKhachHangContainsInDatabase(string Name,int SDT,int CMND,string Address,string HoKhau,string Birthdate,ref int IDKH)
        {
            List<KhachHang> list = KhachHangDAO.Instance.getListKhachHang();
            
            foreach (KhachHang item in list)
            {
                if (item.Name == Name && item.HoKhau == HoKhau && item.SDT == SDT && item.CMND == CMND && item.Address == Address && item.BrithDate.ToString("MM/dd/yyyy") == Birthdate)
                {
                    IDKH = item.ID;
                    return true;
                }
            }
            return false;


        }

       

        #endregion

        #region Event


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
            getListThanhTienByMau(tenMau,id, ten);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!FunctionProcessing.IsInputNotNullInTextBox(tbxCMND,tbxHoKhau,tbxDiaChi,tbxSDT,tbxTenKH))
            {
                MessageBox.Show("CMM Nhập vào dữ liệu đi");
                return;
            }

            // khách hàng 
            FunctionProcessing.DeleteSpaceExcessInTextbox(tbxTenKH);
            FunctionProcessing.DeleteSpaceExcessInTextbox(tbxDiaChi);
            FunctionProcessing.DeleteSpaceExcessInTextbox(tbxHoKhau);
            string Name = tbxTenKH.Text.Trim();
            string BirthDate = dtpkNgaySinh.Value.ToString("MM/dd/yyyy"); // chỉnh sửa từ date thành string
            string Address = tbxDiaChi.Text;
            string HoKhau = tbxHoKhau.Text;
            int CMND = Convert.ToInt32(tbxCMND.Text);
            int SDT = Convert.ToInt32(tbxSDT.Text);

            // Thông tin xe
            string DongXe = (cbxDongXe.SelectedItem as DongXe).TenDongXe;
            string TenXe = (cbxTenXe.SelectedItem as Xe).TenXe;
            string MauXe = (cbxMauXe.SelectedItem as Xe).MauXe;
            float GiaTien = (cbxThanhTien.SelectedItem as Xe).ThanhTien;
            int ID = (cbxDongXe.SelectedItem as DongXe).ID;

            
            if (FunctionProcessing.IsQuantityZero(TenXe, MauXe, GiaTien, ID) <= 0)
            {
                MessageBox.Show("Hiện tại trong kho đã tạm hết xe", "Thông báo");
                loadLaiPage();
                return;
            }

            inserDonHang(Name, BirthDate, Address, HoKhau, CMND, SDT, DongXe, TenXe, MauXe, GiaTien, ID);

           
        }

        private void tbxCMND_KeyPress(object sender, KeyPressEventArgs e)
        {          
            FunctionProcessing.OnlyNumber(e);
        }

        private void tbxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionProcessing.OnlyNumber(e);
        }

        private void tbxTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionProcessing.OnlyString(e);

        }




        #endregion

    }
}

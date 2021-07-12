using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanXe.FormChild
{
    public partial class Frm_Customer_Child_Us_Staff : Form
    {
        DataProvider DP ;
        public Frm_Customer_Child_Us_Staff()
        {
            InitializeComponent();

        }

        #region Method

        void GetListCustomer()
        {
            List<Customer> list = CustomerDAO.Instance.getListCustomer();

            dtgwCustomer.DataSource = list;

        }



        #endregion




        #region Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion();

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string TenKH = textBox1.Text;
            string CMND = textBox2.Text;
            string NgaySinh = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string DiaChi = textBox5.Text;
            string HoKhau = textBox6.Text;
            string SDT = textBox3.Text;
            string query = "SELECT CMND FROM KhachHang WHERE CMND = '" + CMND + "'";
            SqlDataReader dr = DataProvider.Instance.myExecuteReader(query);
            //string connectionStr = @"Data Source=.\SQLEXPRESSR;Initial Catalog=QuanLyBanXeOTO;Integrated Security=True";
            //SqlConnection cn = new SqlConnection(connectionStr);
            //SqlCommand cmd = new SqlCommand(query,cn);
            //cn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Trùng CMND rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.Instance.Disconnect();
            }
            else if (CustomerDAO.Instance.EditCustomer(TenKH, NgaySinh, CMND, SDT, DiaChi, HoKhau))
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            //cn.Close();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dtgwCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Customer_Child_Us_Staff_Load(object sender, EventArgs e)
        {
            GetListCustomer();
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dtgwCustomer.DataSource, "Name");
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dtgwCustomer.DataSource, "CMND");
            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dtgwCustomer.DataSource, "SDT");
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", dtgwCustomer.DataSource, "BirthDate");
            textBox5.DataBindings.Clear();
            textBox5.DataBindings.Add("Text", dtgwCustomer.DataSource, "Address");
            textBox6.DataBindings.Clear();
            textBox6.DataBindings.Add("Text", dtgwCustomer.DataSource, "HoKhau");
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}

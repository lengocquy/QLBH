using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanXe.FormChild;

namespace QuanLyBanXe.Us_ChucNang
{
    public partial class Us_Staff : UserControl
    {
        public Us_Staff()
        {
            InitializeComponent();
            lbDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            timerTime.Start();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbTime.Text = dt.ToString("HH:MM:ss");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (Frm_Order_Child_Us_Staff fr = new Frm_Order_Child_Us_Staff())
            {
                fr.ShowDialog();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            using (Frm_Customer_Child_Us_Staff fr = new Frm_Customer_Child_Us_Staff())
            {
                fr.ShowDialog();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanXe.Us_ChucNang
{
    public partial class Us_OrderS : UserControl
    {
        public Us_OrderS()
        {
            InitializeComponent();
        }

        #region Method


        #endregion

        #region Event

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            //Us_Orders_Add Us = new Us_Orders_Add();
            //flpnlMain.Controls.Add(Us);
            Fr_OrdersNew fr = new Fr_OrdersNew();
            fr.ShowDialog();
        }

        #endregion
    }
}

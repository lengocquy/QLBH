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
    public partial class Form1 : Form
    {
        public static int lol = 1;
        public Form1()
        {
            InitializeComponent();

            Us_Sales Us = new Us_Sales();
            loadControlToPanelFill(Us);
        }

        #region Method

        void MoveSilde(Button btn)
        {
            pnSilde.Height = btn.Height;
            pnSilde.Top = btn.Top;
        }

        void loadControlToPanelFill(Control c)
        {
            pnFill.Dock = DockStyle.Fill;
            pnFill.Controls.Clear();
            pnFill.Controls.Add(c);
        }


        #endregion
        #region Event

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHiden_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            MoveSilde(btnSales);
            Us_Sales Us = new Us_Sales();
            loadControlToPanelFill(Us);
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            MoveSilde(btnOrder);
            Us_Order Us = new Us_Order();
            loadControlToPanelFill(Us);
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            MoveSilde(btnWareHouse);
            Us_WaseHouse Us = new Us_WaseHouse();
            loadControlToPanelFill(Us);
        }

        private void btnSettting_Click(object sender, EventArgs e)
        {
            MoveSilde(btnSetting);
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            MoveSilde(btnAccount);
            Us_Staff Us = new Us_Staff();
            loadControlToPanelFill(Us);
        }

        #endregion


    }
}

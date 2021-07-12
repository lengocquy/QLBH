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
    public partial class Us_WaseHouse : UserControl
    {
        public Us_WaseHouse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Us_WaseHouse_Item us = new Us_WaseHouse_Item()
            {
                PicturesCar = Image.FromFile(Application.StartupPath + "\\Resources\\134.jpg"),
                NameCar = "Thư yêu Huy"

            };
            flowLayoutPanel1.Controls.Add(us);

        }
    }
}

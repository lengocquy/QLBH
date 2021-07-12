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
    public partial class Us_WaseHouse_Item : UserControl
    {
        public Us_WaseHouse_Item()
        {
            InitializeComponent();
        }

        public Image PicturesCar
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string NameCar
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}

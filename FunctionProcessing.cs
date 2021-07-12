using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanXe
{
    public static class FunctionProcessing
    {
        public static void DeleteSpaceExcessInTextbox(TextBox tbx)
        {
            char[] token = { '\t', '\n', ' ', '\\', '/', '.', ',' };
            string[] arrStr = tbx.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            tbx.Text = string.Empty;
            foreach (String item in arrStr)
            {
                tbx.AppendText(item + " ");
            }
            tbx.Text.TrimEnd();
        }

        public static void OnlyNumber(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void OnlyString(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
      
        public static bool IsInputNotNullInTextBox(TextBox tbx,TextBox tbx1,TextBox tbx2,TextBox tbx3,TextBox tbx4)
        {
            if (tbx.Text == "" || tbx1.Text == "" || tbx2.Text == "" || tbx3.Text == "" || tbx4.Text == "")
            {
                return false;
            }
            return true;
        }

        public static int IsQuantityZero(string tenxe, string mauxe, double giatien, int id)
        {
            int soluong = 0;
            List<Xe> list = XeDAO.Instance.IsQuantityZero(tenxe, mauxe, giatien, id);

            foreach (Xe item in list)
            {
                soluong = item.SoLuong;
            }
            return soluong;
        }
    }
}

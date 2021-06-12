using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLQuanCafe.User_Controls
{
    public partial class UC_DoiMatKhau : UserControl
    {
        public static string manv;
        public UC_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text.Trim() != txtXacNhanMK.Text.Trim())
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Thông báo!");
            }
            else
            {
                try
                {
                    DataTable dt_nv = Dataprovider.DocCauTruc("NHANVIEN");
                    DataRow dr_nhanvien = dt_nv.NewRow();

                    string update = "UPDATE NHANVIEN SET MatKhau = N'" + txtXacNhanMK.Text.Trim() + "' WHERE MaNV ='" + txtTenDangNhap.Text.Trim() + "'";
                    DataTable dt = new DataTable();
                    dt = Dataprovider.getDatatTable(update);
                    int i = Dataprovider.Update(dt);
                    if (i == 1)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Thất bại!");
                }
            }
        }

        private void UC_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = manv;
            txtTenDangNhap.Enabled = false;
        }

        private void txtMatKhauCu_Enter(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "Mật khẩu cũ")
            {
                txtMatKhauCu.UseSystemPasswordChar = true;
                txtMatKhauCu.Text = "";
                txtMatKhauCu.ForeColor = Color.Black;
            }
        }

        private void txtMatKhauCu_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                txtMatKhauCu.UseSystemPasswordChar = false;
                txtMatKhauCu.Text = "Mật khẩu cũ";
                txtMatKhauCu.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "")
            {
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtMatKhauMoi.Text = "Mật khẩu mới";
                txtMatKhauMoi.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhauMoi_Enter(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "Mật khẩu mới")
            {
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtMatKhauMoi.Text = "";
                txtMatKhauMoi.ForeColor = Color.Black;
            }
        }

        private void txtXacNhanMK_Leave(object sender, EventArgs e)
        {
            if (txtXacNhanMK.Text == "")
            {
                txtXacNhanMK.UseSystemPasswordChar = false;
                txtXacNhanMK.Text = "Xác nhận mật khẩu";
                txtXacNhanMK.ForeColor = Color.Silver;
            }
        }

        private void txtXacNhanMK_Enter(object sender, EventArgs e)
        {
            if (txtXacNhanMK.Text == "Xác nhận mật khẩu")
            {
                txtXacNhanMK.UseSystemPasswordChar = true;
                txtXacNhanMK.Text = "";
                txtXacNhanMK.ForeColor = Color.Black;
            }
        }
    }
}

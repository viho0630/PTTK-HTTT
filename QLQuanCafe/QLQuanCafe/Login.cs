using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLQuanCafe
{
    public partial class Login : Form
    {
        DataTable dt = new DataTable();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbtb.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lbtb.Show();
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    string sql_taikhoan = "SELECT * FROM NhanVien";
                    DataTable dt_taikhoan = Dataprovider.getDatatTable(sql_taikhoan);
                    bool kiemtra = false;
                    foreach (DataRow dr_taikhoan in dt_taikhoan.Rows)
                    {
                        if (dr_taikhoan["MaNV"].ToString().Equals(txtTaiKhoan.Text) &&
                            dr_taikhoan["MatKhau"].ToString().Equals(txtMatKhau.Text))
                        {
                            kiemtra = true;
                            //CT_Main.quyenhan = dr_taikhoan["MaNV"].ToString().Trim();
                            break;
                        }
                        else
                        {
                            kiemtra = false;
                        }
                    }
                    if (kiemtra)
                    {
                        Main main = new Main();
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        lbtb.Text = " Lỗi!! Sai tài khoản hoặc mật khẩu";
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    lbtb.Text = " Lỗi!! nhập mật khẩu";
                    txtMatKhau.Focus();
                }
            }
            else
            {
                lbtb.Text = " Lỗi!! Nhập tài khoản của bạn";
                txtTaiKhoan.Focus();
            }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            frmKetNoi f = new frmKetNoi();
            f.ShowDialog();
        }
    }
}

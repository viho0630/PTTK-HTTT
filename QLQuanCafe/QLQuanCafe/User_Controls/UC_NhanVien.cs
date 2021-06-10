using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLQuanCafe.User_Controls
{
    public partial class UC_NhanVien : UserControl
    {
        DataTable dt_nhanvien = new DataTable();
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        //public void ClearData()
        //{
        //    txtMaNV.Text = "";
        //    txtTenNV.Text = "";
        //    rbNam.Checked = false;
        //    rbNu.Checked = false;
        //    txtDiaChi.Text = "";
        //    txtMucLuong.Text = "";
        //    txtSdt.Text = "";
        //}
        //public void load()
        //{
        //    string sql = "SELECT MaNV, TenNV, SDT, NgaySinh FROM NHANVIEN";
        //    dt_nhanvien = Dataprovider.getDatatTable(sql);
        //    Luoi_DSNhanVien.DataSource = dt_nhanvien;
        //}
        //private void UC_NhanVien_Load(object sender, EventArgs e)
        //{
        //    load();
        //}

        //private void pcHinhAnh_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.Title = "Select Picture";
        //    dlg.Filter = "JPG Files(*.JPG)|*.JPG|GIF Files(*.GIF)|*.GIF|PNG Files(*.PNG)|*.PNG";
        //    lbChon.Text = null;
        //    DialogResult result = dlg.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {
        //        // Lấy hình ảnh
        //        pcHinhAnh.Image = Image.FromFile(dlg.FileName);
        //        pcHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //}

        //private void btThem_Luu_Click(object sender, EventArgs e)
        //{
        //    btcapnhat.Enabled = false;
        //    btxoa.Enabled = false;
        //    btexport.Enabled = false;
        //    if (btThem_Luu.Text == "Thêm")
        //    {
        //        btThem_Luu.Text = "Lưu";
        //        ClearData();
        //    }
        //    else
        //    {
        //        btThem_Luu.Text = "Thêm";
        //        btcapnhat.Enabled = true;
        //        btxoa.Enabled = true;
        //        if (!string.IsNullOrEmpty(txtMaNV.Text) &&
        //            !string.IsNullOrEmpty(txtTenNV.Text) &&
        //            !string.IsNullOrEmpty(txtDiaChi.Text) &&
        //            !string.IsNullOrEmpty(txtSdt.Text) &&
        //            !string.IsNullOrEmpty(txtMucLuong.Text) && (!rbNam.Checked || !rbNu.Checked))
        //        {
        //            DataTable dt_nv = Dataprovider.DocCauTruc("NHANVIEN");
        //            DataRow dr_nhanvien = dt_nv.NewRow();
        //            string gt;
        //            if (rbNu.Checked == true)
        //                gt = "Nữ";
        //            else
        //                gt = "Nam";
        //            dr_nhanvien["MaNV"] = txtMaNV.Text.Trim();
        //            dr_nhanvien["TenNV"] = txtTenNV.Text.Trim();
        //            dr_nhanvien["NgaySinh"] = dtNgaySinh.Value.Date;
        //            dr_nhanvien["GioiTinh"] = gt;
        //            dr_nhanvien["DiaChi"] = txtDiaChi.Text.Trim();
        //            dr_nhanvien["MucLuong"] = txtMucLuong.Text.Trim();
        //            dr_nhanvien["MatKhau"] = txtMaNV.Text.Trim();
        //            dr_nhanvien["SDT"] = txtSdt.Text.Trim();
        //            dr_nhanvien["NgayVaoLam"] = dtNgayVaoLam.Value.Date;

        //            if (pcHinhAnh == null)
        //            {
        //                MessageBox.Show("Bạn chưa chọn hình!");
        //            }
        //            else
        //            {
        //                MemoryStream ms = new MemoryStream();
        //                byte[] bytBLOBData = new byte[ms.Length];
        //                pcHinhAnh.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //                bytBLOBData = new byte[ms.Length];
        //                ms.Position = 0;
        //                ms.Read(bytBLOBData, 0, Convert.ToInt32(ms.Length));
        //                dr_nhanvien["HinhAnh"] = bytBLOBData;
        //            }

        //            dt_nv.Rows.Add(dr_nhanvien);
        //            int i = Dataprovider.Update(dt_nv);


        //            if (i == 1)
        //            {
        //                MessageBox.Show("Thêm nhân viên thành công!");
        //            }
        //            else
        //                MessageBox.Show("Thất bại!");
        //        }
        //        else MessageBox.Show("Bạn hãy nhập đầy đủ thông tin cần thêm!");
        //    }
        //}

        //private void btcapnhat_Click(object sender, EventArgs e)
        //{

        //}

        //private void btxoa_Click(object sender, EventArgs e)
        //{

        //}

        //private void btexport_Click(object sender, EventArgs e)
        //{

        //}

        //private void txtTimKiem_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Luoi_DSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    lbChon.Text = null;
        //    string sql_nhanvien = "SELECT * FROM NHANVIEN WHERE MaNV = '" + Luoi_DSNhanVien.CurrentRow.Cells[0].Value.ToString() + "'";
        //    dt_nhanvien = Dataprovider.getDatatTable(sql_nhanvien);
        //    txtMaNV.Text = dt_nhanvien.Rows[0][0].ToString();
        //    txtTenNV.Text = dt_nhanvien.Rows[0][1].ToString();
        //    dtNgaySinh.Text = dt_nhanvien.Rows[0][2].ToString();
        //    string gt = dt_nhanvien.Rows[0][3].ToString();
        //    if (gt == "Nam")
        //        rbNam.Checked = true;
        //    else
        //        rbNu.Checked = true;

        //    txtSdt.Text = dt_nhanvien.Rows[0][4].ToString();
        //    txtDiaChi.Text = dt_nhanvien.Rows[0][5].ToString();
        //    txtMucLuong.Text = dt_nhanvien.Rows[0][7].ToString();
        //    dtNgayVaoLam.Text = dt_nhanvien.Rows[0][8].ToString();



        //    try
        //    {
        //        byte[] hinhAnh = (byte[])dt_nhanvien.Rows[0][9];
        //        MemoryStream mr = new MemoryStream(hinhAnh);
        //        pcHinhAnh.Image = Image.FromStream(mr);
        //        pcHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //    catch (Exception ex)
        //    {
        //        pcHinhAnh.Image = null;
        //        MessageBox.Show("Bạn hãy thêm hình ảnh!");
        //    }
        //}

        //private void CT_NhanVien_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

      private void InitializeComponent()
      {
         this.SuspendLayout();
         // 
         // UC_NhanVien
         // 
         this.Name = "UC_NhanVien";
         this.Size = new System.Drawing.Size(1147, 616);
         this.ResumeLayout(false);

      }
   }
}
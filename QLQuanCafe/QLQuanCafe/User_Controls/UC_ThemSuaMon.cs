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
    public partial class UC_ThemSuaMon : UserControl
    {
        public UC_ThemSuaMon()
        {
            InitializeComponent();
        }

        private void UC_ThemSuaMon_Load(object sender, EventArgs e)
        {

        }

        public string taoMaMon(string mamon)
        {
            int i = Convert.ToInt32(mamon) + 1;
            return i.ToString();
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_mon = Dataprovider.DocCauTruc("MON");
                DataRow dr_mon = dt_mon.NewRow();
                dr_mon["MaMon"] = taoMaMon("0");
                dr_mon["TenMon"] = txtTenMon.Text.Trim();
                dr_mon["Gia"] = txtGia.Text.Trim();

                if (pcHinhAnh == null)
                {
                    MessageBox.Show("Bạn chưa chọn hình!");
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    byte[] bytBLOBData = new byte[ms.Length];
                    pcHinhAnh.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytBLOBData = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(bytBLOBData, 0, Convert.ToInt32(ms.Length));
                    dr_mon["HinhAnh"] = bytBLOBData;


                }
                dt_mon.Rows.Add(dr_mon);
                int i = Dataprovider.Update(dt_mon);
                if (i == 1)
                {
                    MessageBox.Show("Thêm món thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Thất bại!");
            }
        }

        private void btTaiAnhLen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Picture";
            dlg.Filter = "JPG Files(*.JPG)|*.JPG|GIF Files(*.GIF)|*.GIF|PNG Files(*.PNG)|*.PNG";
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                pcHinhAnh.Image = Image.FromFile(dlg.FileName);
                pcHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}

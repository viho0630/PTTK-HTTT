using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLQuanCafe
{
    public partial class frmKetNoi : Form
    {
        int kq = 0;
        public frmKetNoi()
        {
            InitializeComponent();
        }

        private void frmKetNoi_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"ketnoi.ini", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String c = rd.ReadToEnd();
            string[] kq = c.Split('\n');
            txtServer.Text = kq[0].Trim();
            txtDatabase.Text = kq[1].Trim();
            rd.Close();

            txtDatabase.Text = "QLQuanCafe";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string a = txtServer.Text.Trim();
            string b = txtDatabase.Text.Trim();

            try
            {
                string[] dl = new string[] { a, b };
                using (StreamWriter sw = new StreamWriter(@"ketnoi.ini"))
                {
                    foreach (string s in dl)
                    {
                        sw.WriteLine(s);
                        kq = 1;
                    }
                }
            }
            catch (Exception)
            {
                lbtb.Text = "Lưu thất bại";
            }
            if(kq == 1)
            {
                lbtb.Text = "Lưu thành công!";
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            User_Controls.UC_ThemSuaMon hd = new User_Controls.UC_ThemSuaMon();
            pnLoad.Controls.Clear();
            pnLoad.Controls.Add(hd);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            User_Controls.UC_NhanVien nv = new User_Controls.UC_NhanVien();
            pnLoad.Controls.Clear();
            pnLoad.Controls.Add(nv);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Controls.UC_DoiMatKhau nv = new User_Controls.UC_DoiMatKhau();
            pnLoad.Controls.Clear();
            pnLoad.Controls.Add(nv);
        }

        private void mónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Controls.UC_ThemSuaMon nv = new User_Controls.UC_ThemSuaMon();
            pnLoad.Controls.Clear();
            pnLoad.Controls.Add(nv);
        }
    }
}

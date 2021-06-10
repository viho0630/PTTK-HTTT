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
   public partial class UC_TheMonAn : UserControl
   {
      public UC_TheMonAn()
      {
         InitializeComponent();
      }

      public Image MyProperty {
         get { return pbHinhAnhMon.Image; }
         set { pbHinhAnhMon.Image = value; }
      }

      public string TenMon {
         get { return lbTenMon.Text; }
         set { lbTenMon.Text = value; }
      }

      public string GiaTien
      {
         get { return lbGia.Text; }
         set { lbGia.Text = value; }
      }
   }
}

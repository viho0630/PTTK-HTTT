
namespace QLQuanCafe.User_Controls
{
   partial class UC_MenuChoKhach
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lbMenu = new System.Windows.Forms.Label();
         this.uC_TheMonAn1 = new QLQuanCafe.User_Controls.UC_TheMonAn();
         this.uC_TheMonAn2 = new QLQuanCafe.User_Controls.UC_TheMonAn();
         this.uC_TheMonAn3 = new QLQuanCafe.User_Controls.UC_TheMonAn();
         this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
         this.btnTiepTuc = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lbMenu
         // 
         this.lbMenu.AutoSize = true;
         this.lbMenu.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbMenu.Location = new System.Drawing.Point(14, 10);
         this.lbMenu.Name = "lbMenu";
         this.lbMenu.Size = new System.Drawing.Size(117, 50);
         this.lbMenu.TabIndex = 0;
         this.lbMenu.Text = "Menu";
         // 
         // uC_TheMonAn1
         // 
         this.uC_TheMonAn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.uC_TheMonAn1.GiaTien = "$0.00";
         this.uC_TheMonAn1.Location = new System.Drawing.Point(23, 81);
         this.uC_TheMonAn1.MyProperty = null;
         this.uC_TheMonAn1.Name = "uC_TheMonAn1";
         this.uC_TheMonAn1.Size = new System.Drawing.Size(226, 313);
         this.uC_TheMonAn1.TabIndex = 1;
         this.uC_TheMonAn1.TenMon = "Tên món";
         // 
         // uC_TheMonAn2
         // 
         this.uC_TheMonAn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.uC_TheMonAn2.GiaTien = "$0.00";
         this.uC_TheMonAn2.Location = new System.Drawing.Point(311, 81);
         this.uC_TheMonAn2.MyProperty = null;
         this.uC_TheMonAn2.Name = "uC_TheMonAn2";
         this.uC_TheMonAn2.Size = new System.Drawing.Size(226, 313);
         this.uC_TheMonAn2.TabIndex = 2;
         this.uC_TheMonAn2.TenMon = "Tên món";
         // 
         // uC_TheMonAn3
         // 
         this.uC_TheMonAn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.uC_TheMonAn3.GiaTien = "$0.00";
         this.uC_TheMonAn3.Location = new System.Drawing.Point(599, 81);
         this.uC_TheMonAn3.MyProperty = null;
         this.uC_TheMonAn3.Name = "uC_TheMonAn3";
         this.uC_TheMonAn3.Size = new System.Drawing.Size(226, 313);
         this.uC_TheMonAn3.TabIndex = 3;
         this.uC_TheMonAn3.TenMon = "Tên món";
         // 
         // hScrollBar1
         // 
         this.hScrollBar1.Location = new System.Drawing.Point(302, 429);
         this.hScrollBar1.Name = "hScrollBar1";
         this.hScrollBar1.Size = new System.Drawing.Size(245, 17);
         this.hScrollBar1.TabIndex = 4;
         // 
         // btnTiepTuc
         // 
         this.btnTiepTuc.BackColor = System.Drawing.Color.Black;
         this.btnTiepTuc.FlatAppearance.BorderSize = 0;
         this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnTiepTuc.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnTiepTuc.ForeColor = System.Drawing.Color.White;
         this.btnTiepTuc.Location = new System.Drawing.Point(696, 421);
         this.btnTiepTuc.Name = "btnTiepTuc";
         this.btnTiepTuc.Size = new System.Drawing.Size(129, 32);
         this.btnTiepTuc.TabIndex = 5;
         this.btnTiepTuc.Text = "Tiếp tục";
         this.btnTiepTuc.UseVisualStyleBackColor = false;
         // 
         // UC_MenuChoKhach
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.btnTiepTuc);
         this.Controls.Add(this.hScrollBar1);
         this.Controls.Add(this.uC_TheMonAn3);
         this.Controls.Add(this.uC_TheMonAn2);
         this.Controls.Add(this.uC_TheMonAn1);
         this.Controls.Add(this.lbMenu);
         this.Name = "UC_MenuChoKhach";
         this.Size = new System.Drawing.Size(848, 475);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lbMenu;
      private UC_TheMonAn uC_TheMonAn1;
      private UC_TheMonAn uC_TheMonAn2;
      private UC_TheMonAn uC_TheMonAn3;
      private System.Windows.Forms.HScrollBar hScrollBar1;
      private System.Windows.Forms.Button btnTiepTuc;
   }
}

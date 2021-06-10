
namespace QLQuanCafe.User_Controls
{
   partial class UC_CaLamViecTrongNgay
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
         this.lbGioKT = new System.Windows.Forms.Label();
         this.lbGioBD = new System.Windows.Forms.Label();
         this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
         this.lbNgay = new System.Windows.Forms.Label();
         this.lbMaNV = new System.Windows.Forms.Label();
         this.lbQLCa = new System.Windows.Forms.Label();
         this.btThemNV = new System.Windows.Forms.Button();
         this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
         this.btnLuu = new System.Windows.Forms.Button();
         this.uC_ThemNVLamViec1 = new QLQuanCafe.User_Controls.UC_ThemNVLamViec();
         this.uC_ThemNVLamViec2 = new QLQuanCafe.User_Controls.UC_ThemNVLamViec();
         this.uC_ThemNVLamViec3 = new QLQuanCafe.User_Controls.UC_ThemNVLamViec();
         this.uC_ThemNVLamViec4 = new QLQuanCafe.User_Controls.UC_ThemNVLamViec();
         this.SuspendLayout();
         // 
         // lbGioKT
         // 
         this.lbGioKT.AutoSize = true;
         this.lbGioKT.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbGioKT.Location = new System.Drawing.Point(446, 164);
         this.lbGioKT.Name = "lbGioKT";
         this.lbGioKT.Size = new System.Drawing.Size(100, 21);
         this.lbGioKT.TabIndex = 11;
         this.lbGioKT.Text = "Giờ kết thúc";
         // 
         // lbGioBD
         // 
         this.lbGioBD.AutoSize = true;
         this.lbGioBD.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbGioBD.Location = new System.Drawing.Point(285, 164);
         this.lbGioBD.Name = "lbGioBD";
         this.lbGioBD.Size = new System.Drawing.Size(96, 21);
         this.lbGioBD.TabIndex = 10;
         this.lbGioBD.Text = "Giờ bắt đầu";
         // 
         // dateTimePicker1
         // 
         this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dateTimePicker1.Location = new System.Drawing.Point(147, 117);
         this.dateTimePicker1.Name = "dateTimePicker1";
         this.dateTimePicker1.Size = new System.Drawing.Size(262, 25);
         this.dateTimePicker1.TabIndex = 9;
         // 
         // lbNgay
         // 
         this.lbNgay.AutoSize = true;
         this.lbNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbNgay.Location = new System.Drawing.Point(53, 117);
         this.lbNgay.Name = "lbNgay";
         this.lbNgay.Size = new System.Drawing.Size(58, 25);
         this.lbNgay.TabIndex = 8;
         this.lbNgay.Text = "Ngày";
         // 
         // lbMaNV
         // 
         this.lbMaNV.AutoSize = true;
         this.lbMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbMaNV.Location = new System.Drawing.Point(75, 164);
         this.lbMaNV.Name = "lbMaNV";
         this.lbMaNV.Size = new System.Drawing.Size(112, 21);
         this.lbMaNV.TabIndex = 7;
         this.lbMaNV.Text = "Mã nhân viên";
         // 
         // lbQLCa
         // 
         this.lbQLCa.AutoSize = true;
         this.lbQLCa.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbQLCa.Location = new System.Drawing.Point(41, 25);
         this.lbQLCa.Name = "lbQLCa";
         this.lbQLCa.Size = new System.Drawing.Size(581, 65);
         this.lbQLCa.TabIndex = 6;
         this.lbQLCa.Text = "Ca Làm Việc Trong Ngày";
         // 
         // btThemNV
         // 
         this.btThemNV.BackColor = System.Drawing.Color.RoyalBlue;
         this.btThemNV.FlatAppearance.BorderSize = 0;
         this.btThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btThemNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btThemNV.ForeColor = System.Drawing.Color.White;
         this.btThemNV.Location = new System.Drawing.Point(571, 117);
         this.btThemNV.Name = "btThemNV";
         this.btThemNV.Size = new System.Drawing.Size(123, 25);
         this.btThemNV.TabIndex = 13;
         this.btThemNV.Text = "Thêm nhân viên";
         this.btThemNV.UseVisualStyleBackColor = false;
         // 
         // vScrollBar1
         // 
         this.vScrollBar1.Location = new System.Drawing.Point(677, 210);
         this.vScrollBar1.Name = "vScrollBar1";
         this.vScrollBar1.Size = new System.Drawing.Size(17, 223);
         this.vScrollBar1.TabIndex = 15;
         // 
         // btnLuu
         // 
         this.btnLuu.BackColor = System.Drawing.Color.Black;
         this.btnLuu.FlatAppearance.BorderSize = 0;
         this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLuu.ForeColor = System.Drawing.Color.White;
         this.btnLuu.Location = new System.Drawing.Point(571, 455);
         this.btnLuu.Name = "btnLuu";
         this.btnLuu.Size = new System.Drawing.Size(123, 25);
         this.btnLuu.TabIndex = 16;
         this.btnLuu.Text = "Lưu";
         this.btnLuu.UseVisualStyleBackColor = false;
         // 
         // uC_ThemNVLamViec1
         // 
         this.uC_ThemNVLamViec1.Location = new System.Drawing.Point(36, 210);
         this.uC_ThemNVLamViec1.Name = "uC_ThemNVLamViec1";
         this.uC_ThemNVLamViec1.Size = new System.Drawing.Size(632, 43);
         this.uC_ThemNVLamViec1.TabIndex = 17;
         // 
         // uC_ThemNVLamViec2
         // 
         this.uC_ThemNVLamViec2.Location = new System.Drawing.Point(36, 259);
         this.uC_ThemNVLamViec2.Name = "uC_ThemNVLamViec2";
         this.uC_ThemNVLamViec2.Size = new System.Drawing.Size(632, 43);
         this.uC_ThemNVLamViec2.TabIndex = 18;
         // 
         // uC_ThemNVLamViec3
         // 
         this.uC_ThemNVLamViec3.Location = new System.Drawing.Point(36, 308);
         this.uC_ThemNVLamViec3.Name = "uC_ThemNVLamViec3";
         this.uC_ThemNVLamViec3.Size = new System.Drawing.Size(632, 43);
         this.uC_ThemNVLamViec3.TabIndex = 19;
         // 
         // uC_ThemNVLamViec4
         // 
         this.uC_ThemNVLamViec4.Location = new System.Drawing.Point(36, 357);
         this.uC_ThemNVLamViec4.Name = "uC_ThemNVLamViec4";
         this.uC_ThemNVLamViec4.Size = new System.Drawing.Size(632, 43);
         this.uC_ThemNVLamViec4.TabIndex = 20;
         // 
         // UC_CaLamViecTrongNgay
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.uC_ThemNVLamViec4);
         this.Controls.Add(this.uC_ThemNVLamViec3);
         this.Controls.Add(this.uC_ThemNVLamViec2);
         this.Controls.Add(this.uC_ThemNVLamViec1);
         this.Controls.Add(this.btnLuu);
         this.Controls.Add(this.vScrollBar1);
         this.Controls.Add(this.btThemNV);
         this.Controls.Add(this.lbGioKT);
         this.Controls.Add(this.lbGioBD);
         this.Controls.Add(this.dateTimePicker1);
         this.Controls.Add(this.lbNgay);
         this.Controls.Add(this.lbMaNV);
         this.Controls.Add(this.lbQLCa);
         this.Name = "UC_CaLamViecTrongNgay";
         this.Size = new System.Drawing.Size(746, 510);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lbGioKT;
      private System.Windows.Forms.Label lbGioBD;
      private System.Windows.Forms.DateTimePicker dateTimePicker1;
      private System.Windows.Forms.Label lbNgay;
      private System.Windows.Forms.Label lbMaNV;
      private System.Windows.Forms.Label lbQLCa;
      private System.Windows.Forms.Button btThemNV;
      private System.Windows.Forms.VScrollBar vScrollBar1;
      private System.Windows.Forms.Button btnLuu;
      private UC_ThemNVLamViec uC_ThemNVLamViec1;
      private UC_ThemNVLamViec uC_ThemNVLamViec2;
      private UC_ThemNVLamViec uC_ThemNVLamViec3;
      private UC_ThemNVLamViec uC_ThemNVLamViec4;
   }
}

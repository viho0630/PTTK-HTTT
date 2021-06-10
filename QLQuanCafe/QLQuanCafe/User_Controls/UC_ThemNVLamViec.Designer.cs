
namespace QLQuanCafe.User_Controls
{
   partial class UC_ThemNVLamViec
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
         this.lbSTT = new System.Windows.Forms.Label();
         this.lbMaNV = new System.Windows.Forms.Label();
         this.thoiGianBD = new System.Windows.Forms.DateTimePicker();
         this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
         this.btnXoa = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lbSTT
         // 
         this.lbSTT.AutoSize = true;
         this.lbSTT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbSTT.Location = new System.Drawing.Point(7, 10);
         this.lbSTT.Name = "lbSTT";
         this.lbSTT.Size = new System.Drawing.Size(15, 20);
         this.lbSTT.TabIndex = 0;
         this.lbSTT.Text = "1";
         // 
         // lbMaNV
         // 
         this.lbMaNV.AutoSize = true;
         this.lbMaNV.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbMaNV.Location = new System.Drawing.Point(37, 10);
         this.lbMaNV.Name = "lbMaNV";
         this.lbMaNV.Size = new System.Drawing.Size(57, 20);
         this.lbMaNV.TabIndex = 1;
         this.lbMaNV.Text = "Mã NV";
         // 
         // thoiGianBD
         // 
         this.thoiGianBD.AllowDrop = true;
         this.thoiGianBD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.thoiGianBD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
         this.thoiGianBD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.thoiGianBD.Location = new System.Drawing.Point(239, 10);
         this.thoiGianBD.Name = "thoiGianBD";
         this.thoiGianBD.Size = new System.Drawing.Size(129, 23);
         this.thoiGianBD.TabIndex = 2;
         this.thoiGianBD.Value = new System.DateTime(2021, 6, 10, 9, 47, 38, 0);
         // 
         // dateTimePicker1
         // 
         this.dateTimePicker1.AllowDrop = true;
         this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
         this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.dateTimePicker1.Location = new System.Drawing.Point(400, 10);
         this.dateTimePicker1.Name = "dateTimePicker1";
         this.dateTimePicker1.Size = new System.Drawing.Size(129, 23);
         this.dateTimePicker1.TabIndex = 3;
         this.dateTimePicker1.Value = new System.DateTime(2021, 6, 10, 9, 47, 38, 0);
         // 
         // btnXoa
         // 
         this.btnXoa.BackColor = System.Drawing.Color.Red;
         this.btnXoa.FlatAppearance.BorderSize = 0;
         this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnXoa.ForeColor = System.Drawing.Color.White;
         this.btnXoa.Location = new System.Drawing.Point(561, 8);
         this.btnXoa.Name = "btnXoa";
         this.btnXoa.Size = new System.Drawing.Size(58, 25);
         this.btnXoa.TabIndex = 4;
         this.btnXoa.Text = "Xóa";
         this.btnXoa.UseVisualStyleBackColor = false;
         // 
         // UC_ThemNVLamViec
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.btnXoa);
         this.Controls.Add(this.dateTimePicker1);
         this.Controls.Add(this.thoiGianBD);
         this.Controls.Add(this.lbMaNV);
         this.Controls.Add(this.lbSTT);
         this.Name = "UC_ThemNVLamViec";
         this.Size = new System.Drawing.Size(632, 43);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lbSTT;
      private System.Windows.Forms.Label lbMaNV;
      private System.Windows.Forms.DateTimePicker thoiGianBD;
      private System.Windows.Forms.DateTimePicker dateTimePicker1;
      private System.Windows.Forms.Button btnXoa;
   }
}

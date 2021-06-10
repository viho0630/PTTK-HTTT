
namespace QLQuanCafe.User_Controls
{
   partial class UC_KiemTraDatMon
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
         this.btnDatMon = new System.Windows.Forms.Label();
         this.uC_TheMonAnXacNhan1 = new QLQuanCafe.User_Controls.UC_TheMonAnXacNhan();
         this.uC_TheMonAnXacNhan2 = new QLQuanCafe.User_Controls.UC_TheMonAnXacNhan();
         this.uC_TheMonAnXacNhan3 = new QLQuanCafe.User_Controls.UC_TheMonAnXacNhan();
         this.uC_TheMonAnXacNhan4 = new QLQuanCafe.User_Controls.UC_TheMonAnXacNhan();
         this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
         this.btnXacNhan = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnDatMon
         // 
         this.btnDatMon.AutoSize = true;
         this.btnDatMon.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDatMon.Location = new System.Drawing.Point(3, 0);
         this.btnDatMon.Name = "btnDatMon";
         this.btnDatMon.Size = new System.Drawing.Size(224, 65);
         this.btnDatMon.TabIndex = 0;
         this.btnDatMon.Text = "Đặt món";
         // 
         // uC_TheMonAnXacNhan1
         // 
         this.uC_TheMonAnXacNhan1.BackColor = System.Drawing.SystemColors.Control;
         this.uC_TheMonAnXacNhan1.Location = new System.Drawing.Point(14, 74);
         this.uC_TheMonAnXacNhan1.Name = "uC_TheMonAnXacNhan1";
         this.uC_TheMonAnXacNhan1.Size = new System.Drawing.Size(302, 74);
         this.uC_TheMonAnXacNhan1.TabIndex = 1;
         // 
         // uC_TheMonAnXacNhan2
         // 
         this.uC_TheMonAnXacNhan2.BackColor = System.Drawing.SystemColors.Control;
         this.uC_TheMonAnXacNhan2.Location = new System.Drawing.Point(14, 157);
         this.uC_TheMonAnXacNhan2.Name = "uC_TheMonAnXacNhan2";
         this.uC_TheMonAnXacNhan2.Size = new System.Drawing.Size(302, 74);
         this.uC_TheMonAnXacNhan2.TabIndex = 2;
         // 
         // uC_TheMonAnXacNhan3
         // 
         this.uC_TheMonAnXacNhan3.BackColor = System.Drawing.SystemColors.Control;
         this.uC_TheMonAnXacNhan3.Location = new System.Drawing.Point(14, 323);
         this.uC_TheMonAnXacNhan3.Name = "uC_TheMonAnXacNhan3";
         this.uC_TheMonAnXacNhan3.Size = new System.Drawing.Size(302, 74);
         this.uC_TheMonAnXacNhan3.TabIndex = 4;
         // 
         // uC_TheMonAnXacNhan4
         // 
         this.uC_TheMonAnXacNhan4.BackColor = System.Drawing.SystemColors.Control;
         this.uC_TheMonAnXacNhan4.Location = new System.Drawing.Point(14, 240);
         this.uC_TheMonAnXacNhan4.Name = "uC_TheMonAnXacNhan4";
         this.uC_TheMonAnXacNhan4.Size = new System.Drawing.Size(302, 74);
         this.uC_TheMonAnXacNhan4.TabIndex = 3;
         // 
         // vScrollBar1
         // 
         this.vScrollBar1.Location = new System.Drawing.Point(328, 183);
         this.vScrollBar1.Name = "vScrollBar1";
         this.vScrollBar1.Size = new System.Drawing.Size(17, 103);
         this.vScrollBar1.TabIndex = 5;
         // 
         // btnXacNhan
         // 
         this.btnXacNhan.BackColor = System.Drawing.Color.Red;
         this.btnXacNhan.FlatAppearance.BorderSize = 0;
         this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnXacNhan.ForeColor = System.Drawing.Color.White;
         this.btnXacNhan.Location = new System.Drawing.Point(236, 418);
         this.btnXacNhan.Name = "btnXacNhan";
         this.btnXacNhan.Size = new System.Drawing.Size(109, 33);
         this.btnXacNhan.TabIndex = 6;
         this.btnXacNhan.Text = "Xác nhận";
         this.btnXacNhan.UseVisualStyleBackColor = false;
         // 
         // UC_KiemTraDatMon
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.btnXacNhan);
         this.Controls.Add(this.vScrollBar1);
         this.Controls.Add(this.uC_TheMonAnXacNhan3);
         this.Controls.Add(this.uC_TheMonAnXacNhan4);
         this.Controls.Add(this.uC_TheMonAnXacNhan2);
         this.Controls.Add(this.uC_TheMonAnXacNhan1);
         this.Controls.Add(this.btnDatMon);
         this.Name = "UC_KiemTraDatMon";
         this.Size = new System.Drawing.Size(354, 470);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label btnDatMon;
      private UC_TheMonAnXacNhan uC_TheMonAnXacNhan1;
      private UC_TheMonAnXacNhan uC_TheMonAnXacNhan2;
      private UC_TheMonAnXacNhan uC_TheMonAnXacNhan3;
      private UC_TheMonAnXacNhan uC_TheMonAnXacNhan4;
      private System.Windows.Forms.VScrollBar vScrollBar1;
      private System.Windows.Forms.Button btnXacNhan;
   }
}

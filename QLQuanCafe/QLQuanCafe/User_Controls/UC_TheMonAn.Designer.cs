
namespace QLQuanCafe.User_Controls
{
   partial class UC_TheMonAn
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
         this.lbTenMon = new System.Windows.Forms.Label();
         this.pbHinhAnhMon = new System.Windows.Forms.PictureBox();
         this.btThem = new System.Windows.Forms.Button();
         this.lbGia = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnhMon)).BeginInit();
         this.SuspendLayout();
         // 
         // lbTenMon
         // 
         this.lbTenMon.AutoSize = true;
         this.lbTenMon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbTenMon.Location = new System.Drawing.Point(8, 14);
         this.lbTenMon.Name = "lbTenMon";
         this.lbTenMon.Size = new System.Drawing.Size(89, 25);
         this.lbTenMon.TabIndex = 0;
         this.lbTenMon.Text = "Tên món";
         // 
         // pbHinhAnhMon
         // 
         this.pbHinhAnhMon.BackColor = System.Drawing.Color.White;
         this.pbHinhAnhMon.Location = new System.Drawing.Point(13, 51);
         this.pbHinhAnhMon.Name = "pbHinhAnhMon";
         this.pbHinhAnhMon.Size = new System.Drawing.Size(200, 200);
         this.pbHinhAnhMon.TabIndex = 1;
         this.pbHinhAnhMon.TabStop = false;
         // 
         // btThem
         // 
         this.btThem.BackColor = System.Drawing.Color.Black;
         this.btThem.FlatAppearance.BorderSize = 0;
         this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btThem.ForeColor = System.Drawing.Color.White;
         this.btThem.Location = new System.Drawing.Point(138, 263);
         this.btThem.Name = "btThem";
         this.btThem.Size = new System.Drawing.Size(75, 36);
         this.btThem.TabIndex = 2;
         this.btThem.Text = "Thêm";
         this.btThem.UseVisualStyleBackColor = false;
         // 
         // lbGia
         // 
         this.lbGia.AutoSize = true;
         this.lbGia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbGia.Location = new System.Drawing.Point(8, 268);
         this.lbGia.Name = "lbGia";
         this.lbGia.Size = new System.Drawing.Size(61, 25);
         this.lbGia.TabIndex = 3;
         this.lbGia.Text = "$0.00";
         // 
         // UC_TheMonAn
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.Controls.Add(this.lbGia);
         this.Controls.Add(this.btThem);
         this.Controls.Add(this.pbHinhAnhMon);
         this.Controls.Add(this.lbTenMon);
         this.Name = "UC_TheMonAn";
         this.Size = new System.Drawing.Size(226, 313);
         ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnhMon)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lbTenMon;
      private System.Windows.Forms.PictureBox pbHinhAnhMon;
      private System.Windows.Forms.Button btThem;
      private System.Windows.Forms.Label lbGia;
   }
}

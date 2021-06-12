
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
         this.lbGia = new System.Windows.Forms.Label();
         this.pbHinhAnhMon = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnhMon)).BeginInit();
         this.SuspendLayout();
         // 
         // lbTenMon
         // 
         this.lbTenMon.AutoSize = true;
         this.lbTenMon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbTenMon.Location = new System.Drawing.Point(12, 9);
         this.lbTenMon.Name = "lbTenMon";
         this.lbTenMon.Size = new System.Drawing.Size(89, 25);
         this.lbTenMon.TabIndex = 0;
         this.lbTenMon.Text = "Tên món";
         // 
         // lbGia
         // 
         this.lbGia.AutoSize = true;
         this.lbGia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbGia.Location = new System.Drawing.Point(19, 140);
         this.lbGia.Name = "lbGia";
         this.lbGia.Size = new System.Drawing.Size(61, 25);
         this.lbGia.TabIndex = 3;
         this.lbGia.Text = "$0.00";
         // 
         // pbHinhAnhMon
         // 
         this.pbHinhAnhMon.BackColor = System.Drawing.Color.White;
         this.pbHinhAnhMon.Location = new System.Drawing.Point(6, 37);
         this.pbHinhAnhMon.Name = "pbHinhAnhMon";
         this.pbHinhAnhMon.Size = new System.Drawing.Size(100, 100);
         this.pbHinhAnhMon.TabIndex = 1;
         this.pbHinhAnhMon.TabStop = false;
         // 
         // UC_TheMonAn
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
         this.Controls.Add(this.lbGia);
         this.Controls.Add(this.pbHinhAnhMon);
         this.Controls.Add(this.lbTenMon);
         this.Name = "UC_TheMonAn";
         this.Size = new System.Drawing.Size(112, 166);
         ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnhMon)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lbTenMon;
      private System.Windows.Forms.PictureBox pbHinhAnhMon;
      private System.Windows.Forms.Label lbGia;
   }
}

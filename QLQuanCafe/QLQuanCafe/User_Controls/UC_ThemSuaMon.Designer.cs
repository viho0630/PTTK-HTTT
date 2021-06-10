
namespace QLQuanCafe.User_Controls
{
   partial class UC_ThemSuaMon
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
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.btTaiAnhLen = new System.Windows.Forms.Button();
         this.lbTenMon = new System.Windows.Forms.Label();
         this.txtTenMon = new System.Windows.Forms.TextBox();
         this.txtGia = new System.Windows.Forms.TextBox();
         this.lbGia = new System.Windows.Forms.Label();
         this.btLuu = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(15, 14);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(200, 200);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // btTaiAnhLen
         // 
         this.btTaiAnhLen.BackColor = System.Drawing.Color.Black;
         this.btTaiAnhLen.FlatAppearance.BorderSize = 0;
         this.btTaiAnhLen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btTaiAnhLen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btTaiAnhLen.ForeColor = System.Drawing.Color.White;
         this.btTaiAnhLen.Location = new System.Drawing.Point(15, 220);
         this.btTaiAnhLen.Name = "btTaiAnhLen";
         this.btTaiAnhLen.Size = new System.Drawing.Size(200, 27);
         this.btTaiAnhLen.TabIndex = 1;
         this.btTaiAnhLen.Text = "Tải ảnh lên";
         this.btTaiAnhLen.UseVisualStyleBackColor = false;
         // 
         // lbTenMon
         // 
         this.lbTenMon.AutoSize = true;
         this.lbTenMon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbTenMon.Location = new System.Drawing.Point(12, 257);
         this.lbTenMon.Name = "lbTenMon";
         this.lbTenMon.Size = new System.Drawing.Size(61, 17);
         this.lbTenMon.TabIndex = 2;
         this.lbTenMon.Text = "Tên món";
         // 
         // txtTenMon
         // 
         this.txtTenMon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtTenMon.Location = new System.Drawing.Point(15, 284);
         this.txtTenMon.Name = "txtTenMon";
         this.txtTenMon.Size = new System.Drawing.Size(200, 25);
         this.txtTenMon.TabIndex = 3;
         // 
         // txtGia
         // 
         this.txtGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtGia.Location = new System.Drawing.Point(15, 346);
         this.txtGia.Name = "txtGia";
         this.txtGia.Size = new System.Drawing.Size(200, 25);
         this.txtGia.TabIndex = 5;
         // 
         // lbGia
         // 
         this.lbGia.AutoSize = true;
         this.lbGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbGia.Location = new System.Drawing.Point(12, 319);
         this.lbGia.Name = "lbGia";
         this.lbGia.Size = new System.Drawing.Size(54, 17);
         this.lbGia.TabIndex = 4;
         this.lbGia.Text = "Giá tiền";
         // 
         // btLuu
         // 
         this.btLuu.BackColor = System.Drawing.Color.Black;
         this.btLuu.FlatAppearance.BorderSize = 0;
         this.btLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btLuu.ForeColor = System.Drawing.Color.White;
         this.btLuu.Location = new System.Drawing.Point(137, 381);
         this.btLuu.Name = "btLuu";
         this.btLuu.Size = new System.Drawing.Size(78, 27);
         this.btLuu.TabIndex = 6;
         this.btLuu.Text = "Lưu";
         this.btLuu.UseVisualStyleBackColor = false;
         // 
         // UC_ThemMon
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.btLuu);
         this.Controls.Add(this.txtGia);
         this.Controls.Add(this.lbGia);
         this.Controls.Add(this.txtTenMon);
         this.Controls.Add(this.lbTenMon);
         this.Controls.Add(this.btTaiAnhLen);
         this.Controls.Add(this.pictureBox1);
         this.Name = "UC_ThemMon";
         this.Size = new System.Drawing.Size(230, 423);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button btTaiAnhLen;
      private System.Windows.Forms.Label lbTenMon;
      private System.Windows.Forms.TextBox txtTenMon;
      private System.Windows.Forms.TextBox txtGia;
      private System.Windows.Forms.Label lbGia;
      private System.Windows.Forms.Button btLuu;
   }
}

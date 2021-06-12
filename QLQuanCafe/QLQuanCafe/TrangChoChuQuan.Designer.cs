
namespace QLQuanCafe
{
   partial class TrangChoChuQuan
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.panel2 = new System.Windows.Forms.Panel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.btnThongBao = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.panel2.SuspendLayout();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
         this.panel2.Controls.Add(this.panel3);
         this.panel2.Controls.Add(this.btnThongBao);
         this.panel2.Controls.Add(this.panel1);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(232, 720);
         this.panel2.TabIndex = 1;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(232, 186);
         this.panel1.TabIndex = 2;
         // 
         // panel3
         // 
         this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel3.Location = new System.Drawing.Point(0, 694);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(232, 26);
         this.panel3.TabIndex = 3;
         // 
         // btnThongBao
         // 
         this.btnThongBao.Dock = System.Windows.Forms.DockStyle.Top;
         this.btnThongBao.FlatAppearance.BorderSize = 0;
         this.btnThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnThongBao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnThongBao.Image = global::QLQuanCafe.Properties.Resources.bell__1_;
         this.btnThongBao.Location = new System.Drawing.Point(0, 186);
         this.btnThongBao.Name = "btnThongBao";
         this.btnThongBao.Size = new System.Drawing.Size(232, 51);
         this.btnThongBao.TabIndex = 1;
         this.btnThongBao.Text = "Thông báo";
         this.btnThongBao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnThongBao.UseVisualStyleBackColor = true;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::QLQuanCafe.Properties.Resources.logocafe;
         this.pictureBox1.Location = new System.Drawing.Point(41, 18);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(150, 150);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // TrangChoChuQuan
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.ClientSize = new System.Drawing.Size(1264, 720);
         this.Controls.Add(this.panel2);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "TrangChoChuQuan";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Trang Cho Chủ Quán";
         this.panel2.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Button btnThongBao;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}

namespace QLQuanCafe.User_Controls
{
   partial class UC_TheMonAnXacNhan
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
         this.btnXoa = new System.Windows.Forms.Button();
         this.lbTenMon = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.numericUpDown = new System.Windows.Forms.NumericUpDown();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
         this.SuspendLayout();
         // 
         // btnXoa
         // 
         this.btnXoa.BackColor = System.Drawing.Color.Black;
         this.btnXoa.FlatAppearance.BorderSize = 0;
         this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnXoa.ForeColor = System.Drawing.Color.White;
         this.btnXoa.Location = new System.Drawing.Point(215, 39);
         this.btnXoa.Name = "btnXoa";
         this.btnXoa.Size = new System.Drawing.Size(75, 24);
         this.btnXoa.TabIndex = 7;
         this.btnXoa.Text = "Xóa";
         this.btnXoa.UseVisualStyleBackColor = false;
         // 
         // lbTenMon
         // 
         this.lbTenMon.AutoSize = true;
         this.lbTenMon.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbTenMon.Location = new System.Drawing.Point(68, 6);
         this.lbTenMon.Name = "lbTenMon";
         this.lbTenMon.Size = new System.Drawing.Size(85, 25);
         this.lbTenMon.TabIndex = 5;
         this.lbTenMon.Text = "Tên món";
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.White;
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(50, 50);
         this.pictureBox1.TabIndex = 4;
         this.pictureBox1.TabStop = false;
         // 
         // numericUpDown
         // 
         this.numericUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.numericUpDown.Location = new System.Drawing.Point(74, 38);
         this.numericUpDown.Name = "numericUpDown";
         this.numericUpDown.Size = new System.Drawing.Size(61, 25);
         this.numericUpDown.TabIndex = 8;
         // 
         // UC_TheMonAnXacNhan
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.numericUpDown);
         this.Controls.Add(this.btnXoa);
         this.Controls.Add(this.lbTenMon);
         this.Controls.Add(this.pictureBox1);
         this.Name = "UC_TheMonAnXacNhan";
         this.Size = new System.Drawing.Size(302, 74);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnXoa;
      private System.Windows.Forms.Label lbTenMon;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.NumericUpDown numericUpDown;
   }
}

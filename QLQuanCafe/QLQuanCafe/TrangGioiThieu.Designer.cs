﻿
namespace QLQuanCafe
{
   partial class TrangGioiThieu
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangGioiThieu));
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
         this.pictureBox1.Image = global::QLQuanCafe.Properties.Resources.logocafe;
         this.pictureBox1.Location = new System.Drawing.Point(223, 30);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(445, 425);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(35, 30);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(182, 203);
         this.label1.TabIndex = 1;
         this.label1.Text = resources.GetString("label1.Text");
         // 
         // label2
         // 
         this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(674, 252);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(182, 203);
         this.label2.TabIndex = 2;
         this.label2.Text = resources.GetString("label2.Text");
         // 
         // TrangGioiThieu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
         this.ClientSize = new System.Drawing.Size(890, 484);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox1);
         this.ForeColor = System.Drawing.Color.Black;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "TrangGioiThieu";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "TrangGioiThieu";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
   }
}
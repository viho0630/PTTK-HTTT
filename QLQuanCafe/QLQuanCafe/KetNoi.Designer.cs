
namespace QLQuanCafe
{
    partial class frmKetNoi
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
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.btnLuu = new System.Windows.Forms.Button();
         this.txtDatabase = new System.Windows.Forms.TextBox();
         this.txtServer = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(22, 103);
         this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(79, 21);
         this.label3.TabIndex = 13;
         this.label3.Text = "Database";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(22, 64);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(54, 21);
         this.label2.TabIndex = 12;
         this.label2.Text = "Server";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(97, 9);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(190, 37);
         this.label1.TabIndex = 11;
         this.label1.Text = "Kết Nối CSDL";
         // 
         // btnLuu
         // 
         this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.btnLuu.FlatAppearance.BorderSize = 0;
         this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLuu.ForeColor = System.Drawing.Color.White;
         this.btnLuu.Location = new System.Drawing.Point(292, 138);
         this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnLuu.Name = "btnLuu";
         this.btnLuu.Size = new System.Drawing.Size(70, 33);
         this.btnLuu.TabIndex = 10;
         this.btnLuu.Text = "Lưu";
         this.btnLuu.UseVisualStyleBackColor = false;
         this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
         // 
         // txtDatabase
         // 
         this.txtDatabase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDatabase.Location = new System.Drawing.Point(122, 101);
         this.txtDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtDatabase.Name = "txtDatabase";
         this.txtDatabase.Size = new System.Drawing.Size(240, 25);
         this.txtDatabase.TabIndex = 8;
         // 
         // txtServer
         // 
         this.txtServer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtServer.Location = new System.Drawing.Point(122, 64);
         this.txtServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtServer.Name = "txtServer";
         this.txtServer.Size = new System.Drawing.Size(240, 25);
         this.txtServer.TabIndex = 7;
         // 
         // frmKetNoi
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(384, 185);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnLuu);
         this.Controls.Add(this.txtDatabase);
         this.Controls.Add(this.txtServer);
         this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "frmKetNoi";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Kết nối CSDL";
         this.Load += new System.EventHandler(this.frmKetNoi_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtServer;
    }
}
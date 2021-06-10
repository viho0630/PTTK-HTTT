
namespace QLQuanCafe.User_Controls
{
    partial class UC_NhanVien
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
            this.lbChon = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btexport = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btThem_Luu = new System.Windows.Forms.Button();
            this.pcHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMucLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Luoi_DSNhanVien = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChon
            // 
            this.lbChon.AutoSize = true;
            this.lbChon.Location = new System.Drawing.Point(780, 135);
            this.lbChon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChon.Name = "lbChon";
            this.lbChon.Size = new System.Drawing.Size(55, 13);
            this.lbChon.TabIndex = 117;
            this.lbChon.Text = "Chọn hình";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(674, 130);
            this.rbNam.Margin = new System.Windows.Forms.Padding(2);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 115;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(587, 130);
            this.rbNu.Margin = new System.Windows.Forms.Padding(2);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 81;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(587, 248);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(134, 20);
            this.txtSdt.TabIndex = 101;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(499, 252);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 13);
            this.label22.TabIndex = 113;
            this.label22.Text = "Số Điện Thoại";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(587, 159);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(134, 20);
            this.dtNgaySinh.TabIndex = 83;
            this.dtNgaySinh.Value = new System.DateTime(2020, 10, 29, 0, 0, 0, 0);
            // 
            // btexport
            // 
            this.btexport.Location = new System.Drawing.Point(811, 259);
            this.btexport.Name = "btexport";
            this.btexport.Size = new System.Drawing.Size(58, 23);
            this.btexport.TabIndex = 107;
            this.btexport.Text = "Export";
            this.btexport.UseVisualStyleBackColor = true;
            this.btexport.Click += new System.EventHandler(this.btexport_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.Location = new System.Drawing.Point(811, 230);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(58, 23);
            this.btcapnhat.TabIndex = 105;
            this.btcapnhat.Text = "Cập nhật";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(742, 259);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(63, 23);
            this.btxoa.TabIndex = 106;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btThem_Luu
            // 
            this.btThem_Luu.Location = new System.Drawing.Point(742, 230);
            this.btThem_Luu.Name = "btThem_Luu";
            this.btThem_Luu.Size = new System.Drawing.Size(63, 23);
            this.btThem_Luu.TabIndex = 104;
            this.btThem_Luu.Text = "Thêm";
            this.btThem_Luu.UseVisualStyleBackColor = true;
            this.btThem_Luu.Click += new System.EventHandler(this.btThem_Luu_Click);
            // 
            // pcHinhAnh
            // 
            this.pcHinhAnh.BackColor = System.Drawing.Color.PeachPuff;
            this.pcHinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcHinhAnh.Location = new System.Drawing.Point(751, 66);
            this.pcHinhAnh.Name = "pcHinhAnh";
            this.pcHinhAnh.Size = new System.Drawing.Size(111, 153);
            this.pcHinhAnh.TabIndex = 103;
            this.pcHinhAnh.TabStop = false;
            this.pcHinhAnh.Click += new System.EventHandler(this.pcHinhAnh_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(587, 189);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(134, 20);
            this.txtDiaChi.TabIndex = 93;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(587, 99);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(134, 20);
            this.txtTenNV.TabIndex = 79;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(587, 66);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(134, 20);
            this.txtMaNV.TabIndex = 77;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(518, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 86;
            this.label16.Text = "Ngày Sinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(533, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Họ Và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.Location = new System.Drawing.Point(587, 278);
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(134, 20);
            this.txtMucLuong.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 119;
            this.label1.Text = "Mức lương";
            // 
            // dtNgayVaoLam
            // 
            this.dtNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayVaoLam.Location = new System.Drawing.Point(587, 218);
            this.dtNgayVaoLam.Name = "dtNgayVaoLam";
            this.dtNgayVaoLam.Size = new System.Drawing.Size(134, 20);
            this.dtNgayVaoLam.TabIndex = 120;
            this.dtNgayVaoLam.Value = new System.DateTime(2020, 10, 29, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Ngày vào làm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 25);
            this.label6.TabIndex = 122;
            this.label6.Text = "THÔNG TIN CHI TIẾT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 25);
            this.label7.TabIndex = 123;
            this.label7.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // Luoi_DSNhanVien
            // 
            this.Luoi_DSNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_DSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_DSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgaySinh,
            this.SDT});
            this.Luoi_DSNhanVien.Location = new System.Drawing.Point(23, 103);
            this.Luoi_DSNhanVien.Name = "Luoi_DSNhanVien";
            this.Luoi_DSNhanVien.Size = new System.Drawing.Size(439, 191);
            this.Luoi_DSNhanVien.TabIndex = 124;
            this.Luoi_DSNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_DSNhanVien_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(175, 66);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(152, 20);
            this.txtTimKiem.TabIndex = 126;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 125;
            this.label8.Text = "Tìm kiếm";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Họ và tên";
            this.TenNV.Name = "TenNV";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Luoi_DSNhanVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtNgayVaoLam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMucLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbChon);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.btexport);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btThem_Luu);
            this.Controls.Add(this.pcHinhAnh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(891, 317);
            this.Load += new System.EventHandler(this.UC_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChon;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Button btexport;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btThem_Luu;
        private System.Windows.Forms.PictureBox pcHinhAnh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMucLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayVaoLam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Luoi_DSNhanVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}

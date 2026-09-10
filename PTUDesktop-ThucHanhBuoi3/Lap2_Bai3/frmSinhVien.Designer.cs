namespace Lap2_Bai3
{
    partial class frmSinhVien
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxTTSV = new System.Windows.Forms.GroupBox();
            this.groupBoxDSSV = new System.Windows.Forms.GroupBox();
            this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lvSinhVIen = new System.Windows.Forms.ListView();
            this.maSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chuyenNganh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenFileDialogHinh = new System.Windows.Forms.OpenFileDialog();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHinh = new System.Windows.Forms.Label();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxTTSV.SuspendLayout();
            this.groupBoxDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxTTSV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxDSSV);
            this.splitContainer1.Size = new System.Drawing.Size(809, 450);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxTTSV
            // 
            this.groupBoxTTSV.Controls.Add(this.lblChuyenNganh);
            this.groupBoxTTSV.Controls.Add(this.lblHinh);
            this.groupBoxTTSV.Controls.Add(this.lblGioiTinh);
            this.groupBoxTTSV.Controls.Add(this.lblLop);
            this.groupBoxTTSV.Controls.Add(this.lblDiaChi);
            this.groupBoxTTSV.Controls.Add(this.lblNgaySinh);
            this.groupBoxTTSV.Controls.Add(this.lblHoTen);
            this.groupBoxTTSV.Controls.Add(this.lblMaSo);
            this.groupBoxTTSV.Controls.Add(this.btnThoat);
            this.groupBoxTTSV.Controls.Add(this.btnMacDinh);
            this.groupBoxTTSV.Controls.Add(this.btnSua);
            this.groupBoxTTSV.Controls.Add(this.btnXoa);
            this.groupBoxTTSV.Controls.Add(this.btnThem);
            this.groupBoxTTSV.Controls.Add(this.checkedListBox1);
            this.groupBoxTTSV.Controls.Add(this.rdNu);
            this.groupBoxTTSV.Controls.Add(this.rdNam);
            this.groupBoxTTSV.Controls.Add(this.pictureBox1);
            this.groupBoxTTSV.Controls.Add(this.btnBrowse);
            this.groupBoxTTSV.Controls.Add(this.comboBox1);
            this.groupBoxTTSV.Controls.Add(this.txtHinh);
            this.groupBoxTTSV.Controls.Add(this.txtDiaChi);
            this.groupBoxTTSV.Controls.Add(this.dtpNgaySinh);
            this.groupBoxTTSV.Controls.Add(this.txtHoTen);
            this.groupBoxTTSV.Controls.Add(this.mtxtMaSo);
            this.groupBoxTTSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTTSV.Name = "groupBoxTTSV";
            this.groupBoxTTSV.Size = new System.Drawing.Size(385, 450);
            this.groupBoxTTSV.TabIndex = 0;
            this.groupBoxTTSV.TabStop = false;
            this.groupBoxTTSV.Text = "Thông Tin Sinh Viên";
            // 
            // groupBoxDSSV
            // 
            this.groupBoxDSSV.Controls.Add(this.lvSinhVIen);
            this.groupBoxDSSV.Location = new System.Drawing.Point(-1, 3);
            this.groupBoxDSSV.Name = "groupBoxDSSV";
            this.groupBoxDSSV.Size = new System.Drawing.Size(406, 447);
            this.groupBoxDSSV.TabIndex = 0;
            this.groupBoxDSSV.TabStop = false;
            this.groupBoxDSSV.Text = "Danh Sách Sinh Viên";
            // 
            // mtxtMaSo
            // 
            this.mtxtMaSo.Location = new System.Drawing.Point(224, 21);
            this.mtxtMaSo.Mask = "SV.00000";
            this.mtxtMaSo.Name = "mtxtMaSo";
            this.mtxtMaSo.Size = new System.Drawing.Size(100, 22);
            this.mtxtMaSo.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(224, 49);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(154, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(224, 77);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(111, 22);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(224, 105);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(154, 22);
            this.txtDiaChi.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CTK31",
            "CTK32",
            "CTK33",
            "CTK34",
            "CTK32CD",
            "CTK33CD",
            "CTK34CD"});
            this.comboBox1.Location = new System.Drawing.Point(224, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(98, 167);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(248, 22);
            this.txtHinh.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(352, 166);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(27, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(98, 195);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 7;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(177, 195);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 7;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Mạng truyền thông",
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Trí tuệ nhân tạo",
            "Hệ thống thông tin",
            "Tin học ứng dụng"});
            this.checkedListBox1.Location = new System.Drawing.Point(108, 218);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(182, 106);
            this.checkedListBox1.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 402);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 36);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(77, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 36);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(148, 402);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 36);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(216, 402);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(74, 36);
            this.btnMacDinh.TabIndex = 9;
            this.btnMacDinh.Text = "Mặc Định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(296, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(65, 36);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lvSinhVIen
            // 
            this.lvSinhVIen.CheckBoxes = true;
            this.lvSinhVIen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maSo,
            this.hoTen,
            this.ngaySinh,
            this.diaChi,
            this.lop,
            this.phai,
            this.chuyenNganh,
            this.hinh});
            this.lvSinhVIen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVIen.GridLines = true;
            this.lvSinhVIen.HideSelection = false;
            this.lvSinhVIen.Location = new System.Drawing.Point(3, 18);
            this.lvSinhVIen.Name = "lvSinhVIen";
            this.lvSinhVIen.Size = new System.Drawing.Size(400, 426);
            this.lvSinhVIen.TabIndex = 10;
            this.lvSinhVIen.UseCompatibleStateImageBehavior = false;
            this.lvSinhVIen.View = System.Windows.Forms.View.Details;
            this.lvSinhVIen.SelectedIndexChanged += new System.EventHandler(this.lvSinhVIen_SelectedIndexChanged);
            // 
            // maSo
            // 
            this.maSo.Text = "Mã số";
            // 
            // hoTen
            // 
            this.hoTen.Text = "Họ tên";
            // 
            // ngaySinh
            // 
            this.ngaySinh.Text = "Ngày sinh";
            // 
            // diaChi
            // 
            this.diaChi.Text = "Địa chỉ";
            // 
            // lop
            // 
            this.lop.Text = "Lớp";
            // 
            // phai
            // 
            this.phai.Text = "Phái";
            // 
            // chuyenNganh
            // 
            this.chuyenNganh.Text = "Chuyên ngành";
            // 
            // hinh
            // 
            this.hinh.Text = "Hình";
            // 
            // OpenFileDialogHinh
            // 
            this.OpenFileDialogHinh.FileName = " ";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(174, 24);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(44, 16);
            this.lblMaSo.TabIndex = 10;
            this.lblMaSo.Text = "Mã số";
            this.lblMaSo.TextChanged += new System.EventHandler(this.asd);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(174, 52);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 16);
            this.lblHoTen.TabIndex = 10;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(155, 82);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(67, 16);
            this.lblNgaySinh.TabIndex = 10;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(174, 108);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(47, 16);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(12, 197);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(54, 16);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblHinh
            // 
            this.lblHinh.AutoSize = true;
            this.lblHinh.Location = new System.Drawing.Point(12, 169);
            this.lblHinh.Name = "lblHinh";
            this.lblHinh.Size = new System.Drawing.Size(34, 16);
            this.lblHinh.TabIndex = 10;
            this.lblHinh.Text = "Hình";
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(12, 218);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(92, 16);
            this.lblChuyenNganh.TabIndex = 10;
            this.lblChuyenNganh.Text = "Chuyên ngành";
            this.lblChuyenNganh.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(174, 136);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(30, 16);
            this.lblLop.TabIndex = 10;
            this.lblLop.Text = "Lớp";
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSinhVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxTTSV.ResumeLayout(false);
            this.groupBoxTTSV.PerformLayout();
            this.groupBoxDSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxTTSV;
        private System.Windows.Forms.GroupBox groupBoxDSSV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtMaSo;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.ListView lvSinhVIen;
        private System.Windows.Forms.ColumnHeader maSo;
        private System.Windows.Forms.ColumnHeader hoTen;
        private System.Windows.Forms.ColumnHeader ngaySinh;
        private System.Windows.Forms.ColumnHeader diaChi;
        private System.Windows.Forms.ColumnHeader lop;
        private System.Windows.Forms.ColumnHeader phai;
        private System.Windows.Forms.ColumnHeader chuyenNganh;
        private System.Windows.Forms.ColumnHeader hinh;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogHinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Label lblHinh;
        private System.Windows.Forms.Label lblLop;
    }
}


namespace DoAnThucTapCoSo
{
    partial class frmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.nudHeSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKieuSapXap = new System.Windows.Forms.ComboBox();
            this.rdbTheoHeSoLuong = new System.Windows.Forms.RadioButton();
            this.rdbTheoNgaySinh = new System.Windows.Forms.RadioButton();
            this.rdbTheoChucVu = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtChucVuDeTimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenDeTimKiem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeSoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbChucVu);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.nudHeSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(88, 72);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(158, 24);
            this.cmbChucVu.TabIndex = 9;
            this.cmbChucVu.SelectedIndexChanged += new System.EventHandler(this.cmbChucVu_SelectedIndexChanged);
            this.cmbChucVu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbChucVu_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(473, 65);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 34);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(361, 26);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(111, 23);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // nudHeSoLuong
            // 
            this.nudHeSoLuong.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudHeSoLuong.Location = new System.Drawing.Point(361, 72);
            this.nudHeSoLuong.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudHeSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeSoLuong.Name = "nudHeSoLuong";
            this.nudHeSoLuong.Size = new System.Drawing.Size(59, 23);
            this.nudHeSoLuong.TabIndex = 6;
            this.nudHeSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hệ số lương:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chức vụ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(88, 29);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(158, 23);
            this.txtHoTen.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 317);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.AllowUserToAddRows = false;
            this.dgvDanhSachNhanVien.AllowUserToDeleteRows = false;
            this.dgvDanhSachNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachNhanVien.ColumnHeadersHeight = 35;
            this.dgvDanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clHoTen,
            this.clNgaySinh,
            this.clChucVu,
            this.clHeSoLuong,
            this.clXoa});
            this.dgvDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(3, 24);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.RowHeadersVisible = false;
            this.dgvDanhSachNhanVien.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachNhanVien.RowTemplate.Height = 30;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(566, 290);
            this.dgvDanhSachNhanVien.TabIndex = 0;
            this.dgvDanhSachNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNhanVien_CellClick);
            // 
            // clHoTen
            // 
            this.clHoTen.HeaderText = "Họ tên";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.Width = 160;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.HeaderText = "Ngày sinh";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.Width = 120;
            // 
            // clChucVu
            // 
            this.clChucVu.HeaderText = "Chức vụ";
            this.clChucVu.Name = "clChucVu";
            this.clChucVu.Width = 120;
            // 
            // clHeSoLuong
            // 
            this.clHeSoLuong.HeaderText = "Hệ số lương";
            this.clHeSoLuong.Name = "clHeSoLuong";
            // 
            // clXoa
            // 
            this.clXoa.HeaderText = "Xóa";
            this.clXoa.Name = "clXoa";
            this.clXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clXoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clXoa.Text = "Xóa";
            this.clXoa.UseColumnTextForButtonValue = true;
            this.clXoa.Width = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSapXep);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbKieuSapXap);
            this.groupBox3.Controls.Add(this.rdbTheoHeSoLuong);
            this.groupBox3.Controls.Add(this.rdbTheoNgaySinh);
            this.groupBox3.Controls.Add(this.rdbTheoChucVu);
            this.groupBox3.Location = new System.Drawing.Point(602, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 162);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sắp xếp";
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(189, 121);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(83, 34);
            this.btnSapXep.TabIndex = 9;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kiểu sắp xếp:";
            // 
            // cmbKieuSapXap
            // 
            this.cmbKieuSapXap.FormattingEnabled = true;
            this.cmbKieuSapXap.Items.AddRange(new object[] {
            "Giảm dần",
            "Tăng dần"});
            this.cmbKieuSapXap.Location = new System.Drawing.Point(28, 127);
            this.cmbKieuSapXap.Name = "cmbKieuSapXap";
            this.cmbKieuSapXap.Size = new System.Drawing.Size(121, 24);
            this.cmbKieuSapXap.TabIndex = 11;
            // 
            // rdbTheoHeSoLuong
            // 
            this.rdbTheoHeSoLuong.AutoSize = true;
            this.rdbTheoHeSoLuong.Location = new System.Drawing.Point(28, 76);
            this.rdbTheoHeSoLuong.Name = "rdbTheoHeSoLuong";
            this.rdbTheoHeSoLuong.Size = new System.Drawing.Size(137, 21);
            this.rdbTheoHeSoLuong.TabIndex = 10;
            this.rdbTheoHeSoLuong.TabStop = true;
            this.rdbTheoHeSoLuong.Text = "Theo hệ số lương";
            this.rdbTheoHeSoLuong.UseVisualStyleBackColor = true;
            // 
            // rdbTheoNgaySinh
            // 
            this.rdbTheoNgaySinh.AutoSize = true;
            this.rdbTheoNgaySinh.Location = new System.Drawing.Point(28, 49);
            this.rdbTheoNgaySinh.Name = "rdbTheoNgaySinh";
            this.rdbTheoNgaySinh.Size = new System.Drawing.Size(86, 21);
            this.rdbTheoNgaySinh.TabIndex = 9;
            this.rdbTheoNgaySinh.TabStop = true;
            this.rdbTheoNgaySinh.Text = "Theo tuổi";
            this.rdbTheoNgaySinh.UseVisualStyleBackColor = true;
            // 
            // rdbTheoChucVu
            // 
            this.rdbTheoChucVu.AutoSize = true;
            this.rdbTheoChucVu.Location = new System.Drawing.Point(28, 22);
            this.rdbTheoChucVu.Name = "rdbTheoChucVu";
            this.rdbTheoChucVu.Size = new System.Drawing.Size(112, 21);
            this.rdbTheoChucVu.TabIndex = 8;
            this.rdbTheoChucVu.TabStop = true;
            this.rdbTheoChucVu.Text = "Theo chức vụ";
            this.rdbTheoChucVu.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTimKiem);
            this.groupBox4.Controls.Add(this.txtChucVuDeTimKiem);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtTenDeTimKiem);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(602, 190);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 144);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(189, 104);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(83, 34);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtChucVuDeTimKiem
            // 
            this.txtChucVuDeTimKiem.Location = new System.Drawing.Point(95, 67);
            this.txtChucVuDeTimKiem.Name = "txtChucVuDeTimKiem";
            this.txtChucVuDeTimKiem.Size = new System.Drawing.Size(158, 23);
            this.txtChucVuDeTimKiem.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Chức vụ:";
            // 
            // txtTenDeTimKiem
            // 
            this.txtTenDeTimKiem.Location = new System.Drawing.Point(95, 28);
            this.txtTenDeTimKiem.Name = "txtTenDeTimKiem";
            this.txtTenDeTimKiem.Size = new System.Drawing.Size(158, 23);
            this.txtTenDeTimKiem.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Họ tên:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnXoa);
            this.groupBox5.Controls.Add(this.txtTuKhoa);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(602, 340);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 100);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Xóa";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(189, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 34);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(95, 28);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(158, 23);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Từ khóa:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(697, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu  lại";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(791, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 34);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(602, 446);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 34);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Làm tươi";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 495);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeSoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nudHeSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKieuSapXap;
        private System.Windows.Forms.RadioButton rdbTheoHeSoLuong;
        private System.Windows.Forms.RadioButton rdbTheoNgaySinh;
        private System.Windows.Forms.RadioButton rdbTheoChucVu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtChucVuDeTimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenDeTimKiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHeSoLuong;
        private System.Windows.Forms.DataGridViewButtonColumn clXoa;
        private System.Windows.Forms.Button btnRefresh;
    }
}


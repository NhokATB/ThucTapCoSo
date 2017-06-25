namespace DoAnThucTapCoSo
{
    partial class frmManageEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.nudCoeffienceSalary = new System.Windows.Forms.NumericUpDown();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListEmployee = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTypeSort = new System.Windows.Forms.ComboBox();
            this.rdbCoefficienceSalary = new System.Windows.Forms.RadioButton();
            this.rdbBirthDay = new System.Windows.Forms.RadioButton();
            this.rdbPosition = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAdvancedSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnRemoveAdvanced = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoeffienceSalary)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.cmbPosition);
            this.groupBox1.Controls.Add(this.nudCoeffienceSalary);
            this.groupBox1.Controls.Add(this.btnAddEmployee);
            this.groupBox1.Controls.Add(this.dtpBirthDay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(85, 92);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(158, 24);
            this.cmbPosition.TabIndex = 11;
            // 
            // nudCoeffienceSalary
            // 
            this.nudCoeffienceSalary.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCoeffienceSalary.Location = new System.Drawing.Point(398, 89);
            this.nudCoeffienceSalary.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudCoeffienceSalary.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCoeffienceSalary.Name = "nudCoeffienceSalary";
            this.nudCoeffienceSalary.Size = new System.Drawing.Size(59, 23);
            this.nudCoeffienceSalary.TabIndex = 10;
            this.nudCoeffienceSalary.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddEmployee.Location = new System.Drawing.Point(475, 89);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(83, 45);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Thêm";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDay.Location = new System.Drawing.Point(398, 34);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(160, 23);
            this.dtpBirthDay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hệ số lương:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chức vụ:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 23);
            this.txtName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListEmployee);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 317);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvListEmployee
            // 
            this.dgvListEmployee.AllowUserToAddRows = false;
            this.dgvListEmployee.AllowUserToDeleteRows = false;
            this.dgvListEmployee.AllowUserToResizeRows = false;
            this.dgvListEmployee.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListEmployee.ColumnHeadersHeight = 35;
            this.dgvListEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clHoTen,
            this.clNgaySinh,
            this.clChucVu,
            this.clHeSoLuong});
            this.dgvListEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListEmployee.Location = new System.Drawing.Point(3, 22);
            this.dgvListEmployee.MultiSelect = false;
            this.dgvListEmployee.Name = "dgvListEmployee";
            this.dgvListEmployee.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvListEmployee.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListEmployee.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListEmployee.RowTemplate.Height = 30;
            this.dgvListEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListEmployee.Size = new System.Drawing.Size(613, 292);
            this.dgvListEmployee.TabIndex = 1;
            // 
            // clSTT
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clSTT.DefaultCellStyle = dataGridViewCellStyle2;
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.Width = 40;
            // 
            // clHoTen
            // 
            this.clHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clHoTen.DefaultCellStyle = dataGridViewCellStyle3;
            this.clHoTen.HeaderText = "Họ tên";
            this.clHoTen.Name = "clHoTen";
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.HeaderText = "Ngày sinh";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.Width = 140;
            // 
            // clChucVu
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clChucVu.DefaultCellStyle = dataGridViewCellStyle4;
            this.clChucVu.HeaderText = "Chức vụ";
            this.clChucVu.Name = "clChucVu";
            this.clChucVu.Width = 140;
            // 
            // clHeSoLuong
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.clHeSoLuong.DefaultCellStyle = dataGridViewCellStyle5;
            this.clHeSoLuong.HeaderText = "Hệ số lương";
            this.clHeSoLuong.Name = "clHeSoLuong";
            this.clHeSoLuong.Width = 97;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox3.Controls.Add(this.rdbName);
            this.groupBox3.Controls.Add(this.btnSort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbTypeSort);
            this.groupBox3.Controls.Add(this.rdbCoefficienceSalary);
            this.groupBox3.Controls.Add(this.rdbBirthDay);
            this.groupBox3.Controls.Add(this.rdbPosition);
            this.groupBox3.Location = new System.Drawing.Point(604, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 148);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sắp xếp";
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Location = new System.Drawing.Point(200, 58);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(83, 21);
            this.rdbName.TabIndex = 13;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Theo tên";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSort.Location = new System.Drawing.Point(200, 89);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(83, 45);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kiểu sắp xếp:";
            // 
            // cmbTypeSort
            // 
            this.cmbTypeSort.FormattingEnabled = true;
            this.cmbTypeSort.Items.AddRange(new object[] {
            "Giảm dần",
            "Tăng dần"});
            this.cmbTypeSort.Location = new System.Drawing.Point(23, 110);
            this.cmbTypeSort.Name = "cmbTypeSort";
            this.cmbTypeSort.Size = new System.Drawing.Size(121, 24);
            this.cmbTypeSort.TabIndex = 11;
            // 
            // rdbCoefficienceSalary
            // 
            this.rdbCoefficienceSalary.AutoSize = true;
            this.rdbCoefficienceSalary.Location = new System.Drawing.Point(32, 58);
            this.rdbCoefficienceSalary.Name = "rdbCoefficienceSalary";
            this.rdbCoefficienceSalary.Size = new System.Drawing.Size(137, 21);
            this.rdbCoefficienceSalary.TabIndex = 10;
            this.rdbCoefficienceSalary.TabStop = true;
            this.rdbCoefficienceSalary.Text = "Theo hệ số lương";
            this.rdbCoefficienceSalary.UseVisualStyleBackColor = true;
            // 
            // rdbBirthDay
            // 
            this.rdbBirthDay.AutoSize = true;
            this.rdbBirthDay.Location = new System.Drawing.Point(200, 26);
            this.rdbBirthDay.Name = "rdbBirthDay";
            this.rdbBirthDay.Size = new System.Drawing.Size(86, 21);
            this.rdbBirthDay.TabIndex = 9;
            this.rdbBirthDay.TabStop = true;
            this.rdbBirthDay.Text = "Theo tuổi";
            this.rdbBirthDay.UseVisualStyleBackColor = true;
            // 
            // rdbPosition
            // 
            this.rdbPosition.AutoSize = true;
            this.rdbPosition.Location = new System.Drawing.Point(32, 26);
            this.rdbPosition.Name = "rdbPosition";
            this.rdbPosition.Size = new System.Drawing.Size(112, 21);
            this.rdbPosition.TabIndex = 8;
            this.rdbPosition.TabStop = true;
            this.rdbPosition.Text = "Theo chức vụ";
            this.rdbPosition.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox4.Controls.Add(this.btnAdvancedSearch);
            this.groupBox4.Controls.Add(this.txtKeyword);
            this.groupBox4.Controls.Add(this.btnRemoveAdvanced);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(648, 188);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 177);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm và xóa";
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAdvancedSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdvancedSearch.Location = new System.Drawing.Point(171, 107);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(83, 45);
            this.btnAdvancedSearch.TabIndex = 15;
            this.btnAdvancedSearch.Text = "Tìm Kiếm";
            this.btnAdvancedSearch.UseVisualStyleBackColor = false;
            this.btnAdvancedSearch.Click += new System.EventHandler(this.btnAdvancedSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(28, 58);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(226, 23);
            this.txtKeyword.TabIndex = 12;
            // 
            // btnRemoveAdvanced
            // 
            this.btnRemoveAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveAdvanced.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveAdvanced.Location = new System.Drawing.Point(28, 107);
            this.btnRemoveAdvanced.Name = "btnRemoveAdvanced";
            this.btnRemoveAdvanced.Size = new System.Drawing.Size(83, 45);
            this.btnRemoveAdvanced.TabIndex = 13;
            this.btnRemoveAdvanced.Text = "Xóa";
            this.btnRemoveAdvanced.UseVisualStyleBackColor = false;
            this.btnRemoveAdvanced.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Từ khóa:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(746, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 49);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu  lại";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(843, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 49);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(648, 422);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 49);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(938, 495);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageEmployee_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoeffienceSalary)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTypeSort;
        private System.Windows.Forms.RadioButton rdbCoefficienceSalary;
        private System.Windows.Forms.RadioButton rdbBirthDay;
        private System.Windows.Forms.RadioButton rdbPosition;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvListEmployee;
        private System.Windows.Forms.NumericUpDown nudCoeffienceSalary;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHeSoLuong;
        private System.Windows.Forms.Button btnRemoveAdvanced;
        private System.Windows.Forms.Button btnAdvancedSearch;
    }
}


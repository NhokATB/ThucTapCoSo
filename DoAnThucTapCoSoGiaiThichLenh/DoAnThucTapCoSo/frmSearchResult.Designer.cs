namespace DoAnThucTapCoSo
{
    partial class frmSearchResult
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListEmployee = new System.Windows.Forms.DataGridView();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.clViTriTrongDanhSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListEmployee);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 317);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên liên quan đến từ khóa";
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
            this.clViTriTrongDanhSach,
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
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblConfirm.Location = new System.Drawing.Point(46, 346);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(560, 29);
            this.lblConfirm.TabIndex = 10;
            this.lblConfirm.Text = "Bạn có chắc muốn xóa những nhân viên này không?";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYes.Location = new System.Drawing.Point(397, 388);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 46);
            this.btnYes.TabIndex = 11;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNo.Location = new System.Drawing.Point(506, 388);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 46);
            this.btnNo.TabIndex = 12;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // clViTriTrongDanhSach
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clViTriTrongDanhSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.clViTriTrongDanhSach.HeaderText = "Vị trí";
            this.clViTriTrongDanhSach.Name = "clViTriTrongDanhSach";
            this.clViTriTrongDanhSach.Width = 60;
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
            this.clNgaySinh.Width = 120;
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
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(529, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 46);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(643, 446);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearchResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả tìm kiếm";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListEmployee;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clViTriTrongDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHeSoLuong;
        private System.Windows.Forms.Button btnOk;
    }
}
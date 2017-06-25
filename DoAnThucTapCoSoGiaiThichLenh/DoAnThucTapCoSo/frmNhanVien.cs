using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DoAnThucTapCoSo
{
    public partial class frmNhanVien : Form
    {
        private DanhSachNhanVien danhSachNhanVien;
        private DanhSachNhanVien ketQuaTimKiem;

        private string filePath = @"..\..\Data\DuLieuNhanVien.txt";

        private bool isSaved;

        public frmNhanVien()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            isSaved = true;
            cmbKieuSapXap.SelectedIndex = 0;
            danhSachNhanVien = new DoAnThucTapCoSo.DanhSachNhanVien();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromFile(filePath);
            ShowDataToDatagridView(this.danhSachNhanVien);
            cmbChucVu.DataSource = danhSachNhanVien.danhSachChucVu;
        }

        public bool ValidateForm()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cmbChucVu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chức vụ nhân viên, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void LoadDataFromFile(string filePath)// Đọc dữ liệu từ file và đưa lên datagridview
        {
            //try
            {
                StreamReader sr = new StreamReader(filePath, Encoding.UTF8);

                int countLine = 0;

                string thongTinDocDuoc;

                while ((thongTinDocDuoc = sr.ReadLine()) != null)
                {
                    countLine++;
                    if (thongTinDocDuoc.Contains("Họ và tên\t\tChức vụ\t\tNgày sinh\tHệ số lương")) continue;

                    if (thongTinDocDuoc == "") continue;

                    string[] nhanVienString = thongTinDocDuoc.Split('\t');

                    string[] thongTinNhanVien = new string[nhanVienString.Length];

                    int j = 0;
                    foreach (string item in nhanVienString)
                    {
                        if (item == "")
                        {
                            continue;
                        }
                        else
                        {
                            thongTinNhanVien[j] = item.Trim();
                            j++;
                        }
                    }

                    NgayGio ngaySinh;
                    NhanVien nhanVien;
                    try
                    {
                        ngaySinh = NgayGio.Parse(thongTinNhanVien[2]);
                       
                    }
                    catch (NgayGioException)
                    {

                        MessageBox.Show("Tại dòng " + countLine + ": Ngày sinh không hợp lệ\n" + NgayGioException.ErrorMessage, "Lỗi định dạng ngày giờ khi lấy dữ liệu từ file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sr.Close();
                        return;
                    }
                    try
                    {
                        nhanVien = new NhanVien(thongTinNhanVien[0], thongTinNhanVien[1], ngaySinh, double.Parse(thongTinNhanVien[3]));

                        danhSachNhanVien.AddLast(nhanVien);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tại dòng " + countLine + ":\n"+"Hệ số lương phải là số", "Lỗi định dạng hệ số lương khi lấy dữ liệu từ file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sr.Close();
                        return;
                    }
                   
                    thongTinDocDuoc = sr.ReadLine();

                }

                sr.Close();

                ShowDataToDatagridView(this.danhSachNhanVien);

            }
            
        }

        private void ShowDataToDatagridView(DanhSachNhanVien dsnv)
        {
            dgvDanhSachNhanVien.Rows.Clear();
            for (NhanVien emp = dsnv.NhanVienDau; emp != null; emp = emp.next)
            {
                dgvDanhSachNhanVien.Rows.Add(emp.HoTen, emp.NgaySinh.ToString(), emp.ChucVu, emp.HeSoLuong);
            }
        }

        public string ThongTinNhungNhanVienLienQuanTuKhoa(string keyWord)
        {
            int i = 1;
            string s = "";
            for (NhanVien nv = danhSachNhanVien.NhanVienDau; nv != null; nv = nv.next)
            {
                if (StringProcessing.ConvertToUnSign(nv.HoTen.ToLower()).Contains(keyWord) || nv.NgaySinh.ToString().Contains(keyWord))
                {
                    s += "Nhân viên " + i.ToString() + "\n" + nv.ToString() + "\n";
                    i++;
                }
            }
            return s;
        }

        private string LayThuocTinhCanSapXep()
        {
            string propertyName = null;

            if (rdbTheoChucVu.Checked)
                propertyName = "ChucVu";
            else if (rdbTheoNgaySinh.Checked)
                propertyName = "NgaySinh";
            else if (rdbTheoHeSoLuong.Checked)
                propertyName = "HeSoLuong";

            return propertyName;
        }

        private void Save()
        {
            FileStream fs = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Họ và tên\t\tChức vụ\t\tNgày sinh\tHệ số lương");

            for (NhanVien emp = danhSachNhanVien.NhanVienDau; emp != null; emp = emp.next)
            {
                if (emp.HoTen.Length < 16)
                {
                    if (emp.ChucVu.Length < 8)
                    {
                        sw.WriteLine(emp.HoTen + "\t\t" + emp.ChucVu + "\t\t" + emp.NgaySinh.ToString() + "\t" + emp.HeSoLuong + "\n");
                    }
                    else
                        sw.WriteLine(emp.HoTen + "\t\t" + emp.ChucVu + "\t" + emp.NgaySinh.ToString() + "\t" + emp.HeSoLuong + "\n");
                }
                else if (emp.ChucVu.Length < 8)
                {
                    sw.WriteLine(emp.HoTen + "\t" + emp.ChucVu + "\t\t" + emp.NgaySinh.ToString() + "\t" + emp.HeSoLuong + "\n");
                }
                else
                {
                    sw.WriteLine(emp.HoTen + "\t" + emp.ChucVu + "\t" + emp.NgaySinh.ToString() + "\t" + emp.HeSoLuong + "\n");
                }

            }

            sw.Close();

            MessageBox.Show("Lưu thành công!", "Thông báo");

            isSaved = true;
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {

            string propertyName;

            if ((propertyName = LayThuocTinhCanSapXep()) != null)
            {
                danhSachNhanVien.Sort(propertyName, cmbKieuSapXap.SelectedIndex);
                ShowDataToDatagridView(this.danhSachNhanVien);

                isSaved = false;
            }
            else MessageBox.Show("Bạn chưa chọn tiêu chí sắp xếp, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string propertyName;

                NgayGio ngaySinh = new DoAnThucTapCoSo.NgayGio(dtpNgaySinh.Value.Day, dtpNgaySinh.Value.Month, dtpNgaySinh.Value.Year);

                NhanVien employee = new NhanVien(txtHoTen.Text, cmbChucVu.Text, ngaySinh, double.Parse(nudHeSoLuong.Value.ToString()));

                if ((propertyName = LayThuocTinhCanSapXep()) != null)
                {
                    danhSachNhanVien.Insert(employee, propertyName, cmbKieuSapXap.SelectedIndex);
                }
                else
                {
                    danhSachNhanVien.AddLast(employee);
                }

                // Sắp xếp lại danh sách trong trường hợp chưa sắp xếp
                if ((propertyName = LayThuocTinhCanSapXep()) != null)
                    danhSachNhanVien.Sort(propertyName, cmbKieuSapXap.SelectedIndex);

                ShowDataToDatagridView(this.danhSachNhanVien);

                isSaved = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!string.IsNullOrEmpty(ThongTinNhungNhanVienLienQuanTuKhoa(txtTuKhoa.Text)))
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa những nhân viên này không?\n\n" + ThongTinNhungNhanVienLienQuanTuKhoa(txtTuKhoa.Text), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        danhSachNhanVien.DeleteMany(txtTuKhoa.Text);

                        ShowDataToDatagridView(this.danhSachNhanVien);

                        isSaved = false;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có thông tin liên quan với từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string[] propertyNames = new string[2];

            string[] values = new string[2];
            int i = 0;

            if (txtChucVuDeTimKiem.Text == "" && txtTenDeTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu để tìm kiếm, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtTenDeTimKiem.Text != "")
            {
                propertyNames[i] = "HoTen";
                values[i] = txtTenDeTimKiem.Text;
                i++;
            }
            if (txtChucVuDeTimKiem.Text != "")
            {
                propertyNames[i] = "ChucVu";
                values[i] = txtChucVuDeTimKiem.Text;
            }

            NhanVien employee = danhSachNhanVien.SearchFirst(propertyNames, values);
            if (employee == null)
                MessageBox.Show("Không tìm thấy nhân viên nào!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                int index = danhSachNhanVien.IndexOf(employee);
                MessageBox.Show(employee.ToString() + "Vị trí trong danh sách: " + (index + 1).ToString(), "kết quả tìm kiếm");
            }

            //this.ketQuaTimKiem = danhSachNhanVien.SearchMany(propertyNames, values);
            //int count = ketQuaTimKiem.Count();

            //if (count == 0)
            //{
            //    MessageBox.Show("Không tìm thấy nhân viên nào!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    ShowDataToDatagridView(this.danhSachNhanVien);
            //}

            //else
            //{
            //    ShowDataToDatagridView(this.ketQuaTimKiem);
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                if (MessageBox.Show("Bạn có muốn lưu dữ liệu lại trước khi thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Save();
                }
            }
        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    NhanVien employee = new DoAnThucTapCoSo.NhanVien();
                    employee.HoTen = dgvDanhSachNhanVien.SelectedCells[0].OwningRow.Cells["clHoTen"].Value.ToString();
                    employee.NgaySinh = NgayGio.Parse(dgvDanhSachNhanVien.SelectedCells[0].OwningRow.Cells["clNgaySinh"].Value.ToString());
                    employee.ChucVu = dgvDanhSachNhanVien.SelectedCells[0].OwningRow.Cells["clChucVu"].Value.ToString();
                    employee.HeSoLuong = double.Parse(dgvDanhSachNhanVien.SelectedCells[0].OwningRow.Cells["clHeSoLuong"].Value.ToString());

                    danhSachNhanVien.Delete(employee);

                    ShowDataToDatagridView(this.danhSachNhanVien);

                    isSaved = false;
                }
            }
        }

        private void cmbChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudHeSoLuong.Value = (decimal)danhSachNhanVien.HeSoLuongCuaChucVu(cmbChucVu.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDanhSachNhanVien.Rows.Clear();
            LoadDataFromFile(filePath);
        }
    }
}

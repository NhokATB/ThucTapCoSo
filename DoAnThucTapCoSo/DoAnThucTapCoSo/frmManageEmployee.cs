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
    public partial class frmManageEmployee : Form
    {
        private ListEmployee listEmployee;

        private string filePath = @"..\..\Data\Data.txt";

        private bool isSaved;

        public frmManageEmployee()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            isSaved = true;
            cmbTypeSort.SelectedIndex = 0;
            listEmployee = new DoAnThucTapCoSo.ListEmployee();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromFile(filePath);
            ShowListEmployeeToDatagridView(this.listEmployee);
            cmbPosition.DataSource = ListEmployee.PositionArray;
        }

        public bool ValidateForm()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cmbPosition.Text == "")
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

                string readInformation;

                while ((readInformation = sr.ReadLine()) != null)
                {
                    countLine++;
                    if (readInformation.Contains("Họ và tên\t\tChức vụ\t\t\tNgày sinh\t\tHệ số lương")) continue;

                    if (readInformation == "") continue;

                    string[] splitedString = readInformation.Split('\t');

                    string[] employeeInformation = new string[splitedString.Length];

                    int j = 0;
                    foreach (string item in splitedString)
                    {
                        if (item == "")
                        {
                            continue;
                        }
                        else
                        {
                            employeeInformation[j] = item.Trim();
                            j++;
                        }
                    }

                    Date birthDay;
                    Node<Employee> employee;
                    birthDay = Date.Parse(employeeInformation[2]);
                    employee = new Node<Employee>()
                    {
                        Data = new Employee(employeeInformation[0],
                            employeeInformation[1],
                            birthDay,
                            double.Parse(employeeInformation[3])),
                    };
                    listEmployee.AddLast(employee);
                    //try
                    //{
                    //    birthDay = Date.Parse(employeeInformation[2]);

                    //}
                    //catch (DayException)
                    //{

                    //    MessageBox.Show("Tại dòng " + countLine + " trong file: Ngày sinh không hợp lệ\n" + DayException.ErrorMessage, "Lỗi định dạng ngày giờ khi lấy dữ liệu từ file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    sr.Close();
                    //    return;
                    //}
                    //try
                    //{
                    //    employee = new Node<Employee>()
                    //    {
                    //        Data = new Employee(employeeInformation[0],
                    //        employeeInformation[1],
                    //        birthDay,
                    //        double.Parse(employeeInformation[3])),
                    //    };

                    //    listEmployee.AddLast(employee);
                    //}
                    //catch (Exception)
                    //{
                    //    MessageBox.Show("Tại dòng " + countLine + " trong file:\n" + "Hệ số lương phải là số", "Lỗi định dạng hệ số lương khi lấy dữ liệu từ file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    sr.Close();
                    //    return;
                    //}

                    readInformation = sr.ReadLine();

                }

                sr.Close();

                ShowListEmployeeToDatagridView(this.listEmployee);
            }

        }

        private void ShowListEmployeeToDatagridView(ListEmployee listEmployee)
        {
            dgvListEmployee.Rows.Clear();
            for (Node<Employee> employee = listEmployee.FirstEmployee; employee != null; employee = employee.Next)
            {
                dgvListEmployee.Rows.Add(dgvListEmployee.Rows.Count + 1, employee.Data.Name, employee.Data.BirthDay.ToString(), employee.Data.Position, employee.Data.CoefficienceSalary);
            }
        }

        private void WriteToFile(StreamWriter sw)
        {
            sw.WriteLine("Họ và tên\t\tChức vụ\t\t\tNgày sinh\t\tHệ số lương");
            for (Node<Employee> employee = listEmployee.FirstEmployee; employee != null; employee = employee.Next)
            {
                if (employee.Data.Name.Length < 16)
                {
                    if (employee.Data.Position.Length < 8)
                    {
                        sw.WriteLine(employee.Data.Name + "\t\t" + employee.Data.Position + "\t\t\t" + employee.Data.BirthDay.ToString() + "\t\t" + employee.Data.CoefficienceSalary + "\n");
                    }
                    else
                        sw.WriteLine(employee.Data.Name + "\t\t" + employee.Data.Position + "\t\t" + employee.Data.BirthDay.ToString() + "\t\t" + employee.Data.CoefficienceSalary + "\n");
                }
                else if (employee.Data.Position.Length < 8)
                {
                    sw.WriteLine(employee.Data.Name + "\t" + employee.Data.Position + "\t\t\t" + employee.Data.BirthDay.ToString() + "\t\t" + employee.Data.CoefficienceSalary + "\n");
                }
                else
                {
                    sw.WriteLine(employee.Data.Name + "\t" + employee.Data.Position + "\t\t" + employee.Data.BirthDay.ToString() + "\t\t" + employee.Data.CoefficienceSalary + "\n");
                }

            }
        }//Ghi thông tin nhân viên từ danh sách nhân viên ra file text

        private void Save()
        {
            FileStream fs = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            WriteToFile(sw);

            sw.Close();

            MessageBox.Show("Lưu thành công!", "Thông báo");

            isSaved = true;
        }

        public string EmployeeRelateWithKeyword(string keyword)
        {
            int i = 1;
            string s = "";
            for (Node<Employee> employee = listEmployee.FirstEmployee; employee != null; employee = employee.Next)
            {
                if (StringProcessing.ConvertToUnSign(employee.Data.Name.ToLower()).Contains(keyword) || employee.Data.BirthDay.ToString().Contains(keyword))
                {
                    s += "Nhân viên " + i.ToString() + "\n" + employee.Data.ToString() + "\n";
                    i++;
                }
            }
            return s;
        }

        private string GetPropertyToSort()
        {
            string propertyName = "";

            if (rdbName.Checked)
                propertyName = "Name";
            else if (rdbPosition.Checked)
                propertyName = "Position";
            else if (rdbBirthDay.Checked)
                propertyName = "BirthDay";
            else if (rdbCoefficienceSalary.Checked)
                propertyName = "CoefficienceSalary";

            return propertyName;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string propertyName;

            if ((propertyName = GetPropertyToSort()) != "")
            {
                listEmployee.Sort(propertyName, cmbTypeSort.SelectedIndex);

                ShowListEmployeeToDatagridView(this.listEmployee);

                isSaved = false;
            }
            else MessageBox.Show("Bạn chưa chọn tiêu chí sắp xếp, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string propertyName;

                Date birthDay = new DoAnThucTapCoSo.Date(dtpBirthDay.Value.Day, dtpBirthDay.Value.Month, dtpBirthDay.Value.Year);

                Node<Employee> employee = new Node<Employee>()
                {
                    Data = new Employee(txtName.Text.Trim(),
                    cmbPosition.Text,
                    birthDay,
                    double.Parse(nudCoeffienceSalary.Value.ToString()))
                };

                if ((propertyName = GetPropertyToSort()) != "")
                {
                    listEmployee.AddLast(employee);
                    listEmployee.Sort(propertyName, cmbTypeSort.SelectedIndex);
                }
                else
                {
                    listEmployee.AddLast(employee);
                }

                ShowListEmployeeToDatagridView(this.listEmployee);

                isSaved = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ListEmployee searchResult = listEmployee.SearchMultiple(txtKeyword.Text);
                if (searchResult.Count() == 0)
                    MessageBox.Show("Không tìm thấy nhân viên nào có liên quan với từ khóa!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    string allEmployee = "";

                    for (Node<Employee> employee = searchResult.FirstEmployee; employee != null; employee = employee.Next)
                    {
                        allEmployee += employee.Data.ToString() + "Vị trí trong danh sách: " + employee.OrderNumber + "\n\n";
                    }

                    if (MessageBox.Show("Bạn có chắc muốn xóa những nhân viên này không?\n\n" + allEmployee, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        listEmployee.RemoveMultiple(txtKeyword.Text);

                        ShowListEmployeeToDatagridView(this.listEmployee);

                        MessageBox.Show("Xóa thành công!", "Thông báo");

                        isSaved = false;
                    }

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtKeyword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa để tìm kiếm, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //{
            //    Node<Employee> employee = listEmployee.SearchFirst(txtKeywordToSearch.Text);
            //    if (employee == null)
            //        MessageBox.Show("Không tìm thấy nhân viên nào!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    else
            //    {
            //        int index = listEmployee.IndexOf(employee);
            //        MessageBox.Show("Nhân viên đầu tiên liên quan đến từ khóa:\n" + employee.Data.ToString() + "Vị trí trong danh sách: " + (index + 1), "kết quả tìm kiếm");
            //    }
            //}

            ListEmployee searchResult = listEmployee.SearchMultiple(txtKeyword.Text);
            if (searchResult.Count() == 0)
                MessageBox.Show("Không tìm thấy nhân viên nào!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string allEmployee = "";

                for (Node<Employee> employee = searchResult.FirstEmployee; employee != null; employee = employee.Next)
                {
                    allEmployee += employee.Data.ToString() + "Vị trí trong danh sách:" + employee.OrderNumber + "\n\n";
                }

                MessageBox.Show("Tất cả nhân viên liên quan đến từ khóa:\n\n" + allEmployee, "kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvListEmployee.Rows.Clear();
            listEmployee.Clear();
            LoadDataFromFile(filePath);
        }

        private void cmbPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmManageEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                if (MessageBox.Show("Bạn có muốn lưu dữ liệu lại trước khi thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Save();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ListEmployee searchResult = listEmployee.SearchMultiple(txtKeyword.Text);
                if (searchResult.Count() == 0)
                    MessageBox.Show("Không tìm thấy nhân viên nào có liên quan với từ khóa!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (searchResult.Count() == 1)
                    {
                        string allEmployee = "";

                        allEmployee += searchResult.FirstEmployee.Data.ToString() + "Vị trí trong danh sách:" + searchResult.FirstEmployee.OrderNumber + "\n\n";

                        if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?\n\n" + allEmployee, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            listEmployee.Remove(searchResult.FirstEmployee);

                            ShowListEmployeeToDatagridView(this.listEmployee);

                            isSaved = false;
                        }
                    }


                    else
                    {
                        
                        frmSearchResult frmResult = new DoAnThucTapCoSo.frmSearchResult(searchResult,"Delete");
                        frmResult.ShowDialog();
                        if (frmResult.DeleteConfirm)
                        {
                            listEmployee.RemoveMultiple(txtKeyword.Text);

                            ShowListEmployeeToDatagridView(this.listEmployee);

                            MessageBox.Show("Xóa thành công!", "Thông báo");

                            isSaved = false;
                        }

                    }
                }
            }
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa để tìm kiếm, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListEmployee searchResult = listEmployee.SearchMultiple(txtKeyword.Text);
            if (searchResult.Count() == 0)
                MessageBox.Show("Không tìm thấy nhân viên nào!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (searchResult.Count() == 1)
                {
                    string allEmployee = "";

                    allEmployee += searchResult.FirstEmployee.Data.ToString() + "Vị trí trong danh sách:" + searchResult.FirstEmployee.OrderNumber + "\n\n";

                    MessageBox.Show(allEmployee, "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmSearchResult frmResult = new DoAnThucTapCoSo.frmSearchResult(searchResult, "Search");
                    frmResult.ShowDialog();
                    
                }
            }
        }
    }
}

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

        private bool isChanged;


        //Hàm khởi tạo form quản lí nhân viên, khi chay chuong trinh ham nay se dc goi dau tien
        public frmManageEmployee()
        {
            InitializeComponent();//Hàm khởi tạo các thành phần cho form (khi kéo thả trên form các thành phần(button, textbox...) sẽ tự động được thêm trong hàm này)

            isChanged = true;//biến để lưu lại trạng thái dữ liệu có bị thay đổi hay không(nếu có thêm xóa thì biến này giá trị sẽ là false)

            cmbTypeSort.SelectedIndex = 0;//Cho mặc định thành phần dc chon lúc đầu của combobox kieu sap xep là giảm dần

            listEmployee = new DoAnThucTapCoSo.ListEmployee();//Tạo mới một danh sách nhân viên rỗng

            LoadDataFromFile(filePath);//Gọi hàm đọc dữ liệu

            ShowListEmployeeToDatagridView(this.listEmployee);//Goi hàm hiển thị dữ liệu lên datagridview

            cmbPosition.DataSource = ListEmployee.PositionArray;//Gán datasource của combobox chức vụ = 1 mảng kiểu string(ListEmployee.PositionArray) để khi click vào có các giá trị sổ xuống cho mình chọn
        }


        //Hàm kiểm tra thong tin đã nhap đầy đủ trước khi thêm hay chưa
        public bool ValidateForm()
        {
            if (txtName.Text == "")//Kiểm tra đã nhập tên hay chưa nếu chưa thì trả về false
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cmbPosition.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chức vụ nhân viên, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //nếu đã nhập cả hai thì trả về true
            return true;
        }

        private void LoadDataFromFile(string filePath)// Đọc dữ liệu từ file và đưa lên datagridview
        {
            //try
            {
                StreamReader sr = new StreamReader(filePath, Encoding.UTF8);//tạo một streamreader để đọc file theo đường dẫn là biến filePath với kiểu mã UTF8 để đọc tiếng việt có dấu


                string readInformation;//biến để lưu thông tin đọc đc từng dòng

                while ((readInformation = sr.ReadLine()) != null)//trong khi còn dòng để đọc (sr.readline: lấy ra một dòng trong file text)
                {
                    if (readInformation.Contains("Họ và tên\t\tChức vụ\t\t\tNgày sinh\t\tHệ số lương")) continue;//Nếu thông tin đọc dc có chứa chuỗi trong ngoặc (tức là dòng đầu tiên trong file text) thì bỏ qua các lệnh ở dưới và quay lại lệnh while

                    string[] splitedString = readInformation.Split('\t');//Cắt chuỗi đọc dc bằng hàm split và bỏ wa kí tự \t để tách các thông tin của nhân viên ra
                    //ví dụ: readInformation = "nhok kon nguyen\t\tTổng giám đốc\t\t19/06/2017\t\t12"
                    /* thì splitedString[]:
                     splitedString[0] = "nhok kon nguyen"
                     splitedString[0] = ""
                     splitedString[0] = "Tổng giám đốc"
                     splitedString[0] = ""
                     splitedString[0] = "19/06/2017"
                     splitedString[0] = ""
                     splitedString[0] = "12"
                     */

                    string[] employeeInformation = new string[splitedString.Length];

                    int j = 0;
                    //duyệt từng phần tử của mảng splitedString nếu rỗng thì bỏ wa, khác rổng thì thêm vào mảng employeeInformation
                    foreach (string item in splitedString)
                    {
                        if (item == "")
                        {
                            continue;
                        }
                        else
                        {
                            employeeInformation[j] = item;
                            j++;
                        }
                    }


                    Date birthDay;
                    Node<Employee> employee;
                    birthDay = Date.Parse(employeeInformation[2]);

                    //tạo một node để thêm vào listEmployee
                    employee = new Node<Employee>()
                    {
                        Data = new Employee(employeeInformation[0],
                            employeeInformation[1],
                            birthDay,
                            double.Parse(employeeInformation[3])),
                        Next = null
                    };

                    //Thêm vào danh sách
                    listEmployee.AddLast(employee);

                    //Đọc dòng tiếp theo
                    readInformation = sr.ReadLine();

                }

                //dóng file
                sr.Close();

            }

        }


        //Hiển thị dữ liệu lên datagridview
        private void ShowListEmployeeToDatagridView(ListEmployee listEmployee)
        { 
            //đầu tiên xóa tất cả dòng đang có trong datagridview
            dgvListEmployee.Rows.Clear();
            //duyệt wa tung phan tử va them vao từng dong cua datagridview
            for (Node<Employee> employee = listEmployee.FirstEmployee; employee != null; employee = employee.Next)
            {
                dgvListEmployee.Rows.Add(dgvListEmployee.Rows.Count + 1, employee.Data.Name, employee.Data.BirthDay.ToString(), employee.Data.Position, employee.Data.CoefficienceSalary);
            }
        }


        //Ghi thông tin nhân viên từ danh sách nhân viên ra file text
        private void WriteToFile(StreamWriter sw)
        {
            //sw.writeline la ghi thong tin len 1 dong
            //cac dieu kien if la de dinh dang dong cho dep
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
        }


        //Chuc nang: chỉ đơn giản là gọi hàm WriteToFile() để ghi thông tin nhân viên từ danh sách nhân viên ra file text va thong bao luu thanh cong
        private void Save()
        {
            FileStream fs = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            WriteToFile(sw);

            sw.Close();

            MessageBox.Show("Lưu thành công!", "Thông báo");//hien thi hop thoai thong bao

            isChanged = true;
        }


        private string GetPropertyToSort()//khi nguoi dung chon mot thuoc tinh sap xep(theo he so luong hoac theo ten...) ham nay se luu lai thuoc tinh do, neu chua chon sẽ trả về rỗng
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


        //Hàm nay se duoc thuc thi khi click nut sap xep
        private void btnSort_Click(object sender, EventArgs e)
        {
            string propertyName;

            if ((propertyName = GetPropertyToSort()) != "")//Kiem tra neu nguoi dung da chon thuoc tinh sap xep thì se thuc hien sap xep danh sach
            {
                listEmployee.Sort(propertyName, cmbTypeSort.SelectedIndex);//goi ham sort cua danh sach

                ShowListEmployeeToDatagridView(this.listEmployee);//Hien thi lai danh sach

                isChanged = false;//cap nhat lai biến nay vì dữ lieu da bi thay doi
            }
            //neu chua chon thi se thong bao
            else MessageBox.Show("Bạn chưa chọn tiêu chí sắp xếp, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        //Hàm nay se duoc thuc thi khi click nut them
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())//Nếu đã nhập đầy đủ thong tin
            {
                string propertyName;

                //tạo ngày sinh khi click chọn ngày sinh trên form
                Date birthDay = new DoAnThucTapCoSo.Date(dtpBirthDay.Value.Day, dtpBirthDay.Value.Month, dtpBirthDay.Value.Year);

                //Tao node chứa thong tin nhan vien de them vao danh sach (thong tin lay tu du lieu nhap vao)
                Node<Employee> employee = new Node<Employee>()
                {
                    Data = new Employee(txtName.Text.Trim(),
                    cmbPosition.Text,
                    birthDay,
                    double.Parse(nudCoeffienceSalary.Value.ToString()))
                };

                if ((propertyName = GetPropertyToSort()) != "")//kiem tra xem co chon thuoc tinh sap xep hay khong, neu co phai them vao danh sach sao cho dam bao danh sach van dc sap xep, neu khong them vao cuoi danh sach(truong hop else)
                {
                    listEmployee.AddLast(employee);
                    listEmployee.Sort(propertyName, cmbTypeSort.SelectedIndex);
                }
                else
                {
                    listEmployee.AddLast(employee);
                }

                //hien thi lai danh sach
                ShowListEmployeeToDatagridView(this.listEmployee);

                isChanged = false;
            }
        }


        //Hàm nay se duoc thuc thi khi click nut thoat
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//đóng form
        }


        //Hàm nay se duoc thuc thi khi click nut luu lai
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();//gọi hàm save()
        }


        //Hàm nay se duoc thuc thi khi click nut lam moi
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listEmployee.Clear();//xoa het cac nhan vien hiện có trong danh sach

            LoadDataFromFile(filePath);//doc lai file

            ShowListEmployeeToDatagridView(listEmployee);//hien thi lai danh sach
        }


        //Hàm nay se duoc thuc thi truoc khi thoat
        //vi dụ trước khi đóng word nó thường hỏi có muốn lưu lại trước khi thoát hay không á, hàm này thực hiện y chang zậy
        private void frmManageEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isChanged)//
            {
                if (MessageBox.Show("Bạn có muốn lưu dữ liệu lại trước khi thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Save();
                }
            }
        }


        //Hàm nay se duoc thuc thi khi click nut xoa
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "")//Kiem tra đã nhập tu khoa hay chua
            {
                MessageBox.Show("Bạn chưa nhập từ khóa, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //goi ham tim kiem cua danh sach
                ListEmployee searchResult = listEmployee.Search(txtKeyword.Text);

                if (searchResult.Count() == 0)//kết wả tìm rỗng
                    MessageBox.Show("Không tìm thấy nhân viên nào có liên quan với từ khóa!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else//kết wả tìm khác rỗng
                {
                    if (searchResult.Count() == 1)//kết wả tìm chi có 1 nhan vien
                    {
                        string employeeInfo = "";//chuoi để luu thong tin nhan vien tìm duoc

                        //gán chuoi = hàm toString() của lớp employee
                        employeeInfo = searchResult.FirstEmployee.Data.ToString() + "Vị trí trong danh sách:" + searchResult.FirstEmployee.OrderNumber + "\n\n";

                        //Xac nhan lai co chac muon xoa hay khong
                        if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?\n\n" + employeeInfo, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            listEmployee.Remove(searchResult.FirstEmployee);//goi ham xoa cua danh sach

                            ShowListEmployeeToDatagridView(this.listEmployee);

                            isChanged = false;
                        }
                    }


                    else//kết wả tìm chi có nhiều nhan vien
                    {
                        //chuyen sang form ket qua tim kiem và goi hàm khởi tạo, truyền vào searchResult là kết tìm được để hiển thị trên form kết quả
                        frmSearchResult frmResult = new DoAnThucTapCoSo.frmSearchResult(searchResult, "Delete");

                        frmResult.ShowDialog();//hien thi form


                        //Neu tren form ket qua nhấn nut có
                        if (frmResult.DeleteConfirm)
                        {
                            listEmployee.RemoveMultiple(txtKeyword.Text);

                            ShowListEmployeeToDatagridView(this.listEmployee);

                            MessageBox.Show("Xóa thành công!", "Thông báo");

                            isChanged = false;
                        }

                    }
                }
            }
        }


        //Hàm nay se duoc thuc thi khi click nut tim kiem
        //giải thích: giống như hàm btnRemove_Click ở trên khác là không cho xóa và chỉ xem thâu
        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa để tìm kiếm, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListEmployee searchResult = listEmployee.Search(txtKeyword.Text);

            if (searchResult.Count() == 0)
                MessageBox.Show("Không tìm thấy nhân viên nào!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (searchResult.Count() == 1)
                {
                    string employeeInfo = "";

                    employeeInfo += searchResult.FirstEmployee.Data.ToString() + "Vị trí trong danh sách:" + searchResult.FirstEmployee.OrderNumber + "\n\n";

                    MessageBox.Show(employeeInfo, "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

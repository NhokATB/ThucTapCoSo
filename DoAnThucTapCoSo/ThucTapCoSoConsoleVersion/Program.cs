using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnThucTapCoSo;
using System.IO;

namespace ThucTapCoSoConsoleVersion
{
    class Program
    {
        private static ListEmployee listEmployee;
        public static string propertyToSort = "";
        public static string typeSort;
        private static string filePath = @"..\..\Data\Data.txt";

        static void Main(string[] args)
        {
            string function = null;
            listEmployee = new ListEmployee();
            LoadDataFromFile(filePath);

            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------- HE THONG QUAN LI NHAN VIEN -----------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------\n");

            do
            {
                Console.WriteLine("--------------------------- Chuc nang -----------------------------");

                Console.WriteLine(" 1. Xem danh sach nhan vien.    \n");

                Console.WriteLine(" 2. Them nhan vien.             \n");

                Console.WriteLine(" 3. Xoa nhan vien.              \n");

                Console.WriteLine(" 4. Tim kiem nhan vien.         \n");

                Console.WriteLine(" 5. Sap xep danh sach nhan vien.\n");

                Console.WriteLine(" 6. Luu lai.                    \n");

                Console.WriteLine(" 7. Thoat.                        ");
                Console.WriteLine("-------------------------------------------------------------------");

                Console.Write("Chon chuc nang: ");
                function = Console.ReadLine();

                switch (function)
                {
                    case "1": ShowList(); break;
                    case "2": AddEmployee(); break;
                    case "3": RemoveEmployee(); break;
                    case "4": Search(); break;
                    case "5": Sort(); break;
                    case "6": Save(); break;
                    case "7": break;
                    default:
                        Console.WriteLine("Khong co chuc nang nay trong he thong, vui long chon chuc nang khac."); break;
                }
            } while (function != "7");
        }

        private static void ShowList()
        {

            Console.WriteLine("-------------------------------------- Danh sach nhan vien --------------------------------------\n");
            Console.WriteLine("Ho va ten\t\t\tChuc vu\t\t\tNgay sinh\t\tHe so luong\n");
            listEmployee.DisplayConsole();
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
        }

        private static void AddEmployee()
        {
            string name;
            string position = "";
            Date birthDay = null;
            double coefficienceSalary = 0;

            Console.WriteLine("------------------------- Them nhan vien --------------------------");
            Console.Write("Nhap ten nhan vien: ");

            name = Console.ReadLine();
            bool isRightFormatDate;
            do
            {
                isRightFormatDate = false;
                try
                {
                    Console.Write("\nNhap ngay sinh nhan vien: ");
                    birthDay = Date.Parse(Console.ReadLine());
                    isRightFormatDate = true;
                }
                catch
                {
                    Console.Write("\nNgay sinh ban nhap khong dung dinh dang dd/MM/yyyy, vui long kiem tra lai!");
                }
            } while (!isRightFormatDate);

            string choose = "";
            do
            {
                Console.WriteLine("\nChon chuc vu nhan vien:");
                Console.WriteLine("1: lao cong");
                Console.WriteLine("2: Nhan vien");
                Console.WriteLine("3: Thu ki");
                Console.WriteLine("4: Truong phong");
                Console.WriteLine("5: Pho giam doc");
                Console.WriteLine("6: Tong giam doc\n");
                Console.Write("Lua chon: ");
                choose = Console.ReadLine();

                switch (choose)
                {
                    case "1": position = "Lao công"; break;
                    case "2": position = "Nhân Viên"; break;
                    case "3": position = "Thư Kí"; break;
                    case "4": position = "Trưởng Phòng"; break;
                    case "5": position = "Phó Giám Đốc"; break;
                    case "6": position = "Tổng Giám Đốc"; break;
                    default:
                        Console.WriteLine("Khong co chuc vu nay trong he thong, vui long chon lai."); break;
                }

            } while (choose != "1" && choose != "2" && choose != "3" && choose != "4" && choose != "5" && choose != "6");

            bool isRightFormatCoefficienceSalary;
            do
            {
                isRightFormatCoefficienceSalary = false;
                try
                {
                    Console.WriteLine("\nNhap he so luong: ");
                    coefficienceSalary = double.Parse(Console.ReadLine());
                    isRightFormatCoefficienceSalary = true;

                }
                catch
                {
                    Console.WriteLine("\nHe so luong ban nhap khong phai la so, vui long kiem tra va nhap lai he so luong:");
                }
            } while (!isRightFormatCoefficienceSalary);


            Employee data = new Employee(name, position, birthDay, coefficienceSalary);
            Node<Employee> employee = new Node<Employee>(data);

            switch (propertyToSort)
            {
                case "1":
                    listEmployee.AddLast(employee);
                    listEmployee.Sort("Position", int.Parse(typeSort));
                    break;
                case "2":
                    listEmployee.AddLast(employee);
                    listEmployee.Sort("BirthDay", int.Parse(typeSort));
                    break;
                case "3":
                    listEmployee.AddLast(employee);
                    listEmployee.Sort("CoefficienceSalary", int.Parse(typeSort));
                    break;
                default:
                    listEmployee.AddLast(employee);
                    break;
            }


            Console.WriteLine("\nThem thanh cong, danh sach nhan vien sau khi them.");
            ShowList();
            Console.WriteLine("-------------------------------------------------------------------");
        }
        private static int NumberEmployeeRelateWithKeyword(string keyWord)
        {
            int count = 0;
            for (Node<Employee> employee = listEmployee.FirstEmployee; employee != null; employee = employee.Next)
            {
                if (StringProcessing.ConvertToUnSign(employee.Data.Name.ToLower()).Contains(keyWord) || employee.Data.BirthDay.ToString().Contains(keyWord))
                {
                    count++;
                }
            }
            return count;
        }
        private static void RemoveEmployee()
        {
            string keyWord;
            Console.WriteLine("------------------------ Xoa nhan vien ----------------------------");
            Console.Write("Nhap tu khoa: ");
            keyWord = Console.ReadLine();

            int count = NumberEmployeeRelateWithKeyword(keyWord);

            if (count > 0)
            {
                string luaChon = "";
                Console.WriteLine("\nCo {0} nhan vien co thong tin lien quan den tu khoa, ban co chac muon xoa tat ca nhung nhan vien nay?", count);
                do
                {
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.Write("Lua chon: ");
                    luaChon = Console.ReadLine();
                } while (luaChon != "1" && luaChon != "2");

                if (luaChon == "1")
                {
                    listEmployee.RemoveMultiple(keyWord);
                    Console.WriteLine("\nXoa thanh cong, danh sach nhan vien sau khi xoa.");
                    ShowList();
                    
                }
            }
            else
            {
                Console.WriteLine("\nKhong co nhan vien nao co thong tin lien quan den tu khoa.");
                Console.WriteLine("-------------------------------------------------------------------");
            }
        }

        private static void Search()
        {
            Console.WriteLine("------------------------ Tim kiem nhan vien -------------------------");

            string keyword;

            Console.Write("Nhap tu khoa can tim: ");
            keyword = Console.ReadLine();

            Node<Employee> employee = null;
            employee = listEmployee.SearchFirst(keyword);

            if (employee != null)
            {
                Console.WriteLine("\nThong tin nhan vien tim duoc:\n");
                Console.WriteLine("Ten nhan vien: " + employee.Data.Name + "\n\n" + "Ngay sinh: " + employee.Data.BirthDay.ToString() + "\n\n" + "Chuc vu: " + employee.Data.Position + "\n\n" + "He so luong: " + employee.Data.CoefficienceSalary + "\n\n" + "Vi tri trong danh sach: " + (employee.OrderNumber + 1) + "\n");
                Console.WriteLine("-------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("\nKhong tim duoc nhan vien nao!");
                Console.WriteLine("-------------------------------------------------------------------");
            }

        }

        private static void Sort()
        {
            Console.WriteLine("------------------------ Sap xep nhan vien -------------------------");

            do
            {
                Console.WriteLine("Ban muon sap xep theo:");
                Console.WriteLine("1. Chuc vu");
                Console.WriteLine("2. Ngay sinh");
                Console.WriteLine("3. He so luong");
                Console.Write("Lua chon: ");
                propertyToSort = Console.ReadLine();
            } while (propertyToSort != "1" && propertyToSort != "2" && propertyToSort != "3");

            switch (propertyToSort)
            {
                case "1":
                    propertyToSort = "Position";
                    break;
                case "2":
                    propertyToSort = "BirthDay";
                    break;
                case "3":
                    propertyToSort = "CoefficienceSalary";
                    break;
                default: break;
            }

            do
            {
                Console.WriteLine("\nChon kieu sap xep:");
                Console.WriteLine("1. Tang dan");
                Console.WriteLine("2. Giam dan");
                Console.Write("Lua chon: ");
                typeSort = Console.ReadLine();

                if (typeSort != "1" && typeSort != "2")
                {
                    Console.WriteLine("Ban chi co the chon 1 hoac 2");
                }

            } while (typeSort != "1" && typeSort != "2");



            listEmployee.Sort(propertyToSort, int.Parse(typeSort));

            Console.WriteLine("\nDanh sach nhan vien sau khi sap xep:");
            ShowList();
           
        }

        private static void WriteToFile(StreamWriter sw)
        {
            sw.WriteLine("Họ và tên\t\tChức vụ\t\tNgày sinh\tHệ số lương");
            for (Node<Employee> employee = listEmployee.FirstEmployee; employee != null; employee = employee.Next)
            {
                if (employee.Data.Name.Length < 16)
                {
                    if (employee.Data.Position.Length < 8)
                    {
                        sw.WriteLine(employee.Data.Name + "\t\t" + employee.Data.Position + "\t\t" + employee.Data.BirthDay.ToString() + "\t" + employee.Data.CoefficienceSalary + "\n");
                    }
                    else
                        sw.WriteLine(employee.Data.Name + "\t\t" + employee.Data.Position + "\t" + employee.Data.BirthDay.ToString() + "\t" + employee.Data.CoefficienceSalary + "\n");
                }
                else if (employee.Data.Position.Length < 8)
                {
                    sw.WriteLine(employee.Data.Name + "\t" + employee.Data.Position + "\t\t" + employee.Data.BirthDay.ToString() + "\t" + employee.Data.CoefficienceSalary + "\n");
                }
                else
                {
                    sw.WriteLine(employee.Data.Name + "\t" + employee.Data.Position + "\t" + employee.Data.BirthDay.ToString() + "\t" + employee.Data.CoefficienceSalary + "\n");
                }

            }
        }

        private static void Save()
        {
            FileStream fs = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            WriteToFile(sw);

            sw.Close();

            Console.WriteLine("Luu thanh cong!");
        }
       

        private static void LoadDataFromFile(string filePath)
        {
            try
            {
                StreamReader sr = new StreamReader(filePath, Encoding.UTF8);

                int countLine = 0;

                string readInformation;

                while ((readInformation = sr.ReadLine()) != null)
                {
                    countLine++;
                    if (readInformation.Contains("Họ và tên\t\tChức vụ\t\tNgày sinh\tHệ số lương")) continue;

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

                    Node<Employee> employee = new Node<Employee>()
                    {
                        Data = new Employee(employeeInformation[0],
                        employeeInformation[1],
                        Date.Parse(employeeInformation[2]),
                        double.Parse(employeeInformation[3])),
                    };

                    listEmployee.AddLast(employee);

                    readInformation = sr.ReadLine();
                }

                sr.Close();
            }


            catch (Exception e)
            {
                Console.WriteLine("File dữ liệu không đúng định dạng, vui lòng kiểm tra lại!\n Gợi ý:\n+ Ngày sinh không đúng dịnh dạng dd/MM/yyyy\n+ Hệ số lương không phải là số ...");
                throw e;
            }
        }
    }
}

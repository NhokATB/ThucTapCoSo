using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAnThucTapCoSo
{
    public class ListEmployee
    {
        private static string[] positionArray = new string[]
        {
            "Lao công",
            "Nhân viên",
            "Thư kí",
            "Trưởng phòng",
            "Phó giám đốc",
            "Tổng giám đốc",
        };

        public static string[] PositionArray
        {
            get { return positionArray; }
            set { positionArray = value; }
        }
        public Node<Employee> FirstEmployee;
        public Node<Employee> FinalEmployee;

        public ListEmployee()
        {
            FirstEmployee = null;
            FirstEmployee = null;

        }

        public int Count()
        {
            int count = 0;
            for (Node<Employee> employee = this.FirstEmployee; employee != null; employee = employee.Next)
            {
                count++;
            }
            return count;
        }
        public void Clear()
        {
            FirstEmployee = null;
            FinalEmployee = null;
        }

        private void Swap(Node<Employee> emp1, Node<Employee> emp2)
        {
            Node<Employee> emp3 = new Node<Employee>();
            emp3.Data = new Employee();

            emp3.Data.Name = emp1.Data.Name;
            emp3.Data.Position = emp1.Data.Position;
            emp3.Data.BirthDay = emp1.Data.BirthDay;
            emp3.Data.CoefficienceSalary = emp1.Data.CoefficienceSalary;

            emp1.Data.Name = emp2.Data.Name;
            emp1.Data.Position = emp2.Data.Position;
            emp1.Data.BirthDay = emp2.Data.BirthDay;
            emp1.Data.CoefficienceSalary = emp2.Data.CoefficienceSalary;

            emp2.Data.Name = emp3.Data.Name;
            emp2.Data.Position = emp3.Data.Position;
            emp2.Data.BirthDay = emp3.Data.BirthDay;
            emp2.Data.CoefficienceSalary = emp3.Data.CoefficienceSalary;
        }

        public void AddLast(Node<Employee> employee)
        {
            if (FirstEmployee == null)
            {
                FirstEmployee = employee;
                FinalEmployee = employee;
            }
            else
            {
                FinalEmployee.Next = employee;
                FinalEmployee = employee;
            }
        }

        public void AddFirst(Node<Employee> employee)
        {
            if (FirstEmployee == null)
            {
                FirstEmployee = employee;
                FinalEmployee = employee;
            }
            else
            {
                employee.Next = FirstEmployee;
                FirstEmployee = employee;
            }
        }

        private void SortEmployeeByPosition(int typeSort)
        {

            for (Node<Employee> emp1 = FirstEmployee; emp1.Next != null; emp1 = emp1.Next)
            {
                for (Node<Employee> emp2 = emp1.Next; emp2 != null; emp2 = emp2.Next)
                {
                    if (typeSort == 1)
                    {
                        if (emp1.Data.IndexOfPosition(positionArray) > emp2.Data.IndexOfPosition(positionArray))
                        {
                            Swap(emp1, emp2);
                        }
                    }
                    else
                    {
                        if (emp1.Data.IndexOfPosition(positionArray) < emp2.Data.IndexOfPosition(positionArray))
                        {
                            Swap(emp1, emp2);
                        }
                    }
                }
            }

        }

        private void SortEmployeeByBirthDay(int typeSort)
        {

            for (Node<Employee> emp1 = FirstEmployee; emp1.Next != null; emp1 = emp1.Next)
            {
                for (Node<Employee> emp2 = emp1.Next; emp2 != null; emp2 = emp2.Next)
                {
                    if (typeSort == 1)
                    {
                        if (emp1.Data.BirthDay.CompareTo(emp2.Data.BirthDay) == 1)
                        {
                            Swap(emp1, emp2);
                        }
                    }
                    else
                    {
                        if (emp1.Data.BirthDay.CompareTo(emp2.Data.BirthDay) == -1)
                        {
                            Swap(emp1, emp2);
                        }
                    }
                }
            }

        }

        private void SortEmployeeByCoefficienceSalary(int typeSort)
        {

            for (Node<Employee> emp1 = FirstEmployee; emp1.Next != null; emp1 = emp1.Next)
            {
                for (Node<Employee> emp2 = emp1.Next; emp2 != null; emp2 = emp2.Next)
                {
                    if (typeSort == 1)
                    {
                        if (emp1.Data.CoefficienceSalary > emp2.Data.CoefficienceSalary)
                        {
                            Swap(emp1, emp2);
                        }
                    }
                    else
                    {
                        if (emp1.Data.CoefficienceSalary < emp2.Data.CoefficienceSalary)
                        {
                            Swap(emp1, emp2);
                        }
                    }
                }
            }

        }

        private void SortEmployeeByName(int typeSort)
        {
            for (Node<Employee> emp1 = FirstEmployee; emp1.Next != null; emp1 = emp1.Next)
            {
                int lastIndexOfWhiteSpace1 = emp1.Data.Name.LastIndexOf(' ') + 1;
                for (Node<Employee> emp2 = emp1.Next; emp2 != null; emp2 = emp2.Next)
                {
                    int lastIndexOfWhiteSpace2 = emp2.Data.Name.LastIndexOf(' ') + 1;
                    if (typeSort == 1)
                    {
                        if (emp1.Data.Name.Substring(lastIndexOfWhiteSpace1).CompareTo(emp2.Data.Name.Substring(lastIndexOfWhiteSpace2)) == 1)
                        {
                            Swap(emp1, emp2);
                        }
                    }
                    else
                    {
                        if (emp1.Data.Name.Substring(lastIndexOfWhiteSpace1).CompareTo(emp2.Data.Name.Substring(lastIndexOfWhiteSpace2)) == -1)
                        {
                            {
                                Swap(emp1, emp2);
                            }
                        }
                    }
                }
            }

        }

        public void Sort(string properryName, int typeSort)
        {
            if (properryName == "Position")
                SortEmployeeByPosition(typeSort);
            else if (properryName == "BirthDay")
                SortEmployeeByBirthDay(typeSort);
            else if (properryName == "Name")
                SortEmployeeByName(typeSort);
            else if (properryName == "CoefficienceSalary")
                SortEmployeeByCoefficienceSalary(typeSort);
        }

        //Ham nay chi xoa 1 nhan vien
        public void Remove(Node<Employee> employee = null)
        {
            if (FirstEmployee.Equals(employee))
            {
                FirstEmployee = FirstEmployee.Next;
            }
            else
            {
                Node<Employee> flag = FirstEmployee;
                while (flag != FinalEmployee && flag != null)
                {
                    if (flag.Next.Equals(employee))
                    {
                        //Truong hop nhan vien o cuoi danh sach
                        if (flag.Next.Next == null)
                        {
                            flag.Next = null;
                            FinalEmployee = flag;
                        }
                        else
                        {
                            flag.Next = flag.Next.Next;
                        }
                    }
                    flag = flag.Next;
                };
            }
        }


        //ham nay xoa nhieu nhan vien dua vao tu khoa truyen vao
        public void RemoveMultiple(string unsignKeyword)
        {
            unsignKeyword = StringProcessing.ConvertToUnSign(unsignKeyword.ToLower());

            for (Node<Employee> employee = FirstEmployee; employee != null; employee = employee.Next)
            {
                if (StringProcessing.ConvertToUnSign(employee.Data.Name.ToLower()).Contains(unsignKeyword) || StringProcessing.ConvertToUnSign(employee.Data.Position.ToLower()).Contains(unsignKeyword) || employee.Data.BirthDay.ToString().Contains(unsignKeyword) || employee.Data.CoefficienceSalary.ToString() == unsignKeyword)
                {
                    Remove(employee);
                }
            }
        }


        public ListEmployee Search(string keyword)
        {
            ListEmployee searchResult = new DoAnThucTapCoSo.ListEmployee();
            string unsignKeyword = StringProcessing.ConvertToUnSign(keyword.ToLower());
            int index = 0;
            for (Node<Employee> employee = FirstEmployee; employee != null; employee = employee.Next)
            {
                index++;
                if (StringProcessing.ConvertToUnSign(employee.Data.Name.ToLower()).Contains(unsignKeyword) || StringProcessing.ConvertToUnSign(employee.Data.Position.ToLower()).Contains(unsignKeyword) || employee.Data.BirthDay.ToString().Contains(unsignKeyword) || employee.Data.CoefficienceSalary.ToString() == unsignKeyword)
                {

                    Node<Employee> result = new Node<Employee>(employee.Data.Clone()) { Next = null, OrderNumber = index};

                    searchResult.AddLast(result);

                }

            }

            return searchResult;
        }

        public int IndexOf(Node<Employee> emloyee)
        {
            int index = -1;
            int count = 0;
            for (Node<Employee> emp = FirstEmployee; emp != null; emp = emp.Next)
            {
                if (emp.Data.Equals(emloyee))
                {
                    index = count;
                    break;
                }
                count++;
            }
            return index;
        }

    }

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public int OrderNumber { get; set; }
        public Node()
        {

        }
        public Node(T data)
        {
            this.Data = data;
        }
    }
    public class StringProcessing
    {
        public static string ConvertToUnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");

            string temp = s.Normalize(NormalizationForm.FormD);

            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }

}
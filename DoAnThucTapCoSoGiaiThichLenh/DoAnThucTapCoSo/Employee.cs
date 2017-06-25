using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTapCoSo
{
    public class Employee
    {
       
        public string Name { get; set; }
        public string Position { get; set; }
        public Date BirthDay { get; set; }
        public double CoefficienceSalary { get; set; }

       

        public Employee()
        {
            BirthDay = new Date();

        }
        public Employee Clone()
        {
            Employee employee = new DoAnThucTapCoSo.Employee();
            employee.Name = this.Name;
            employee.Position = this.Position;
            employee.BirthDay = this.BirthDay;
            employee.CoefficienceSalary = this.CoefficienceSalary;
            return employee;
        }
        public Employee(string name, string position, Date birthDay, double coefficienceSalary)
        {
            this.Name = name;
            this.Position = position;
            this.BirthDay = birthDay;
            this.CoefficienceSalary = coefficienceSalary;
        }

        public bool Equals(Employee employee)
        {
            if (this.Name == employee.Name && this.Position == employee.Position && this.CoefficienceSalary == employee.CoefficienceSalary && this.BirthDay.CompareTo(employee.BirthDay) == 0)
                return true;
            return false;
        }

        public override string ToString()
        {
            return "Họ tên: " + this.Name + "\n" + "Ngày sinh: " + this.BirthDay.ToString() + "\n" + "Chức vụ: " + this.Position + "\n" + "Hệ số lương: " + this.CoefficienceSalary + "\n";
        }
        public int IndexOfPosition(string[] positionArray)
        {
            for (int i = 0; i < positionArray.Length; i++)
            {
                if (positionArray[i] == this.Position)
                    return i;
            }
            return -1;
        }
    }
}

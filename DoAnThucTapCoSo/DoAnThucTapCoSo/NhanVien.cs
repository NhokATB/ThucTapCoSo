using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTapCoSo
{
    public class NhanVien
    {
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public NgayGio NgaySinh { get; set; }
        public double HeSoLuong { get; set; }

        public NhanVien next;

        public NhanVien()
        {
            NgaySinh = new NgayGio();
            
        }

        public NhanVien(string hoTen, string chucVu, NgayGio ngaySinh, double heSoLuong)
        {
            this.HoTen = hoTen;
            this.ChucVu = chucVu;
            this.NgaySinh = ngaySinh;
            this.HeSoLuong = heSoLuong;
        }

        public bool Equals(NhanVien employee)
        {
            if (this.HoTen == employee.HoTen && this.ChucVu == employee.ChucVu && this.HeSoLuong == employee.HeSoLuong && this.NgaySinh.CompareTo(employee.NgaySinh) == 0)
                return true;
            return false;
        }

        public object this[string propertyName]
        {
            get
            {
                switch (propertyName)
                {
                    case "HoTen": return HoTen;
                    case "ChucVu": return ChucVu;
                    case "NgaySinh": return NgaySinh;
                    case "HeSoLuong": return HeSoLuong;
                    default: return null;
                }
            }
            set { }
        }

        public override string ToString()
        {
            return "Họ tên: " + this.HoTen + "\n" + "Ngày sinh: " + this.NgaySinh.ToString() + "\n" + "Chức vụ: " + this.ChucVu + "\n" + "Hệ số lương: " + this.HeSoLuong + "\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAnThucTapCoSo
{
    public class DanhSachNhanVien
    {
        public NhanVien NhanVienDau;
        public NhanVien NhanVienCuoi;
        public string[] danhSachChucVu;
        public double[] danhSachHeSoLuong;

        public DanhSachNhanVien()
        {
            NhanVienDau = null;
            NhanVienCuoi = null;
            danhSachChucVu = new string[]
            {
                 "Tổng giám đốc", "Phó giám đốc", "Thư kí", "Trưởng phòng", "Nhân viên"
            };
            danhSachHeSoLuong = new double[]
            {
                10, 8, 5, 5, 2.5
            };
        }

        public NhanVien this[int index]
        {
            get
            {
                int count = 0;
                for (NhanVien nv = this.NhanVienDau; nv != null; nv = nv.next)
                {
                    if (count == index)
                    {
                        return nv;
                    }
                    count++;
                }
                return null;
            }
            set { this[index] = value; }
        }

        public int Count()
        {
            int count = 0;
            for (NhanVien nv = this.NhanVienDau; nv != null; nv = nv.next)
            {
                count++;
            }
            return count;
        }

        public void Display()
        {
            for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
            {
                Console.WriteLine(nv.HoTen + "\t\t" + nv.NgaySinh + "\t\t" + nv.ChucVu + "\t\t" + nv.HeSoLuong + "\n");
            }
        }

        public bool Contains(NhanVien nhanVien)
        {
            for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
            {
                if (nv.HoTen == nhanVien.HoTen && nv.ChucVu == nhanVien.ChucVu && nv.NgaySinh == nhanVien.NgaySinh && nv.HeSoLuong == nhanVien.HeSoLuong)
                    return true;
            }
            return false;
        }

        private void Swap(NhanVien nv1, NhanVien nv2)
        {
            NhanVien emp3 = new DoAnThucTapCoSo.NhanVien();

            emp3.HoTen = nv1.HoTen;
            emp3.ChucVu = nv1.ChucVu;
            emp3.NgaySinh = nv1.NgaySinh;
            emp3.HeSoLuong = nv1.HeSoLuong;

            nv1.HoTen = nv2.HoTen;
            nv1.ChucVu = nv2.ChucVu;
            nv1.NgaySinh = nv2.NgaySinh;
            nv1.HeSoLuong = nv2.HeSoLuong;

            nv2.HoTen = emp3.HoTen;
            nv2.ChucVu = emp3.ChucVu;
            nv2.NgaySinh = emp3.NgaySinh;
            nv2.HeSoLuong = emp3.HeSoLuong;
        }

        public void AddLast(NhanVien nhanVien)
        {
            if (NhanVienDau == null)
            {
                NhanVienDau = nhanVien;
                NhanVienCuoi = nhanVien;
            }
            else
            {
                NhanVienCuoi.next = nhanVien;
                NhanVienCuoi = nhanVien;
            }
        }

        public void AddFirst(NhanVien nhanVien)
        {
            if (NhanVienDau == null)
            {
                NhanVienDau = nhanVien;
                NhanVienCuoi = nhanVien;
            }
            else
            {
                nhanVien.next = NhanVienDau;
                NhanVienDau = nhanVien;
            }
        }

        private void InsertAfter(NhanVien nv1, NhanVien nv2) // insert nv1 after nv2
        {
            nv1.next = nv2.next;
            nv2.next = nv1;
        }

        public void Insert(NhanVien nhanVien, string propertyName, int typeSort)// Thêm nhanVien vao danh sach sao cho danh sach van dc sap xep theo propertyName duoc truyen vao
        {
            if (propertyName == "ChucVu")
            {
                if ((typeSort == 1 && ChiSoChucVu(nhanVien.ChucVu) == danhSachChucVu.Length - 1 || (typeSort == 0 && ChiSoChucVu(nhanVien.ChucVu) == 0)))
                    AddFirst(nhanVien);
                else
                {
                    for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
                    {
                        if (nv.next == null)
                        {
                            AddLast(nhanVien);
                            break;
                        }

                        else if ((typeSort == 1 && ChiSoChucVu(nv.ChucVu) < ChiSoChucVu(nhanVien.ChucVu) || (typeSort == 0) && ChiSoChucVu(nv.ChucVu) > ChiSoChucVu(nhanVien.ChucVu)))
                        {
                            InsertAfter(nhanVien, nv);
                            break;
                        }
                    }
                }

            }
            else if (propertyName == "HeSoLuong")
            {
                if ((typeSort == 1 && nhanVien.HeSoLuong.CompareTo(NhanVienDau.HeSoLuong) <= 0) || (typeSort == 0 && nhanVien.HeSoLuong.CompareTo(NhanVienDau.HeSoLuong) >= 0))
                    AddFirst(nhanVien);
                else
                {
                    for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
                    {
                        if (nv.next == null)
                        {
                            AddLast(nhanVien);
                            break;
                        }

                        if ((nhanVien.HeSoLuong.CompareTo(nv.HeSoLuong) >= 0 && nhanVien.HeSoLuong.CompareTo(nv.next.HeSoLuong) < 0) || (nhanVien.HeSoLuong.CompareTo(nv.HeSoLuong) <= 0 && nhanVien.HeSoLuong.CompareTo(nv.next.HeSoLuong) > 0))
                        {
                            InsertAfter(nhanVien, nv);
                            break;
                        }
                    }
                }
            }
            else if (propertyName == "NgaySinh")
            {
                if ((typeSort == 1 && nhanVien.NgaySinh.CompareTo(NhanVienDau.NgaySinh) <= 0) || (typeSort == 0 && nhanVien.NgaySinh.CompareTo(NhanVienDau.NgaySinh) >= 0))
                    AddFirst(nhanVien);
                else
                {
                    for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
                    {
                        if (nv.next == null)
                        {
                            AddLast(nhanVien);
                            break;
                        }

                        if ((nhanVien.NgaySinh.CompareTo(nv.NgaySinh) <= 0 && nhanVien.NgaySinh.CompareTo(nv.next.NgaySinh) > 0) || (nhanVien.NgaySinh.CompareTo(nv.NgaySinh) >= 0 && nhanVien.NgaySinh.CompareTo(nv.next.NgaySinh) < 0))
                        {
                            InsertAfter(nhanVien, nv);
                            break;
                        }
                    }
                }
            }
        }

        private void QuickSortEmployeeByPosition(int typeSort)
        {
            int count = Count();
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (typeSort == 1)
                    {
                        if (ChiSoChucVu(this[i].ChucVu) < ChiSoChucVu(this[j].ChucVu))
                        {
                            Swap(this[i], this[j]);
                        }
                    }
                    else
                    {
                        if (ChiSoChucVu(this[i].ChucVu) > ChiSoChucVu(this[j].ChucVu))
                        {
                            Swap(this[i], this[j]);
                        }
                    }

                }
            }
        }

        private void QuickSortEmployeeByCoefficientSalary(int left, int right, int typeSort)
        {
            int i = left, j = right;

            double middleHeSoLuong = this[(i + j) / 2].HeSoLuong;

            while (i <= j)
            {
                if (typeSort == 1)
                {
                    while (this[i].HeSoLuong.CompareTo(middleHeSoLuong) < 0)
                    {
                        i++;
                    }

                    while (this[j].HeSoLuong.CompareTo(middleHeSoLuong) > 0)
                    {
                        j--;
                    }
                }
                else
                {
                    while (this[i].HeSoLuong.CompareTo(middleHeSoLuong) > 0)
                    {
                        i++;
                    }

                    while (this[j].HeSoLuong.CompareTo(middleHeSoLuong) < 0)
                    {
                        j--;
                    }
                }


                if (i <= j)
                {
                    Swap(this[i], this[j]);

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSortEmployeeByCoefficientSalary(left, j, typeSort);
            }

            if (i < right)
            {
                QuickSortEmployeeByCoefficientSalary(i, right, typeSort);
            }
        }// Sap xep theo he so luong
        private void QuickSortEmployeeByYearOld(int left, int right, int typeSort)
        {
            int i = left, j = right;

            NgayGio middleNgaySinh = this[(i + j) / 2].NgaySinh;

            while (i <= j)
            {
                if (typeSort == 1)
                {
                    while (this[i].NgaySinh.CompareTo(middleNgaySinh) > 0)
                    {
                        i++;
                    }

                    while (this[j].NgaySinh.CompareTo(middleNgaySinh) < 0)
                    {
                        j--;
                    }
                }
                else
                {
                    while (this[i].NgaySinh.CompareTo(middleNgaySinh) < 0)
                    {
                        i++;
                    }

                    while (this[j].NgaySinh.CompareTo(middleNgaySinh) > 0)
                    {
                        j--;
                    }
                }


                if (i <= j)
                {
                    Swap(this[i], this[j]);

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSortEmployeeByYearOld(left, j, typeSort);
            }

            if (i < right)
            {
                QuickSortEmployeeByYearOld(i, right, typeSort);
            }
        }// Sap xep theo tuổi (dua vao ngay sinh)
        public void Sort(string properryName, int typeSort)
        {
            if (properryName == "ChucVu")
                QuickSortEmployeeByPosition(typeSort);
            else if (properryName == "NgaySinh")
                QuickSortEmployeeByYearOld(0, Count() - 1, typeSort);
            else if (properryName == "HeSoLuong")
                QuickSortEmployeeByCoefficientSalary(0, Count() - 1, typeSort);
        }

        public void Delete(NhanVien nhanVien = null)
        {
            if (NhanVienDau.Equals(nhanVien))
            {
                NhanVienDau = NhanVienDau.next;
            }
            else
            {
                NhanVien flag = NhanVienDau;
                while (flag != NhanVienCuoi && flag != null)
                {
                    if (flag.next.Equals(nhanVien))
                    {
                        //Truong hop nhan vien o cuoi danh sach
                        if (flag.next.next == null)
                        {
                            flag.next = null;
                            NhanVienCuoi = flag;
                        }
                        else
                        {
                            flag.next = flag.next.next;
                        }
                    }
                    flag = flag.next;
                };
            }
        }

        public void DeleteMany(string keyWord)
        {
            keyWord = StringProcessing.ConvertToUnSign(keyWord.ToLower());
            for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
            {
                if (StringProcessing.ConvertToUnSign(nv.HoTen.ToLower()).Contains(keyWord) || nv.NgaySinh.ToString().Contains(keyWord))
                {
                    Delete(nv);
                }
            }
        }

        public NhanVien SearchFirst(string[] propertyNames, string[] values)
        {
            if (propertyNames[1] == null)
            {
                for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
                {
                    if (StringProcessing.ConvertToUnSign(nv[propertyNames[0]].ToString().ToLower()).Contains(StringProcessing.ConvertToUnSign(values[0].ToLower())))
                        return nv;
                }
            }
            else
            {
                for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
                {
                    if (StringProcessing.ConvertToUnSign(nv[propertyNames[0]].ToString().ToLower()).Contains(StringProcessing.ConvertToUnSign(values[0].ToLower())) && StringProcessing.ConvertToUnSign(nv[propertyNames[1]].ToString().ToLower()).Contains(StringProcessing.ConvertToUnSign(values[1].ToLower())))
                        return nv;
                }
            }
            return null;
        }
        public DanhSachNhanVien SearchMany(string[] propertyNames, string[] values)
        {
            DanhSachNhanVien ketQuaTimKiem = new DanhSachNhanVien();
            if (propertyNames[1] == null)
            {
                for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
                {
                    if (StringProcessing.ConvertToUnSign(nv[propertyNames[0]].ToString().ToLower()).Contains(StringProcessing.ConvertToUnSign(values[0].ToLower())))
                    {
                        NhanVien kq = new NhanVien(nv.HoTen, nv.ChucVu, nv.NgaySinh, nv.HeSoLuong);
                        ketQuaTimKiem.AddLast(kq);
                    }
                }
            }
            else
            {
                for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
                {
                    if (StringProcessing.ConvertToUnSign(nv[propertyNames[0]].ToString().ToLower()).Contains(StringProcessing.ConvertToUnSign(values[0].ToLower())))
                    {
                        if (StringProcessing.ConvertToUnSign(nv[propertyNames[1]].ToString().ToLower()).Contains(StringProcessing.ConvertToUnSign(values[1].ToLower())))
                        {
                            NhanVien kq = new NhanVien(nv.HoTen, nv.ChucVu, nv.NgaySinh, nv.HeSoLuong);
                            ketQuaTimKiem.AddLast(kq);
                        }
                    }
                }
            }
            return ketQuaTimKiem;
        }

        public int IndexOf(NhanVien nhanVien)
        {
            int index = -1;
            int count = 0;
            for (NhanVien nv = NhanVienDau; nv != null; nv = nv.next)
            {
                if (nv.Equals(nhanVien))
                {
                    index = count;
                    break;
                }
                count++;
            }
            return index;
        }

        private int ChiSoChucVu(string chucVu)
        {
            for (int i = 0; i < danhSachChucVu.Length; i++)
            {
                if (chucVu == danhSachChucVu[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public double HeSoLuongCuaChucVu(string chucVu)
        {
            return danhSachHeSoLuong[ChiSoChucVu(chucVu)];
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

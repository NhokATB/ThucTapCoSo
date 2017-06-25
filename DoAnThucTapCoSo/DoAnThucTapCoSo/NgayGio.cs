using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTapCoSo
{
    public class NgayGio
    {
        public int Nam { get; set; }
        public int Thang { get; set; }
        public int Ngay { get; set; }
        public NgayGioException NgayGioException
        {
            get;
            set;
        }
        public NgayGio()
        {
            
        }
        public static int SoNgayTrongThang(int thang, int nam)
        {
            int soNgay = 0;

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    soNgay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    soNgay = 30;
                    break;
                case 2:
                    if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0) soNgay = 29;
                    else
                        soNgay = 28;
                    break;
                default:
                    soNgay = 0;
                    break;
            }

            return soNgay;
        }


        public NgayGio(int ngay, int thang, int nam)
        {
            NgayGioException = new DoAnThucTapCoSo.NgayGioException();
            if (ngay < 0)
            {
                NgayGioException.ErrorMessage = "Ngày không thẻ nhỏ hơn 0";
                throw NgayGioException;
            }
            else if(ngay > 31)
            {
                NgayGioException.ErrorMessage = "Ngày trong tháng không thể lớn hơn 31";
                throw NgayGioException;
            }
            else if (thang > 12 || thang < 1)
            {
                NgayGioException.ErrorMessage = "Tháng trong năm không thể lớn hơn 12 hoặc nhỏ hơn 1";
                throw NgayGioException;
            }
            else if (nam < 0)
            {
                NgayGioException.ErrorMessage = "Năm không thể nhỏ hơn 1";
                throw NgayGioException;
            }
            else if (ngay > SoNgayTrongThang(thang, nam))
            {
                NgayGioException.ErrorMessage = "Trong tháng " + thang + " năm " + nam + " không có ngày " + ngay;
                throw NgayGioException;
            }
           
            else
            {
                this.Ngay = ngay;
                this.Thang = thang;
                this.Nam = nam;
            }

        }
        public static NgayGio Parse(string chuoiCanChuyen)
        {
            string[] chuoiNgayGio = chuoiCanChuyen.Split('/');

            NgayGio ngayGio = new NgayGio(int.Parse(chuoiNgayGio[0]), int.Parse(chuoiNgayGio[1]), int.Parse(chuoiNgayGio[2]));

            return ngayGio;
        }

        public int CompareTo(NgayGio ngayGio)
        {
            if (this.Nam > ngayGio.Nam)
                return 1;
            else if (this.Nam == ngayGio.Nam)
            {
                if (this.Thang > ngayGio.Thang)
                    return 1;
                else if (this.Thang == ngayGio.Thang)
                {
                    if (this.Ngay > ngayGio.Ngay)
                        return 1;
                    else if (this.Ngay == ngayGio.Ngay)
                        return 0;
                }
            }
            return -1;

        }

        public override string ToString()
        {
            string s = "";

            if (this.Ngay < 10)
            {
                if (this.Thang < 10)
                    s += "0" + this.Ngay + "/" + "0" + this.Thang + "/" + this.Nam;
                else
                    s += "0" + this.Ngay + "/" + this.Thang + "/" + this.Nam;
            }
            else if (this.Thang < 10)
                s += this.Ngay + "/" + "0" + this.Thang + "/" + this.Nam;
            else
                s += this.Ngay + "/" + this.Thang + "/" + this.Nam;

            return s;
        }
    }


    [Serializable]
    public class NgayGioException : Exception
    {
        public static string ErrorMessage { get; set; }
        public NgayGioException()
        {
        }
        public NgayGioException(string message) : base(message) { }
        public NgayGioException(string message, Exception inner) : base(message, inner) { }
        protected NgayGioException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

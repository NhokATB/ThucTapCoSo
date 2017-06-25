using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTapCoSo
{
    public class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public DayException DayException
        {
            get;
            set;
        }
        public Date()
        {

        }
        public static int NumberDayOfMonth(int month, int year)
        {
            int numberDay = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    numberDay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    numberDay = 30;
                    break;
                case 2:
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) numberDay = 29;
                    else
                        numberDay = 28;
                    break;
                default:
                    numberDay = 0;
                    break;
            }

            return numberDay;
        }


        public Date(int day, int month, int year)
        {
            DayException = new DoAnThucTapCoSo.DayException();
            if (day < 0)
            {
                DayException.ErrorMessage = "Ngày không thẻ nhỏ hơn 0";
                throw DayException;
            }
            else if (day > 31)
            {
                DayException.ErrorMessage = "Ngày trong tháng không thể lớn hơn 31";
                throw DayException;
            }
            else if (month > 12 || month < 1)
            {
                DayException.ErrorMessage = "Tháng trong năm không thể lớn hơn 12 hoặc nhỏ hơn 1";
                throw DayException;
            }
            else if (year < 0)
            {
                DayException.ErrorMessage = "Năm không thể nhỏ hơn 1";
                throw DayException;
            }
            else if (day > NumberDayOfMonth(month, year))
            {
                DayException.ErrorMessage = "Trong tháng " + month + " năm " + year + " không có ngày " + day;
                throw DayException;
            }

            else
            {
                this.Day = day;
                this.Month = month;
                this.Year = year;
            }

        }
        public static Date Parse(string stringDate)
        {
            string[] partsOfDate = stringDate.Split('/');

            Date date = new Date(int.Parse(partsOfDate[0]), int.Parse(partsOfDate[1]), int.Parse(partsOfDate[2]));

            return date;
        }

        public int CompareTo(Date date)
        {
            if (this.Year > date.Year)
                return 1;
            else if (this.Year == date.Year)
            {
                if (this.Month > date.Month)
                    return 1;
                else if (this.Month == date.Month)
                {
                    if (this.Day > date.Day)
                        return 1;
                    else if (this.Day == date.Day)
                        return 0;
                }
            }
            return -1;

        }

        public override string ToString()
        {
            string stringDate = "";

            if (this.Day < 10)
            {
                if (this.Month < 10)
                    stringDate += "0" + this.Day + "/" + "0" + this.Month + "/" + this.Year;
                else
                    stringDate += "0" + this.Day + "/" + this.Month + "/" + this.Year;
            }
            else if (this.Month < 10)
                stringDate += this.Day + "/" + "0" + this.Month + "/" + this.Year;
            else
                stringDate += this.Day + "/" + this.Month + "/" + this.Year;

            return stringDate;
        }
    }


    [Serializable]
    public class DayException : Exception
    {
        public static string ErrorMessage { get; set; }
        public DayException()
        {

        }
        public DayException(string message) : base(message) { }
        public DayException(string message, Exception inner) : base(message, inner) { }
        protected DayException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

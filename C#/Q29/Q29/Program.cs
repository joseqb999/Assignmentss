using System;
namespace q29
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime birthday = new DateTime(1998, 03, 22);
            int monthDifference = today.DateTi(birthday);
            if (monthDifference == 0)
            {
                Console.WriteLine("It is your birthday month this month!");
            }
            else
            {
                Console.WriteLine("It will be your birthday in " + monthDifference + " months.");
            }
        }
    }


    public static class DateTimeExtensi
    {
        public static int DateTi(this DateTime dt, DateTime birthday)
        {
            int difference = birthday.Month - dt.Month;
            if (difference < 0)
            {
                difference += 12;
            }
            return difference;
        }
    }

}
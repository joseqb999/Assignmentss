using System;
class strucStudent
{
    struct student
    {
        public string Name;
        public dtObirth Date;
    }
    struct dtObirth
    {
        public int Day;
        public int Month;
        public int Year;
    }
    static void Main(string[] args)
    {

        int dd = 0, mm = 0, yy = 0;
        int total = 2;
        student[] stude = new student[total];

        for (int i = 0; i < total; i++)
        {
            Console.Write("Name of the student : ");
            string nm = Console.ReadLine();
            stude[i].Name = nm;

            Console.Write("Input day of the birth : ");
            dd = Convert.ToInt32(Console.ReadLine());
            stude[i].Date.Day = dd;

            Console.Write("Input month of the birth : ");
            mm = Convert.ToInt32(Console.ReadLine());
            stude[i].Date.Month = mm;

            Console.Write("Input year for the birth : ");
            yy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            stude[i].Date.Year = yy;
        }
    }
}
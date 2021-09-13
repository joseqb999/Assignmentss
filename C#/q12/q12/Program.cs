using System;
public class q12
{
    static bool CheckDate(String str)
    {
        if (DateTime.TryParse(str, out DateTime d))
            return true;
        else
            return false;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a date :");
        string dateString = Console.ReadLine();
        bool IfValid = CheckDate(dateString);

        if (IfValid)
            Console.WriteLine("Successfully Parsed");
        else
            Console.WriteLine("Unsuccessfully Parsed");


    }
}
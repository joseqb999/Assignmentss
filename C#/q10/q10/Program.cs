using System;
public class q10
{
    public static void Main()
    {
        string str;
        char[] arr1;
        char ch;
        int i, j, l;
        Console.Write("Ente String : ");
        str = Console.ReadLine();
        l = str.Length;
        arr1 = str.ToCharArray(0, l);

        Array.Sort<char>(arr1);
        Console.Write("After sorting\n");
        foreach (char c in arr1)
        {
            ch = c;
            Console.Write("{0} ", ch);
        }
        Console.WriteLine("\n");
    }
}
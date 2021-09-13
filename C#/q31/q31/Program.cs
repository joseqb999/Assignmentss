using System;
using System.Linq;

class MyClass
{
    static void Main()
    {
        int[] n1 = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14,-8,-5
            };
        var nQuery =
        from VrNum in n1
        where VrNum < 0
        select VrNum;
        Console.Write("\nThe negative numbers are \n");
        foreach (var VrNum in nQuery)
        {
            Console.Write("{0}  ", VrNum);
        }
    }
}
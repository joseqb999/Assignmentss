using System;
using System.Linq;
using System.Collections.Generic;

class square
{
    static void Main(string[] args)
    {

        var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
        var sqNo = from int Number in arr1
                   let SqrNo = Number * Number
                   where SqrNo > 30
                   select new { Number, SqrNo };

        foreach (var a in sqNo)
            Console.WriteLine(a);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        List<char> letterSet = new List<char> { 'X' };
        List<int> numberSet = new List<int> { 1, 2, 3, 4 };

       
        var cartesianProduct = from letter in letterSet
                               from number in numberSet
                               select new { letterList = letter, numberList = number };

        
        Console.WriteLine("The cartesian product is:");
        foreach (var item in cartesianProduct)
        {
            Console.WriteLine("{ letterList = " + item.letterList + ", numberList = " + item.numberList + " }");
        }

    }
}
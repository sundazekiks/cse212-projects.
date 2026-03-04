using System;
using System.Diagnostics;
public class Program
{
    static void Main(string[] args)
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var init = l1.Count() + l2.Count();
        Console.WriteLine(init);
        var result = new int[init];

    }

}
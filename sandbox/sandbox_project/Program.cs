using System;
using System.Diagnostics;
public class Program
{
    static void Main(string[] args)
    {
        List<int> d = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var amount = 3;
        List<int> lastElements = d.GetRange(d.Count - amount, amount);
        d.RemoveRange(d.Count - amount, amount);
        d.InsertRange(0, lastElements);

        foreach (int i in d)
        {
            Console.WriteLine(i);
        }
    }


}
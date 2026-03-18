public class Program
{
    public static void Main(string[] args)
    {
        var myStr = Mapper("batman");

        Console.WriteLine(myStr);
    }

    public static string Mapper(string str)
    {
        var theSet = new HashSet<char>();

        foreach (char c in str)
        {
            if (theSet.Contains(c))
            {
                return $"{c.ToString()} is the duplicate value";
            }

            theSet.Add(c);
        }

        return "No duplicate letters";

    }
}
public class Program
{
    public static void Main(string[] args)
    {
        var dict = ToDictMethod("CaTTT");
        foreach (var key in dict)
        {
            Console.WriteLine($"{key.Key} {dict[key.Key]}");
        }
        foreach (var key in dict.Keys)
        {
            Console.WriteLine(key);
        }
    }
    public static Dictionary<char, int> ToDictMethod(string word)
    {

        var dict = new Dictionary<char, int>();


        var checker = (char character) =>
        {
            if (dict.ContainsKey(character))
            {
                return dict[character];
            }
            return 0;
        };

        foreach (char c in word)
        {
            dict[c] = checker(c) + 1;
        }
        return dict;
    }
}
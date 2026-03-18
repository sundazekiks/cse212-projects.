public class Program
{
    public static void Main(string[] args)
    {
        int[] numberList = new int[10];

        numberList[0] = 1;
        numberList[2] = 3;


        foreach (int i in numberList)
        {
            Console.WriteLine(-i.GetHashCode());
        }
        Console.WriteLine("Here");
        Console.WriteLine(548345952 % 10);
        Console.WriteLine("cat".GetHashCode());
    }
}
namespace Week5._1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int n1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("b = ");
        int n2 = Convert.ToInt16(Console.ReadLine());

        int largest = LargestNum(n1, n2);

        Console.WriteLine($"a = {n1}; b = {n2}");
        Console.WriteLine($"The largest number is: {largest}");

    static int LargestNum(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    }
}

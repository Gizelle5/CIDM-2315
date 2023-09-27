namespace Week5._2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int n1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("b = ");
        int n2 = Convert.ToInt16(Console.ReadLine());
        Console.Write("c = ");
        int n3 = Convert.ToInt16(Console.ReadLine());
        Console.Write("d = ");
        int n4 = Convert.ToInt16(Console.ReadLine());

        int largest = LargestNum(n1, n2, n3, n4);

        Console.WriteLine($"a = {n1}; b = {n2}; c = {n3}; d = {n4};");
        Console.WriteLine($"The largest number is: {largest}");

    static int LargestNum(int n1, int n2, int n3, int n4)
    {
        //asked gpt to fix my error on calculating the largest number

        int largest = n1;

        if (n2 > largest)
        {
            largest = n2;
        }

        if (n3 > largest)
        {
            largest = n3;
        }

        if (n4 > largest)
        {
            largest = n4;
        }

        return largest;
    }
    }
}

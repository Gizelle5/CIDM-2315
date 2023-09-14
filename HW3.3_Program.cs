namespace Homework3._3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an integer value to N: ");
        int N = Convert.ToInt16(Console.ReadLine());

    for(int row = 0; row<=N; row++){
         for(int col = 0; col<=N; col++)
    {
        if(row>col)

         Console.Write("*");
         
    }
    Console.WriteLine("");
}

    }
}

namespace Homework4._2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N is: ");
        int N = Convert.ToInt16(Console.ReadLine());
        Console.Write("Shape is ");
        string shape = Console.ReadLine();

        Console.WriteLine($"N is: {N}: Shape is {shape}");

        PrintShape(N, shape);
    }
        static void PrintShape(int N, string shape)
        {
        if(shape == "left" && N==5){
            for(int row = 0; row <= N; row++){
                for(int col = 0; col<=N; col++)
                {
                 if(row>col)
                    Console.Write("*");    
                }
                    Console.WriteLine(""); 
            }
        }
  //used chatgpt to figure out how to make the triangle go right
    else if (shape == "right" && N == 5)
        {
            for (int row=0; row<N; row++)
            {
                for (int col=0; col<N; col++)
                {
                    if (col >= N - row - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        }
    }
        


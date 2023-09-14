namespace Week3Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input an integer: ");
        int Num = Convert.ToInt16(Console.ReadLine());

        if (Num < 2){
                Console.WriteLine("N is non-prime");
        }
        else{
            for(int N = 2; N < Num; N++){
                if (Num % N == 0){
                    Console.WriteLine("N is non-prime");
                    break;
            }  
                else{
                Console.WriteLine("N is prime");
                break;
            }
        }
            
        }
    }
}

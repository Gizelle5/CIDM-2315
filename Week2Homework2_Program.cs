namespace Week2Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first num: ");
        string num1 = Console.ReadLine();
        int n1 = Convert.ToInt16(num1);

        Console.WriteLine("Please input the second num: ");
        string num2 = Console.ReadLine();
        int n2 = Convert.ToInt16(num2);

        
        Console.WriteLine("Please input the third num: ");
        string num3 = Console.ReadLine();
        int n3 = Convert.ToInt16(num3);

        if(n1<n2){
            if(n1<n3){
                Console.WriteLine("The smallest value is: " + n1);
            }
            else{
                Console.WriteLine("The smallest value is: " + n3);
            }
        }
        else{//n2<n3
            if(n2<n3){
                Console.WriteLine("The smallest value is: " + n2);
            }
            else{
                Console.WriteLine("The smallest value is: " + n3);
            }
        }

    }
}

namespace Week2Bonus;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a year: ");
        string number = Console.ReadLine();
        int year = Convert.ToInt16(number);

        bool LeapYear = ((year%4 == 0)&&(year%400 == 0 || year%100 != 0));

        //leap year
        if (LeapYear)
        { 
            Console.WriteLine(year + " is a Leap Year.");
        }
        // not leap year
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}

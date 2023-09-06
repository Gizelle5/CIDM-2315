namespace Week2Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade: ");
        string letter_grade = Console.ReadLine();
        int gpa;

        switch (letter_grade)
        {
            //A
        case "A":
            gpa = 4;
            Console.WriteLine("GPA point: " + gpa);
            break;

            //B
        case "B":
            gpa = 3; 
            Console.WriteLine("GPA point: " + gpa);
            break;

            //C
        case "C":
            gpa = 2;
            Console.WriteLine("GPA point: " + gpa);
            break;

            //D
        case "D":
            gpa = 1;
            Console.WriteLine("GPA point: " + gpa);
            break;

            //F
        case "F":
            gpa = 0;
            Console.WriteLine("GPA point: " + gpa);
            break;

            //wrong letter input
        default:
            Console.WriteLine("Wrong Letter Grade!");
            break; 
        }
        
    }
}

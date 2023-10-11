namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Professors
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000); 

        //Students
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.SetGrade(90);
        s1.classEnroll = "Java";

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.SetGrade(80);
        s2.classEnroll = "Math";

        //The sum of grade and difference of salaries
        double salaryDifference = p1.GetSalary() - p2.GetSalary();
        double TotalGrade = s1.GetGrade()+s2.GetGrade();
        
        //Print Info
        Console.WriteLine("Professor " + p1.profName + " teaches " + p1.classTeach + ", and the salary is: " + p1.GetSalary());
        Console.WriteLine("Professor " + p2.profName + " teaches " + p2.classTeach + ", and the salary is: " + p2.GetSalary());
        Console.WriteLine("Student " + s1.studentName + " enrolls " + s1.classEnroll + ", and the grade is: " + s1.GetGrade());
        Console.WriteLine("Student " + s2.studentName + " enrolls " + s2.classEnroll + ", and the grade is: " + s2.GetGrade());
        Console.WriteLine("The salary difference between Alice and Bob is: "+ salaryDifference);
        Console.WriteLine("The total grade of Lisa and Tom is: "+TotalGrade);
    }   

}

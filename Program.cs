namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        double totalGPA = 0;
        int count = 0;

        foreach (var student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.GetStudentName()))
            {
                totalGPA += gradebook[student.GetStudentName()];
                count++;
            }
        }

        double avgGPA = totalGPA / count;

        Console.WriteLine("The average GPA: " + avgGPA);

        foreach (Student student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.GetStudentName()) && gradebook[student.GetStudentName()] > avgGPA)
            {
                student.PrintInfo();
            }  
        } 
    }
}


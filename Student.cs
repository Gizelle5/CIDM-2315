class Student
{
    private int studentID;
    private string studentName;

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public static List<Student> studentList = new List<Student>();

    public Student(int studentID, string studentName)
    {
        this.studentID = studentID;
        this.studentName = studentName;
        studentList.Add(this);
    }
    public int GetStudentID()
    {
        return studentID;
    }

    public string GetStudentName()
    {
        return studentName;
    }
}

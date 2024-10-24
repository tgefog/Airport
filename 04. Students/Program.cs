namespace _04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public float Grade { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentCount; i++)
            {
                string[] studentArguments = Console.ReadLine().Split(" ");
                string firstName = studentArguments[0];
                string lastName = studentArguments[1];
                float grade = float.Parse(studentArguments[2]);

                students.Add(new Student(firstName, lastName, grade));
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(String.Join("\n", students));
        }
    }
}
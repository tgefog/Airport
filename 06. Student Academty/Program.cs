namespace _06._Student_Academty
{
    class Student
    {
        public string Name { get; set; }
        public List<decimal> Grades { get; set; }
        public Student(string name)
        {
            Name = name;
            Grades = new List<decimal>();
        }
        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            int inputCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputCount; i++)
            {
                string studentsName = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentsName))
                {
                    students.Add(studentsName, new Student(studentsName));
                }
                students[studentsName].Grades.Add(grade);
            }

            var filteredStudents = students.Where(g => g.Value.Grades.Average() >= 4.50m);
            foreach (KeyValuePair<string, Student> pair in filteredStudents)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}
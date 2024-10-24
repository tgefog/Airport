using System.Xml.Linq;

namespace _05._Courses
{
    class Course
    {
        public string Name { get; set; }
        public List<string> StudentsNames { get; set; }
        public Course(string name)
        {
            Name = name;
            StudentsNames = new List<string>();
        }
        public override string ToString()
        {
            string result = $"{Name}: {StudentsNames.Count}\n";

            for (int i = 0; i < StudentsNames.Count; i++)
            {
                result += $"-- {StudentsNames[i]}\n";
            }

            return result.Trim();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> courses = new Dictionary<string, Course>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" : ");

                string courseName = arguments[0];
                string studentName = arguments[1];

                if (!courses.ContainsKey(courseName))
                {
                    Course newCourse = new Course(courseName);
                    courses.Add(courseName, newCourse);
                }

                courses[courseName].StudentsNames.Add(studentName);
            }
            foreach (KeyValuePair<string, Course> pair in courses)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}
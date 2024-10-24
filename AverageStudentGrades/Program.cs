namespace AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //student-list[grades]
            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string name = input.Split()[0];
                decimal grade = decimal.Parse(input.Split()[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<decimal>());
                }
                studentsGrades[name].Add(grade);
            }
            foreach (var entry in studentsGrades)
            {
                string name = entry.Key;
                List<decimal> grades = entry.Value;
                decimal average = grades.Average();
                Console.WriteLine($"{name} -> {String.Join(" ",grades)} (avg: {average:f2})");
            }
        }
    }
}
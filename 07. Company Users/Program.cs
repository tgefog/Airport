namespace _07._Company_Users
{
    class Company
    {

        public string Name { get; set; }
        public List<string> EmpoyeeIDs { get; set; }
        public Company(string name)
        {
            Name = name;
            EmpoyeeIDs = new List<string>();
        }
        public void AddEmployee(string employeeId)
        {
            if (!EmpoyeeIDs.Contains(employeeId))
            {
                EmpoyeeIDs.Add(employeeId);
            }
        }
        public override string ToString()
        {
            string result = $"{Name}\n";

            for (int i = 0; i < EmpoyeeIDs.Count; i++)
            {
                result += $"-- {EmpoyeeIDs[i]}\n";
            }

            return result.Trim();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" -> ");
                string companyName = arguments[0];
                string employeeId = arguments[1];

                if (!companies.ContainsKey(companyName))
                {
                    Company company = new Company(companyName);
                    companies.Add(companyName, company);
                }
                companies[companyName].AddEmployee(employeeId);
            }
            foreach (KeyValuePair<string, Company> pair in companies)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}
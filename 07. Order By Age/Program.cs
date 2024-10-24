using System.Collections.Generic;

namespace _07._Order_By_Age
{
    class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, string id, int age)
        {
            Id = id;
            Age = age;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" ");
                string name = arguments[0];
                string id = arguments[1];
                int age = int.Parse(arguments[2]);
                Person personFound = people.FirstOrDefault(person => person.Id == id);
                if (personFound != null)
                {
                    personFound.Age = age;
                    personFound.Name = name;
                }
                else
                {
                    people.Add(new Person(name, id, age));
                }
            }
            List<Person> orderedPeople= people.OrderBy(person => person.Age).ToList();
            foreach (Person person in orderedPeople)
            {
                Console.WriteLine(person);
            }
        }

    }
}
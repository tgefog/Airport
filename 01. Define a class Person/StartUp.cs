using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person gosho=new Person();

            gosho.Name = "FoG";
            gosho.Age = 29;
            Console.WriteLine($"{gosho.Name} : {gosho.Age}");
        }
    }
}

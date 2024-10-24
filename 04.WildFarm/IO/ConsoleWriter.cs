using _04.WildFarm.IO.Interfaces;

namespace _04.WildFarm.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string str) => Console.WriteLine(str);
    }
}

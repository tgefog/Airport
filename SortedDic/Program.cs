namespace SortedDic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> studentsDictinary = new SortedDictionary<string, double>();
            studentsDictinary.Add("Ivan", 5.60);
            studentsDictinary.Add("Alex", 3.60);
            studentsDictinary.Add("Stefan", 4.90);
            studentsDictinary.Add("Boris", 4.30);

        }
    }
}
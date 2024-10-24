using _04.WildFarm.Core;
using _04.WildFarm.Core.Interfaces;
using _04.WildFarm.Factories.Interfaces;
using _04.WildFarm.Factories;
using _04.WildFarm.IO;
using _04.WildFarm.IO.Interfaces;

namespace _04.WildFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IAnimalFactory animalFactory = new AnimalFactory();
            IFoodFactory foodFactory = new FoodFactory();

            IEngine engine = new Engine(reader, writer, animalFactory, foodFactory);

            engine.Run();
        }
    }
}
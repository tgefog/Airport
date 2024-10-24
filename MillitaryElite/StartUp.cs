using MilitaryElite.Core;
using MilitaryElite.Core.Interfaces;

namespace MillitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
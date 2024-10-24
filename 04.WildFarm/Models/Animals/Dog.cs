using _04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        private const double DogWeightMultiplier = 0.4;
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        protected override double WeightMultiplier => DogWeightMultiplier;

        protected override IReadOnlyCollection<Type> PreferredFoodTypes => new HashSet<Type> { typeof(Meat) };

        public override string ProduceSound() => "Woof!";

        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}

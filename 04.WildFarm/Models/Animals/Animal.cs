﻿using _04.WildFarm.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }
        protected abstract double WeightMultiplier { get; }
        protected abstract IReadOnlyCollection<Type> PreferredFoodTypes { get; }
        public void Eat(IFood food)
        {
            if (!PreferredFoodTypes.Any(pf => food.GetType().Name == pf.Name))//if food is from its preferred food types
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            Weight += food.Quantity * WeightMultiplier;
            FoodEaten += food.Quantity;
        }

        public abstract string ProduceSound();

        public override string ToString() => $"{GetType().Name} [{Name}, ";
    }
}

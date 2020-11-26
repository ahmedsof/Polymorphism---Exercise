using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSice) : base(name, weight, wingSice)
        {
        }

        public override double WeightMultiplier => 0.25;

        public override ICollection<Type> PreferredFoods => new List<Type>() 
        { typeof(Meat) };

        public override string Producesound()
        {
            return "Hoot Hoot";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Animals;

namespace WildFarm.Models
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSice) : base(name, weight)
        {
            this.WingSice = wingSice;
        }

        public double WingSice { get; }

        public override string ToString()
        {
            return base.ToString() + $"{this.WingSice}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}

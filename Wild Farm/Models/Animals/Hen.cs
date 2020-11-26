﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSice) 
            : base(name, weight, wingSice)
        {
        }

        public override double WeightMultiplier => 0.35;

        public override ICollection<Type> PreferredFoods => new List<Type>()
        { typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds)};

        public override string Producesound()
        {
            return "Cluck";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using WildFarm.Common;
using WildFarm.Models.Foods;

namespace WildFarm.Factoris
{
    public class FoodFactory
    {
        public SerializationInfo ExceptionM { get; private set; }

        public Food CreateFood(string strType, int quantity)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == strType);

            if (type == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAnimalType);
            }

            object[] ctorParams = new object[] { quantity };

            Food food = (Food)Activator.CreateInstance(type, ctorParams);

            return food;
        }
    }
}



using System;
using Vehicles.Common;
using Vehicles.Models.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDriveable, IRefuelable
    {
        private const string SUCC_DRIVER_MSG = "{0} travelled {1} km";

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;

        }

        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumption { get; }

        public string Drive(double amount)
        {
            double fuelNeedet = amount * this.FuelConsumption;

            if (this.FuelQuantity < fuelNeedet)
            {
                throw new InvalidOperationException(String.Format(ExeptionMessages.NotEnoughtFuel, this.GetType().Name));
            }
            this.FuelQuantity -= fuelNeedet;

            return String.Format(SUCC_DRIVER_MSG, this.GetType().Name, amount);
        }

        public virtual void Refuel(double amount)
        {

            if (amount <= 0)
            {
                throw new InvalidOperationException(ExeptionMessages.NegFuel);
            }
            this.FuelQuantity += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}

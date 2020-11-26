

using System;
using Vehicles.Common;
using Vehicles.Models;

namespace Vehicles.Core.Factores
{
    public class VehicleFactory
    {
        public VehicleFactory()
        {

        }

        

        public Vehicle CreateVehicle(string vehicleType, double fuelQuantity, double fuelConsumption)
        {
            Vehicle vehicle;
            if (vehicleType == "Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumption);
            }
            else if (vehicleType == "Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption);
            }
            else
            {
                throw new InvalidOperationException(ExeptionMessages.InvalidVehicleType);
            }
            return vehicle;
        }
    }
}

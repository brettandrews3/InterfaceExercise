using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string VehicleName { get; set; }
        public bool FuelPowered { get; set; }
        public int NumberOfDoors { get; set; }
    }
}
/* DONE Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */

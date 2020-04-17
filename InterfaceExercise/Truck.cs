using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool HasTruckBed { get; set; } = true;
        public string EngineType { get; set; } = "diesel";
        public int NumberOfWheels { get; set; } = 4;
        public bool FuelPowered { get; set; } = true;
        public string VehicleName { get; set; } = "Cybertruck";
        public int NumberOfDoors { get; set; } = 2;
        public string Logo { get; set; } = "Tesla";
        public bool ForeignBrand { get; set; } = false;
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
        }
        public void Reverse()
        {
            Console.WriteLine();
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
        public void Park()
        {
            Console.WriteLine();
        }
    }
}

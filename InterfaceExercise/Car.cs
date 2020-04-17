using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    
    {
        public string TrunkType { get; set; } = "hydraulic";
        public int NumberOfDoors { get; set; } = 4;
        public int NumberOfWheels { get; set; } = 4;
        public string VehicleName { get; set; } = "Lexus";
        public bool FuelPowered { get; set; } = true;
        string ICompany.Logo { get; set; } = "Angled L";
        bool ICompany.ForeignBrand { get; set; } = true;
        bool HasChangedGears { get; set; }

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

using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int NumberOfRows { get; set; } = 3;
        public string TypeOfSuv { get; set; } = "Crossover";
        int IVehicle.NumberOfWheels { get; set; } = 4;
        string IVehicle.VehicleName { get; set; } = "Rogue";
        bool IVehicle.FuelPowered { get; set; } = false;
        int IVehicle.NumberOfDoors { get; set; } = 4;
        string ICompany.Logo { get; set; } = "Nissan";
        bool ICompany.ForeignBrand { get; set; } = true;

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

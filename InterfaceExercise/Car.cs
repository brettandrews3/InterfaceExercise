using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    
    {
        public string TrunkType { get; set; } = "lifted";
        public int NumberOfDoors { get; set; } = 4;
    }
}

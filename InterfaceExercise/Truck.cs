using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool HasTruckBed { get; set; } = true;
        public string EngineType { get; set; } = "diesel";
    }
}

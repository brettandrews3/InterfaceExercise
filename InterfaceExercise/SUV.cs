using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int NumberOfRows { get; set; }
        public string TypeOfSuv {get; set; }
    }
}

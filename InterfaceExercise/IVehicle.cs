using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string VehicleName { get; set; }
        public bool FuelPowered { get; set; }
        public int NumberOfDoors { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
        }
        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType.Name()} is in reverse. . .");
                else
                {
                    Console.WriteLine("Can't reverse until we change gears");
                }
            }
        }
        public void Park();
        public void ChangeGears(bool isChanged);
    }
}
/* DONE Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */

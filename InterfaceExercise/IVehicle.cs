using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumberOfSeats { get; set; }
        public bool GearsChanged { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void GearShift(bool isChanged);
    }

    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: All vehicles have a number of wheels... for now..
     */
}

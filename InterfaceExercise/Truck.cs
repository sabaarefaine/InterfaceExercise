using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F150";
        public int Year { get; set; } = 2020;
        public int NumberOfSeats { get; set; } = 6;
        public bool GearsChanged { get; set; }

        public string CompanyName { get; set; } = "Ford Motor Company";
        public string CEO { get; set; } = "Jim Farley";

        public bool HasAWD { get; set; } = true;
        public bool HasTruckBed { get; set; } = true;
     
       public void Drive()
        {
            if (HasAWD == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward. . .");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward. . .");
            }
        }

        public void Reverse()
        {
            if (GearsChanged == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
                GearsChanged = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until gears are changed");
            }

        }
        public void Park()
        {
            Console.WriteLine();
        }

        public void GearShift(bool isChanged)
        {
            GearsChanged = isChanged;
        }
    }
}

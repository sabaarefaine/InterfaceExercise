using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Corolla";
        public int Year { get; set; } = 2015;
        public int NumberOfSeats { get; set; } = 5;
        public bool GearsChanged { get; set; }

        public string CompanyName { get; set; } = "Toyota";
        public string CEO { get; set; } = "Akio Toyoda";

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
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

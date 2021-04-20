using System;
namespace InterfaceExercise
{
    public class SUV
    {
        public SUV()
        {
        }

        public string Make { get; set; } = "Kia";
        public string Model { get; set; } = "Sorento";
        public int Year { get; set; } = 2021;
        public int NumberOfSeats { get; set; } = 7;
        public bool GearsChanged { get; set; }

        public string CompanyName { get; set; } = "Kia";
        public string CEO { get; set; } = "Song Ho-Sung and Han Wu Park";

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */




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

using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
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

        public bool HasStickers { get; set; } = true;
        public int NumberOfCarSeats { get; set; } = 3;

        public void AboutCar()
        {
            Console.WriteLine($"{Make} {Model} from the year {Year} with a total of {NumberOfSeats} seats and an additional {NumberOfCarSeats} car seats for the tots!!");

        }

        public void Drive()
        {
            if (HasStickers == true)
            {
                Console.WriteLine($"SUV with stickers of course, {GetType().Name} now driving forward. . .");
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

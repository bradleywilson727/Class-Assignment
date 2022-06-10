using System;

namespace ClassesAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "Nissan";

            myCar.Model = "Rogue";

            myCar.Year = 2012;

            Console.WriteLine($"I drive a {myCar.Year} {myCar.Make} {myCar.Model}.");
        }
    }
}

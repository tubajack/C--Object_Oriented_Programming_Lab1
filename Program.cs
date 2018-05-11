using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a new car- Car1
            var Car1 = new Car();

            //Use dot notation to call members of Car1
            Car1.Color = "green";
            Car1.Year = 2002;
            Car1.Mileage = 200000;

            //Instantiate a second car
            var Car2 = new Car("red", 2012);

            //Access static members
            int CarCount = Car.CountCars();

            // Output to the console window
            Console.WriteLine($"There are {CarCount} cars on inventory right now.");

        }
    }
}

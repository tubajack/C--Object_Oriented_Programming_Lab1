using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCSharp1
{
  
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        private static int instances = 0;

        public Car(string Color, int year)
        {
            this.Color = Color;
            this.Year = year;
            instances++;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        public Car()
        {
             instances++;
        }

        public static int CountCars()
        {
            return instances;
        }

    }
}

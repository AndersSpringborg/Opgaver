using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5
{
    class Car : IComparable
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public double Price { get; set; }

        public Car(string make, string model, double price)
        {
            Make = make;
            Model = model;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            return Price.CompareTo(((Car)obj).Price);
        }
    }
}

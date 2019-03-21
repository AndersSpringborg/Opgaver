using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car("a", "1", 1),
                new Car("b", "6", 1),
                new Car("d", "4", 1),
                new Car ("g", "2", 10),
                new Car ("t", "10", 1),
                new Car ("z", "8", 1),
                new Car ("x", "1", 8),
                new Car ("aa", "2", 1)
            };
            cars.Sort(new MySortInverse());

            foreach (Car item in cars)
            {
                Console.WriteLine("{0,-20} {1,-20} {2}",item.Make, item.Model, item.Price);
            }
            Console.ReadKey();
        }
    }
}

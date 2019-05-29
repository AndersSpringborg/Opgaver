using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave a
            var Handy = new HandyMethods();

            var il = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8
            };

            var sl = new List<string>()
            {
                "hej", "farvel", "spurt", "kurt", "Hej", "HEJ", "Farvel"
            };

            Console.WriteLine(Handy.Max(il));
            Console.WriteLine(Handy.Min(il));
            Console.WriteLine(Handy.Max(sl));
            Console.WriteLine(Handy.Min(sl));

            // Opgave b
            int[] headArray = new int[]
            {
                1, 2, 3, 4, 5, 6, 7
            };

            int[] tailArray = new int[7];
            Handy.ArrayCopy(headArray, tailArray);

            //foreach(int item in tailArray)
            //    Console.WriteLine(item);

            // Opgave c

            Handy.Shuffel<int>(headArray);

            foreach (int item in headArray)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}

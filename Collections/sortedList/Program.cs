using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var v = new SortedList<int>(input);
            input.ForEach(s => Console.WriteLine(s));
            Console.WriteLine("\n\nv kommer nu");
            foreach (var item in v)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

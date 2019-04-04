using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var Join = new JoinAll();
            
            
            Console.WriteLine(Join.Concat("hej ", "med dig"));

            Console.WriteLine(Join.JoinThree("a", "b", "c", (l, r) => l + r));
            Console.WriteLine(Join.JoinThree("a", "b", "c", (l, r) => l + "." + r));
            Console.WriteLine(Join.JoinThree("a", "b", "c", (l, r) => l));


            var list = new List<string>() { "a", "b", "c", "d", "e" };
            Console.WriteLine(Join.JoinAllStrings(list, (l,r) => l + "." + r));
            Console.WriteLine(Join.JoinAllStrings(list, (l, r) => l + r));
            Console.WriteLine(Join.JoinAllStrings(list, (l, r) => r));

            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(Join.JoinEver(list2, (v,b) => v + b ));
            Console.WriteLine(Join.JoinEver(list, (v, b) => b + "." + v));

            Console.ReadKey();
        }

    }
}

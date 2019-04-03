using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineSystemCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User kurt = new User(1, "Anders", "Springborg", Console.ReadLine());
                Console.WriteLine(kurt.UserName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("hej");
                throw;
            }
            Console.ReadLine();
        }
    }
}

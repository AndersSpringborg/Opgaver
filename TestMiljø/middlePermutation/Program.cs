using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middlePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefg";
            if ((str.Length % 2) == 0)
            {
                Console.WriteLine(str[(str.Length / 2) - 1] + far(str.Remove((str.Length / 2) - 1, 1)));
            }
            else
            {
                Console.WriteLine(str[((str.Length) / 2)] + far(str.Remove((str.Length / 2), 1)));
            }
            Console.ReadKey();
        }
        public static string far(string input)
        {
            if (input.Length == 1)
                return input;
            else return input[input.Length - 1] + far(input.Remove(input.Length-1));
        }
    }
}
//CodeWars
//namespace myjinxin
//{
//    using System;

//    public class Kata
//    {
//        public string MiddlePermutation(string s)
//        {
//            if ((s.Length % 2) == 0)
//            {
//                return s[(s.Length / 2) - 1] + far(s.Remove((s.Length / 2) - 1, 1));
//            }
//            else
//            {
//                return s[((str.Length) / 2)] + far(s.Remove((s.Length / 2), 1));
//            }
//        }

//        private static string last(string input)
//        {
//            if (input.Length == 1)
//                return input;
//            else return input[input.Length - 1] + far(input.Remove(input.Length - 1));
//        }
//    }
//}
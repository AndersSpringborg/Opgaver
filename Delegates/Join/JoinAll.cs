using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{

    class JoinAll
    {
        public delegate string StringJoin(string l, string r);

        public StringJoin Concat { get => ConcatString; }

        public T JoinEver<T>(List<T> list, Func<T, T, T> function)
        {
            T result = list[0];
            foreach (T item in list.Skip(1))
            {
                result = function(result, item);
            }
            return result;
        }
        private string ConcatString(string l, string r) => l + r;
        public string JoinThree(string str1, string str2, string str3, StringJoin function) => function(function(str1, str2), str3);
        public string JoinAllStrings(List<string> input, StringJoin function)
        {
            string result = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                result = function(result, input[i]);
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class HandyMethods
    {
        // Opgave 1.a
        public T Max<T> (List<T> list) where T: IComparable
        {
            T maxValue = list[0];
            foreach (T item in list)
            {
                if (item.CompareTo(maxValue) > 0)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }

        public T Min<T>(List<T> list) where T : IComparable
        {
            T minValue = list[0];
            foreach (T item in list)
            {
                if (item.CompareTo(minValue) < 0)
                {
                    minValue = item;
                }
            }
            return minValue;
        }

        // Opgave b
        public void ArrayCopy<T> (T[] list1, T[] list2)
        {
            if (list1.Length > list2.Length)
            {
                throw new Exception("Du er noob, arrays er ikke lige lange");
            }
            Array.Copy(list1, list2, list1.Length);
        }
        
        // Opgave c. 
        public void Shuffel<T> (T[] list1)
        {
            int n = list1.Length,
                i,
                j;
            T swap;
            var random = new Random();
            for (int k = 0; k < n; k++)
            {
                i = random.Next(n);
                j = random.Next(n);
                swap = list1[i];
                list1[i] = list1[j];
                list1[j] = swap;
            }
        }
    }
}

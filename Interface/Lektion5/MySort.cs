using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5
{
    class MySortStandard : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.Make.CompareTo(y.Make) != 0)
            {
                return x.CompareTo(y.Make);
            }
            else if (x.Model.CompareTo(y.Model) != 0)
            {
                return x.Model.CompareTo(y.Model);
            }
            else
                return x.Price.CompareTo(y.Price);
        }
    }

    class MySortInverse : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.Model.CompareTo(y.Model) != 0)
            {
                return x.Model.CompareTo(y.Model);
            }
            else
                return y.Price.CompareTo(x.Price);
        }
    }


}

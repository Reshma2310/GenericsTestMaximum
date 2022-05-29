using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    public class MaximumValue<T> where T : IComparable
    {        
        public T MaximumOfInputs<T>(T input1, T input2, T input3) where T : IComparable
        {
            if (input1.CompareTo(input2) > 0 && input1.CompareTo(input3) >0)
            {
                return input1;
            }
            else if (input2.CompareTo(input1) > 0 && input2.CompareTo(input3) > 0)
            {
                return input2;
            }
            else
                return input3;
        }
    }
}

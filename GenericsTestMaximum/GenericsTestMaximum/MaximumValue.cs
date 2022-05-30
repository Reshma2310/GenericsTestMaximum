using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    public class MaximumValue<T> where T : IComparable
    {
        public T[] inputArray;
        public MaximumValue(T[] inputArray)
        {
            this.inputArray = inputArray;            
        }
        public T[] SortArray(T[] inputArr)
        {
            Array.Sort(inputArr);
            return inputArr;
        }
        public T MaxValue(T[] MaxInput)
        {
            var inputArr = this.SortArray(MaxInput);
            return inputArr[inputArr.Length - 1];
        }
        public T MaxValue()
        {            
            T max = MaxValue(this.inputArray);
            return max;            
        }
        public void PrintMaxValue(T max)
        {
            Console.WriteLine("Maximum Value is: " + max);
        }
    }
}

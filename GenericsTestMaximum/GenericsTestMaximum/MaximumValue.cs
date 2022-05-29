﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    public class MaximumValue<T> where T : IComparable
    {
        public int MaximumOfAll(int num1, int num2, int num3)
        {            
            if (num1>num2 && num1>num3)
            {
                return num1;
            }
            else if (num2>num1 && num2>num3)
            {
                return num2;
            }
            else
                return num3;
        }
        public float MaximumOfFloat(float num1, float num2, float num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
                return num3;
        }
    }
}

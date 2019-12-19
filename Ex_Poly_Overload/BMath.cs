using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Poly_Overload
{
    class BMath:AMath
    {
        public int GetMax(int[] num)
        {
            int max = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if(num[i]>max)
                {
                    max = num[i];
                }
            }
            return max;
        }
    }
}

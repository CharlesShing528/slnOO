using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_01
{
    class CMath
    {
        public int GetMin(int n1,int n2)
        {
            if (n1 > n2)
                return n1;
            else
                return n2;
        }

        public int GetMin(int[] n1)
        {
            int min = n1[0];
            for (int i = 1; i < n1.Length-1; i++)
            {
                if (min > n1[i])
                    min = n1[i];
            }
            return min;
        }
    }
}

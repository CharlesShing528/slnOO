using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Poly_Overload
{
    class AMath
    {
        public int GetMax(int num1,int num2)
        {
            if(num1>num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}

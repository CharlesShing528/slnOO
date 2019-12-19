using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Inheritance_01
{
    class CalA
    {
        // 可給繼承本類別的子類別繼承
        protected int num1, num2;

        public void SetValue(int n1,int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public int GetSum()
        {
            return num1 + num2;
        }
    }
}

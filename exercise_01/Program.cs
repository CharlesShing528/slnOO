using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CMath cMath = new CMath();
            int a = -20;
            int b = 15;
            Console.WriteLine("{0}, {1} 較小值為 {2}",a,b,cMath.GetMin(a,b));
            int[] c = { -10, 0, 30, -12, 25 };
            string cValue = "";
            foreach(var cv in c)
            {
                if (cValue != "")
                    cValue += ",";
                cValue += cv;
            }
            Console.WriteLine("{0} 中最小值為 {1}",cValue,cMath.GetMin(c));
            Console.Read();
        }
    }
}

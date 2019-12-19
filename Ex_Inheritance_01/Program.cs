using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Inheritance_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CalA aa = new CalA();
            int n1, n2;
            n1 = 10; n2 = 15;
            aa.SetValue(n1, n2);
            Console.WriteLine("{0} + {1} = {2}",n1,n2,aa.GetSum());
            Console.WriteLine("---------------------");
            CalB bb = new CalB();
            n1 = 20;n2 = 25;
            bb.SetValue(n1, n2);
            Console.WriteLine("{0} + {1} = {2}",n1,n2,bb.GetSum()   );
            Console.WriteLine("{0} * {1} = {2}", n1, n2, bb.GetMult());
            Console.Read();
        }
    }
}

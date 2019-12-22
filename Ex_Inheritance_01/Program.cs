using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 一個父類別可衍生多個子類別，但一個子類別只能繼承一個父類別。
/// 子類別不能繼承父類別內存取層級使用 priave 宣告的成員，
/// 但可繼承父類別內使用 public 和 protected 宣告的成員。
/// protected 所宣告的成員屬於保護層級的成員，除了本身類別存取外
/// ，也允許子類別做存取。
/// </summary>
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

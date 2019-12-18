using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXConstructor_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Console.WriteLine();
            Rectangle rect2 = new Rectangle(15,10);
            Console.WriteLine("矩形長度：{0}",rect2.Length);
            Console.WriteLine("矩形寬度：{0}", rect2.Width);
            Console.WriteLine("矩形面積：{0}", rect2.GetArea());
            Console.Read();
        }
    }
}

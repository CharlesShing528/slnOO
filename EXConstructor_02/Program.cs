using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXConstructor_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Console.WriteLine("矩形一 採 Rectangle() 預設建構函式…");
            Console.WriteLine("長度：{0}，寬度：{1}，面積：{2}",rect1.Length,rect1.Width,rect1.GetArea());
            Console.WriteLine();

            Rectangle rect2 = new Rectangle(12);
            Console.WriteLine("矩形二 採 Rectangle(12) 建構函式…");
            Console.WriteLine("長度：{0}，寬度：{1}，面積：{2}", rect2.Length, rect2.Width, rect2.GetArea());
            Console.WriteLine();

            Rectangle rect3 = new Rectangle(15,10);
            Console.WriteLine("矩形二 採 Rectangle(15,10) 建構函式…");
            Console.WriteLine("長度：{0}，寬度：{1}，面積：{2}", rect3.Length, rect3.Width, rect3.GetArea());
            Console.WriteLine();

            Console.Read();
        }
    }
}

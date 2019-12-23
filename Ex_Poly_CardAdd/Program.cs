using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 物件在設計時即決定可呼叫所屬類別的方式，若能在園式執行過程中，經過使用者的選擇
/// ，物件參照才決定指向所呼叫的類別方法。
/// 透過這種動態繫結的技巧，才是多型的效用，而多型若要發揮功用，
/// 須使用引數的傳遞。
/// 
/// 某人收集有多張半徑不同的圓形及多張高、寬不同的矩形卡片，要一一
/// 顯示這些卡片經計算過的面積，並顯示這些卡片的累計總面積。
/// 用多型不使用引數傳遞的技術。
/// </summary>
namespace Ex_Poly_CardAdd
{
    /// <summary>
    /// Card 類別將為圓形 Circle類別及矩形 Rectangle類別的父類別。
    /// </summary>
    class Card
    {
        /// <summary>
        /// 空殼的 area() 方法，允許子類別被覆寫
        /// 準備被實作多型的成員
        /// </summary>
        /// <returns></returns>
        public virtual double area()
        {
            return 0;
        }
    }

    class Circle:Card
    {
        /// <summary>
        /// Radius 為半徑屬性
        /// </summary>
        public double Radius { get; set; }

        public Circle(double r)
        {
            Radius = r;
        }
        /// <summary>
        /// 覆寫父類別的 area()方法
        /// </summary>
        /// <returns></returns>
        public override double area()
        {
            return 3.14*Radius*Radius;
        }
    }

    class Rectangle:Card
    {
        public double High { get; set; }
        public double Widt { get; set; }
        public Rectangle(double h,double w)
        {
            High = h;
            Widt = w;
        }

        /// <summary>
        /// 覆寫父類別的 area()方法
        /// </summary>
        /// <returns></returns>
        public override double area()
        {
            return High * Widt;
        }
    }

    class CalArea
    {
        /// <summary>
        /// totArea 記錄卡片圖形累計的面積
        /// </summary>
        private static double totArea;

        /// <summary>
        /// 引數 Card c 是父類別的物件參照
        /// </summary>
        /// <param name="c"></param>
        public CalArea(Card c)
        {
            totArea += c.area();
            Console.WriteLine("本卡片面積{0}，目前累計面積為 {1}",c.area(),totArea);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalArea cal;
            Circle cir;
            Rectangle rec;
            while(true)
            {
                Console.WriteLine("請輸入收集的卡片形狀？（1.圓形 2.矩形 3.離開): ");
                int item = int.Parse(Console.ReadLine());
                if(item==1)
                {
                    Console.WriteLine("輸入圓形半徑：");
                    int r = int.Parse(Console.ReadLine());
                    cir = new Circle(r);
                    cal = new CalArea(cir);
                }
                else if(item==2)
                {
                    Console.WriteLine("輸入矩形長度： ");
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine("輸入矩形寬度： ");
                    int w = int.Parse(Console.ReadLine());
                    rec = new Rectangle(h, w);
                    cal = new CalArea(rec);
                }
                else
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

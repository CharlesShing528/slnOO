using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXclass01
{
    /// <summary>
    /// 如何存取方法成員
    /// </summary>
    class Program
    {
        class NBClass
        {
            private int price;

            /// <summary>
            /// 公用方法成員
            /// </summary>
            /// <param name="tPrice"></param>
            public void setPrice(int tPrice)
            {
                price = tPrice;
            }

            /// <summary>
            /// 公用方法成員
            /// </summary>
            /// <returns></returns>
            public int getPrice()
            { return price; }
        }
        static void Main(string[] args)
        {
            //宣告同時建立物件實體
            // 所讚「實體」代兵一個可體立運作
            // 、可瞭解事情以及做事情的物件。
            NBClass sun = new NBClass();
            //透過 setPrice()方法設定 Price
            sun.setPrice(25000);

            Console.WriteLine("Sun 筆電單價:{0}",sun.getPrice());
            Console.Read();
        }
    }
}

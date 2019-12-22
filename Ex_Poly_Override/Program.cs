using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 子類別繼承父類別的成員後，若子類別內定義了一個和父類別名稱相同的成員時
/// (其中方法成員的傳入引數數目和型別皆須相同)，則父類別該名稱相同的成員會
/// 被子類別的相同名稱的方法成員所覆蓋(Override)。有以下兩種方式：
/// 1.子類別使用 new 來取代父類別的相同名稱成員(方法或屬性)。
/// 2.在父類別用 viritual 宣告的成員，表示允許被子類別取代。當子類別取代
/// 取代父類別該成員時，必須用 override 宣告, 則該成員將重新定義。
/// </summary>
namespace Ex_Poly_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Mammal = "狗";
            dog.dispaly();
            Console.WriteLine("---------------");
            // 建立子類別 per物件的實的，可繼承父類別 Animal 的成員
            Person per = new Person();
            /* 呼叫 Person 子類別的 per.display()方法，
             * 因父類別的 dispaly()方法被覆寫，不執行 Animal父類別
             * ，改執行 子類別 Person.display()
             */
            per.dispaly();
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Poly_Base
{
    class Animal
    {
        public virtual void display()//允許被子類別覆寫
        {
            Console.WriteLine("現在是執行 父類別 Animal");
        }
    }

    class Person:Animal     //子類別 Person 繼承父類別 Animal
    {
        public override void display() //覆寫父類別的 dispaly()方法
        {
            Console.WriteLine("現在是執行 子類別 Person");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();          
            Person per = new Person();
            ani.display();
            per.display();
            Console.WriteLine("-----------------------");
            ani = per;              //父類別物件參照指向子類別
            /* ani 物件目前已參照指向 per物件，
             * 本敘述所呼叫的display()方法，會是建立 per物件的子類別
             * Person 的 display()方法
             */
            ani.display();          
            Console.Read();
        }
    }
}

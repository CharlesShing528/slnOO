using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Poly_Override
{
    public class Person:Animal
    {
        /// <summary>
        /// 覆蓋父類別 Mammal
        /// </summary>
        public new string Mammal
        {
            get { return "人"; }
        }

        public string Special 
        {
            get { return "智慧"; }
        }

        /// <summary>
        /// 覆蓋父類別 dispaly()方法
        /// </summary>
        public override void dispaly()
        {
            base.dispaly();
            Console.WriteLine("{0} 是 {1}",Mammal,kind);
            Console.WriteLine("{0} 是 {1} 的 {2}",Mammal,Special,kind);
        }
    }
}

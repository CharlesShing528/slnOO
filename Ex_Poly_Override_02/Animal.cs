using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Poly_Override_02
{
    public class Animal
    {
        /// <summary>
        /// 用 protected 宣告只允許給子類別繼承,
        /// 但在非父子類別境內的敘述是無法存取。
        /// </summary>
        protected string kind = "動物";
        public string Mammal { set; get; }

        /// <summary>
        /// 允許被子類別覆寫
        /// </summary>
        public virtual void dispaly()
        {
            Console.WriteLine("{0} 是 {1}", Mammal, kind);
            Console.WriteLine("---------------");
        }
    }
}

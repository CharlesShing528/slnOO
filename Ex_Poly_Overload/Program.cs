using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 多型又名「同名異式」，其特微就是透過單一介面，針對相同的資料設計不同的存取方式
/// ，藉由引數個數或資料型別的不同來取出所需的資料，讓軟體具有高度的可修性。
/// 「同名異式」一詞中的「同名」就是指函式的名稱與函式傳回值的資料型別都相同
/// ，而「異式」是多個同名稱的函式，但各函式內部的程式碼依引數個數國資料型別而不同。
/// 
/// </summary>
namespace Ex_Poly_Overload
{
    /// <summary>
    /// 多載(overload) 多重定義方法
    /// </summary>
    class Program
    {
        /// <summary>
        /// 在同類別中或在父、子類別中方法名稱可相同，但引數的型別、數目不同，呼叫後的結果也是不同
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BMath math = new BMath();
            int n1 = 20, n2 = 30;
            // 執行 AMath  父類別的 GetMax() 方法
            Console.WriteLine("{0},{1} 較大值為 {2}", n1, n2, math.GetMax(n1, n2));

            int[] n = { 10, 20, 30, 40, 50 };
            // 執行 BMath  父類別的 GetMax() 方法
            Console.WriteLine("{0},{1},{2},{3},{4} 中最大值為 {5}", n[0],n[1],n[2],n[3],n[4],math.GetMax(n));

            Console.Read();
        }
    }
}

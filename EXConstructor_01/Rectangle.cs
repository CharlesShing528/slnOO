using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 建構函式是類別在建立物件實體時自動在幕後執行的方法方員。
/// 當類別使用 new 觮立該類別物件的實體時，立即執行和類別同名的建構函式。
/// 建構函式不允許傳回值
/// </summary>
namespace EXConstructor_01
{
    class Rectangle
    {
        public int Length { get; set; }// Length 為長度屬性
        public int Width { get; set; }// Width 為寬度屬性

        public Rectangle()  // 沒引數的 Default Constructor
        {
            Console.WriteLine("已進入 Default Constructor ...");
        }

        public Rectangle(int L, int W)  //含有長和寬引數的建構函式
        {
            Length = L;
            Width = W;
        }

        public int GetArea()
        {
            return Length * Width;
        }
    }
}

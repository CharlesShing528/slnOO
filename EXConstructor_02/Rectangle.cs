using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXConstructor_02
{
    class Rectangle
    {
        public int Length { get; set; }// Length 為長度屬性
        public int Width { get; set; }// Width 為寬度屬性

        public Rectangle()      // 沒有引數的 Default Constructor
        {
            Length = 10;
            Width = 10;
        }

        public Rectangle(int L)      // 一個長度的引數的建構函式 Constructor
        {
            Length = L;
            Width = 10;
        }

        public Rectangle(int L, int W)   // 含有長和寬引數的建構函式 Constructor
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

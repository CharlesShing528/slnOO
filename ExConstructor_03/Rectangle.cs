using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExConstructor_03
{
    class Rectangle
    {
        public int Length { get; set; }// Length 為長度屬性
        public int Width { get; set; }// Width 為寬度屬性

        public int GetArea()
        {
            return Length * Width;
        }
    }
}

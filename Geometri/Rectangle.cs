using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Rectangle : Shape
    {
        public override float CalculateArea()
        {
           return Heigth * Width;
        }
        public Rectangle(int heigth, int width)
        {
            Heigth = heigth;
            Width = width;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
   public abstract class Shape
    {
        private int _width;
        private int _height;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public int Heigth
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;

            }
        }
        public abstract float CalculateArea();

    }
}

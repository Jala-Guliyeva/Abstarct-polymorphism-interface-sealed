using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Models
{
    class Rectangular:Figure
    {
        private int _width;
        private int _length;

        public Rectangular()
        {
        }

        public Rectangular(int width,int length)
        {
            this.Width = 20;
            this.Length = 10;
        }
        public int Width
        {
            get => _width;
            set
            {
                if (value > 0)
                    _width = value;
            }
        }
        public int Length
        {
            get => _length;
            set
            {
                if (value > 0)
                    _length = value;
            }
        }

        public override int CalcArea(int area)
        {
            return Width*Length;
        }

        internal int CalcArea(string area)
        {

        }
    }
}

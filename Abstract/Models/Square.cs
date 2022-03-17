using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Models
{
    class Square:Figure
    {
        private int _side;
        public Square(int side)
        {
            this.Side = side;
        }

        public Square()
        {
        }

        public override int CalcArea(int area)
        {
            return area;
        }
        public int Side
        {
            get => _side;
            
            set
            {
                if (value > 0)
                    _side = value;
            }
        }

        internal int CalcArea(int area)
        {
            return area;
        }

        internal int CalcArea(string area)
        {
            throw new NotImplementedException();
        }
    }
}

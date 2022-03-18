using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea.Models
{
    internal class Square:Figure
    {
        private int _side;

        public int side 
        {
            get
            {
                return _side;
            }
               
            set
            {
                if(value >0)
                    _side = value;
                else
                    Console.WriteLine("Side can not 0 or negative");
            }
        }

        public Square(int _side)
        {
            this._side = _side;
        }

        public override int CalcArea()
        {
            int _side = 5;
            int area = _side * _side;
            return area;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea.Models
{
    internal class Recangular : Figure
    {
        private int _width;
        private int _length;

        public int width 
        {
            get
            {
                return _width;
            }

            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                    Console.WriteLine("Width can not 0 or negative");
                
            }
        }

        public int length 
        { 
            get
            {
                return _length;
            }
            set
            {
                if(value> 0)
                    _length = value;
                else
                    Console.WriteLine("Length can not 0 or negative");
            }
        }

        public Recangular(int _width, int _length)
        {
            this._width = width;
            this._length = length;
        }

        public override int CalcArea()
        {
            _length = 10;
            _width = 8;
            int area = _width * _length;
            return  area;
        }
    }
}

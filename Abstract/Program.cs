using Abstract.Models;
using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangular");
            Console.WriteLine("0. Quit");
            string choice = Console.ReadLine();

            string area;
            switch (choice)
            {
                case "1":
                    area = Console.ReadLine();

                    Square square = new Square();
                    Console.WriteLine(square.CalcArea(area));
                    break;
                case "2":
                    area = Console.ReadLine();

                    Rectangular rectangular = new Rectangular();
                    Console.WriteLine(rectangular.CalcArea(area));
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("the end");
                    break;
            }
        }
    }
}

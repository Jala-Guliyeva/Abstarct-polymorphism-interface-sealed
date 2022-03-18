using System;
using CalculateArea.Models;
namespace CalculateArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----MENU----");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangular");
            Console.WriteLine("0. Quit");

            string select = Console.ReadLine();

            
            switch (select)
            {
                case "1":
                    Square sqr = new Square(-5);
                    Console.WriteLine($"Square area is {sqr.CalcArea()}m²");
                    break;

                case "2":
                    Recangular rctgl = new Recangular(10,8);
                    Console.WriteLine($"Rectangular area is {rctgl.CalcArea()}m²");
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Not Found");
                    break;
            }



        }
    }
}

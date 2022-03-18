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

            string selection = Console.ReadLine();

            
            switch (selection)
            {
                case "1":
                    Square square = new Square(-5);
                    Console.WriteLine($"Square area : {square.CalcArea()}");
                    break;

                case "2":
                    Recangular recangular = new Recangular(10,8);
                    Console.WriteLine($"Rectangular area : {recangular.CalcArea()}");
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Not found");
                    break;
            }



        }
    }
}

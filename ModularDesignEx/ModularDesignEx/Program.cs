using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModularDesignEx
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateE();
            Console.WriteLine("__________");
            CreateK();
            Console.ReadKey();
        }

        static void PrintStar(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void CreateK()
        {
            for (int i = 4; i >0; i--)
                PrintStar(i);
            for (int i = 2; i < 5; i++)
                PrintStar(i);
        }


        static void CreateE()
        {
            PrintStar(4);
            PrintStar(1);
            PrintStar(1);
            PrintStar(4);
            PrintStar(1);
            PrintStar(1);
            PrintStar(4);
        }
    }
}

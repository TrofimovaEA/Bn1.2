 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bn1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inside = "Точка внутри контура!";
            string outside = "Точка вне контура!";
            double r, x, y;
            Console.WriteLine("Введите абциссу точки");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату точки");
            y = double.Parse(Console.ReadLine());
            if (y > 0)
                if ((Math.Abs(x) + Math.Abs(y)) <= 1)
                    Console.WriteLine(inside);
                else Console.WriteLine(outside);
            else if (x >= -1 && x <= 1 && y >= -1)
                Console.WriteLine(inside);
            else Console.WriteLine(outside);
            Console.ReadKey();

        }
    }
}


using System;
using System.Threading;

namespace kalkulatorDelty
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta;
            Console.WriteLine("Witaj w kalkulatorze delty " +
                              "dla równania kwadratowego ax^2 + bx + c");
            Console.Write("Podaj a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj c= ");
            c = Convert.ToInt32(Console.ReadLine());
            delta = (Math.Pow(b, 2)) - 4 * a * c;
            Console.WriteLine("Delta wynosi= {0}",delta );
            Console.ReadKey();
        }
    }
}

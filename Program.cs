using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            String ent1,ent2,ent3;
            double a, b, c, per, area;

            Console.Write("Valor A: ");
            ent1 = Console.ReadLine();
            Console.Write("Valor B: ");
            ent2 = Console.ReadLine();
            Console.Write("Valor C: ");
            ent3 = Console.ReadLine();

            a = Convert.ToDouble(ent1);
            b = Convert.ToDouble(ent2);
            c = Convert.ToDouble(ent3);

            per = (a + b + c) / 2;

            area = per * (per - a) * (per - b) * (per - c);
            
            Console.WriteLine();
            Console.WriteLine($"O semiperímetro é {per}");
            Console.WriteLine($"A área é {Math.Sqrt(area)}");

         

        }
    }
}

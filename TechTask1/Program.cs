using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xA, yA, xB, yB, xC, yC, AC, AB, BC, P;

            Console.WriteLine("Введіть X координату точки А:");
            xA =
            Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть Y координату точки А:");
            yA =
            Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть X координату точки B:");
            xB =
            Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть Y координату точки B:");
            yB =
            Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть X координату точки C:");
            xC =
            Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть Y координату точки C:");
            yC =
            Double.Parse(Console.ReadLine());
            Console.Write("Сторона AB=");
            Console.WriteLine(AB = Math.Sqrt((Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2))));
            Console.Write("Сторона AC=");
            Console.WriteLine(AC = Math.Sqrt((Math.Pow((xA - xC), 2) + Math.Pow((yA - yC), 2))));
            Console.Write("Сторона BC=");
            Console.WriteLine(BC = Math.Sqrt((Math.Pow((xB - xC), 2) + Math.Pow((yB - yC), 2))));
            if (AC == AB && AB == BC)
            {
                Console.WriteLine("Трикутник є рівностороннім");
            }
            else
            {
                Console.WriteLine("Трикутник не є рівностороннім");
            }
            if (AB == AC || AB == BC || AC == BC)
            {
                Console.WriteLine("Трикутник є рівнобедреним");
            }
            else
            {
                Console.WriteLine("Трикутник не є рівнобедреним");
            }
            if (Math.Pow(AB, 2) == Math.Pow(AC, 2) + Math.Pow(BC, 2) || Math.Pow(AC, 2) == Math.Pow(AB, 2) + Math.Pow(BC, 2) || Math.Pow(BC, 2) == Math.Pow(AC, 2) + Math.Pow(AB, 2))
            {
                Console.WriteLine("Трикутник є прямокутним");
            }
            else
            {
                Console.WriteLine("Трикутник не є прямокутним");
            }
            Console.Write("Периметр трикутника дорівнює: ");
            Console.WriteLine(P = AB + BC + AC);
            for (var i = 0; i < P; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

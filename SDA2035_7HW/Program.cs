using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_7HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину сторон первого треугольника");
            double S1 = TriangleArea();
            if (S1 == 0)
                return;
            Console.WriteLine("Введите длину сторон второго треугольника");
            double S2 = TriangleArea();
            if (S2 == 0)
                return;

            if (S1 > S2)
                Console.WriteLine("Площадь первого треугольника больше, (S1 = {0:f2}) > (S2 = {1:f2})", S1, S2);
            if (S2 > S1)
                Console.WriteLine("Площадь второго треугольника больше, (S2 = {0:f2}) > (S1 = {1:f2})", S2, S1);
            if (S2 == S1)
                Console.WriteLine("Площади треугольников одинаковы, (S2 = {0:f2}) = (S1 = {1:f2})", S2, S1);
            Console.ReadKey();
        }
        static double TriangleArea()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            if (z > x + y) //проверка на соответствие
            {
                Console.WriteLine("Ошибка! Неверное соотношение сторон треугольника");
                Console.ReadKey();
                double Fail = 0;
                return Fail;
            }
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }
}

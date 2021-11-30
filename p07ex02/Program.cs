using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            int S, V;
            CubeParameters(a, out S, out V);
            Console.WriteLine("Объем куба = {0}", V);
            Console.WriteLine("Площадь поверхности куба = {0}", S);
            Console.ReadKey();
        }
        static void CubeParameters(int a, out int S, out int V)
        {
            V = a * a * a;
            S = (a * a) * 6;
        }
    }
}

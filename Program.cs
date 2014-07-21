using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1a
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h;
            
            Console.WriteLine("Введите радиус окружности R:");
            string s = Console.ReadLine();
            r = double.Parse(s);
            Console.WriteLine("Введите высоту H, по значению меньше R:");
            s = Console.ReadLine();
            h = double.Parse(s);

            if (r < 0 || h < 0)
                Console.WriteLine("Отрицательных чисел быть не может!");
            if (r < h)
                Console.WriteLine("Высота не может быть больше радиуса!");
            else
            {
                Shar sh = new Shar(r, h);
                Console.WriteLine("Площадь поверхности шара = {0}", sh.PLOSHAD);
                Console.WriteLine("Объём шара = {0}", sh.OBJEM);
                Console.WriteLine("Oбъем куба, в который вписан шар = {0}", sh.VCUBE);
                Console.WriteLine("Oбъем шарового слоя = {0} ", sh.VSegm);
            }
            Console.ReadKey();
         }
    }
}

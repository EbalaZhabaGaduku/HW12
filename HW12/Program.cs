using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = new double();
            Console.WriteLine("Введите координату х точки");
            double x = new double();
            Console.WriteLine("Введите координату у точки");
            double y = new double();
            Rectungle.Cumference(Number(r));
            Rectungle.Square(Number(r));
            Rectungle.Position(Number(r),Number(x),Number(y));
            Console.ReadKey();
        }
         static double Number (double d)
        {
            try
            {
                d=Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("Неверный формат");
            }
            return d;
        }

    }
    static class Rectungle
    {
        public static void Cumference(double Radius)
        {
            if (Radius<0)
            {
                Console.WriteLine("Значение не может быть отрицательным");
            }
            else
            {
                double cumference = Math.PI * 2 * Radius;
                Console.WriteLine("Длина окружнсти = {0:f2}", cumference);
            }
           
        }
        public static void Square(double Radius)
        {
            if (Radius < 0)
            {
                Console.WriteLine("Значение не может быть отрицательным");
            }
            else
            {
                double square = Math.PI * Math.Pow(Radius, 2);
                Console.WriteLine("Площадь окружнсти = {0:f2}", square);
            }
           
        }
        public static void Position(Double Radius, double X, Double Y)
        {
            if (Math.Abs(X)<=Radius&&Math.Abs(Y)<=Radius)
            {
                Console.WriteLine("Точка принадлежит кругу");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит кругу");
            }
        }
    }
}

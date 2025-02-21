using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_Danik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto avto = new Auto();
            Console.WriteLine(avto.ToString());
          
            Auto avto2 = new Auto("TOYOTA", "RED", 220);
            Console.WriteLine(avto2.ToString());
            
            Console.WriteLine("Введите марку");
            string brand = Console.ReadLine();
            Console.WriteLine("Введите цвет");
            string color = Console.ReadLine();
            Console.WriteLine("Введите скорость");

            double skor = double.Parse(Console.ReadLine());
            Auto avto3 = new Auto(brand, color, skor);
            Console.WriteLine($"{avto3.ToString()}\n");
            Console.ReadLine();
        }
    }
}

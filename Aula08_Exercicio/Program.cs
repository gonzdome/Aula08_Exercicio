using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //transporte, xérox, cantina, apm

            Console.WriteLine("Quanto foi gasto em transporte?");
            double n1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Quanto foi gasto em xérox?");
            double n2 = double.Parse(Console.ReadLine());

           Console.WriteLine("Quanto foi gasto em cantina?");
            double n3 = double.Parse(Console.ReadLine());

           Console.WriteLine("Quanto foi gasto em apm?");
            double n4 = double.Parse(Console.ReadLine());


            double r = n1 + n2 + n3 + n4;

            Console.WriteLine("O total gasto foi de R$" + r + "!");

            Console.ReadKey();
        }
    }
}

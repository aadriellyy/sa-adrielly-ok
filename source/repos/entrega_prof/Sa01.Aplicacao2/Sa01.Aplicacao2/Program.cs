using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sa01.Aplicacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aviao1 = 0.0;
            double aviao2 = 0.0;
            double total;

            Console.WriteLine("Digite o valor do primeiro avião");
            aviao1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo avião");
            aviao2 = Convert.ToInt32(Console.ReadLine());

            total = aviao1 + aviao2;
            Console.WriteLine("O valor total dos dois aviões é de: " + total + " reais.");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mes1;
            double mes2;
            double mes3;

            Console.WriteLine("Digite o faturamento do mês 1: ");
            mes1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o faturamento do mês 2: ");
            mes2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o faturamento do mês 3: ");
            mes3 = double.Parse(Console.ReadLine());

            double media = (mes1 + mes2 + mes3) / 3;

            Console.WriteLine("A média de faturamento trimestral da VoeAirlines foi de " + media + " reais");
        }
    }
}

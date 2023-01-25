using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            string continuar;
            int subtracao = 2020 - 1971;
            Console.WriteLine("Você quer saber em qual ano foi lançado o primeiro avião pela Embraer? Responda com 'sim' ou 'não' ");
            resposta = Console.ReadLine();
               if (resposta.Equals("sim"))
                {
                    Console.WriteLine("Foi lançado no dia 7 de Setembro de 1971 – Primeiro voo do Xavante");
                }
               else
                {
                    Console.WriteLine("Ok. Legal :)");
                }
            Console.WriteLine("Deseja saber quantos anos fazem desde o lançamento do primeiro avião até o ano de lançamento do último avião?");
            continuar = Console.ReadLine();
            if (continuar.Equals("sim"))
            {
                Console.WriteLine("Projetado para ser lançado originalmente em 2020, o E175-E2 é o terceiro e último modelo previsto na nova família E-Jets 2 de jatos regionais da Embraer.");
                Console.WriteLine("Portanto, fazem " + subtracao + " anos de diferença entre os dois lançamentos ;) ");
            }
            else
            {
                Console.WriteLine("Poxa! Mas que chato, hein!");
            }
            
        }

    }
}

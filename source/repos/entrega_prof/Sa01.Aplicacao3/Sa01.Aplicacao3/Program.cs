using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int avioes;
            int assentos = 17;
            int total;
            string resposta;

            Console.WriteLine("Digite a quantidade de aviões da frota:");
            avioes = Int32.Parse(Console.ReadLine());
            total = avioes * assentos;

            Console.WriteLine("Deseja saber quantos assentos temos em nossa frota de aviões? Responda com 'sim' ou 'nao'");
            resposta = Console.ReadLine();

            if (resposta.Equals("sim"))
            {
                Console.WriteLine("O total disponível é de " + total + " assentos.");
            }
            else
            {
                Console.WriteLine("Ok ;)");
            }
        }
    }
}

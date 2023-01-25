using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 5000;
            int clientes = 10;
            int premio = valor / clientes;
            string senha = "senai";
            string confirmacao;

            Console.WriteLine("Digite a palavra passe para confirmar que você é um(a) cliente especial: ");
            confirmacao = Console.ReadLine();

            if (confirmacao == senha)
            {
                Console.WriteLine("Parabéns! Você foi premiado(a) com o valor de " + premio + " reais!");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }

        }
    }
}

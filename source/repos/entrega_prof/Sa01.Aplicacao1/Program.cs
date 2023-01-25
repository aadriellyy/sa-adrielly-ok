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
            Console.WriteLine("Você sabe em que ano foi criado o primeiro avião? Responda com 'sim' ou 'não' ");
            resposta = Console.ReadLine();
            if(resposta.Equals("sim"))
                {
                Console.WriteLine("O primeiro avião foi criado no dia 23 de outubro de 1906. Há quem diga que foram os irmãos Wright que inventaram o avião, mas catapulta não é motor ;)");
                }
            else
                {
                    Console.WriteLine("Ok. Legal :)");
                }

        }
        
    }
}

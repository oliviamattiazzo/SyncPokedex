using LeitorArquivoPokedex.Controllers;
using System;
using System.Linq;

namespace LeitorArquivoPokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args.Any())
            {
                Console.WriteLine("Para a execução, é necessário enviar o nome do arquivo de entrada.");
                return;
            }

            string nomeArquivoEntrada = args[0];

            Console.WriteLine("Sincronizando Pokédex...");

            ArquivoController arquivo = new ArquivoController(nomeArquivoEntrada);
            arquivo.ProcessaArquivo();

            Console.WriteLine("Pokédex sincronizado com sucesso!");

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}

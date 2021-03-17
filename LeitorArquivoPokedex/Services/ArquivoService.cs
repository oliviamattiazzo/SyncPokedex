using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using LeitorArquivoPokedex.Models;

namespace LeitorArquivoPokedex.Services
{
    public class ArquivoService
    {
        private string NomeArquivoInput;
        private TextReader ConteudoArquivo;

        public ArquivoService(string nomeArquivoInput)
        {
            NomeArquivoInput = nomeArquivoInput;
            ConteudoArquivo = Console.In;
        }

        public IList<LinhaArquivo> CarregaLinhasArquivo()
        {
            List<LinhaArquivo> lstLinhasArquivo = new List<LinhaArquivo>();

            ConteudoArquivo = AbreArquivo();

            lstLinhasArquivo.AddRange(PercorreLinhasArquivo());

            return lstLinhasArquivo;
        }

        private TextReader AbreArquivo()
        {
            string caminhoArquivosInput = ConfigurationManager.AppSettings["CaminhoArquivosInput"];
            return File.OpenText(string.Concat(caminhoArquivosInput, NomeArquivoInput));
        }

        private IList<LinhaArquivo> PercorreLinhasArquivo()
        {
            List<LinhaArquivo> lstLinhasArquivo = new List<LinhaArquivo>();

            try
            {
                string linha = string.Empty;
                while ((linha = ConteudoArquivo.ReadLine()) != null)
                {
                    string[] valoresLinhaArquivo = linha.Split(';');
                    lstLinhasArquivo.Add(new LinhaArquivo
                    {
                        IdPokemon = int.Parse(valoresLinhaArquivo[0]),
                        QtdeNovasAparicoes = int.Parse(valoresLinhaArquivo[1]),
                        IdMove = int.Parse(valoresLinhaArquivo[2]),
                        IdTipo = int.Parse(valoresLinhaArquivo[3])
                    });
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Uma das linhas contém valores alfanuméricos e isso não é permitido!");
            }

            return lstLinhasArquivo;
        }
    }
}

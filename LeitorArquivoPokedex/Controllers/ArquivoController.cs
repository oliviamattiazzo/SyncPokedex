using LeitorArquivoPokedex.Models;
using LeitorArquivoPokedex.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeitorArquivoPokedex.Controllers
{
    public class ArquivoController
    {
        private string NomeArquivoInput;

        public ArquivoController(string nomeArquivoInput)
        {
            NomeArquivoInput = nomeArquivoInput;
        }

        public void ProcessaArquivo()
        {
            IList<LinhaArquivo> lstLinhasArquivo = new List<LinhaArquivo>();
            ArquivoService servicoArquivo = new ArquivoService(NomeArquivoInput);
            RegistrosService servicoRegistros = null;

            lstLinhasArquivo = servicoArquivo.CarregaLinhasArquivo();

            servicoRegistros = new RegistrosService(lstLinhasArquivo);
            servicoRegistros.ProcessaRegistros();
        }
    }
}

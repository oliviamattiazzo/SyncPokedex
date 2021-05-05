using System;
using System.Collections.Generic;
using System.Text;

namespace LeitorArquivoPokedex.Models
{
    public class LinhaArquivo : DecisionMaker.Interfaces.IInfoPokemon
    {
        public int IdPokemon { get; set; }

        public int QtdeAparicoes { get; set; }

        public int IdMove { get; set; }

        public int IdTipo { get; set; }
    }
}

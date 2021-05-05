using DecisionMaker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMaker.Models
{
    public class InfoPokemon : IInfoPokemon
    {
        public int IdPokemon { get; set; }

        public int QtdeAparicoes { get; set; }

        public int IdMove { get; set; }

        public int IdTipo { get; set; }

        public bool HaAparicoes()
        {
            return QtdeAparicoes > 0;
        }

        public bool IsMovePreenchido()
        {
            return IdMove > 0;
        }

        public bool IsTipoPreenchido()
        {
            return IdTipo > 0;
        }

        public bool IsNovoPokemon()
        {
            return QtdeAparicoes == 1;
        }

        public bool IsNovasAparicoes()
        {
            return QtdeAparicoes > 1;
        }
    }
}

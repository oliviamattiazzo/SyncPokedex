using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMaker.Interfaces
{
    public interface IInfoPokemon
    {
        int IdPokemon { get; set; }

        int QtdeAparicoes { get; set; }

        int IdMove { get; set; }

        int IdTipo { get; set; }
    }
}

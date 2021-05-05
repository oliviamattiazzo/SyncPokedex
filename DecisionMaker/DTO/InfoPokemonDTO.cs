using DecisionMaker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMaker.DTO
{
    public class InfoPokemonDTO
    {
        public IList<IInfoPokemon> InformacoesPokemons { get; set; }

        public InfoPokemonDTO()
        {
            InformacoesPokemons = new List<IInfoPokemon>();
        }
    }
}

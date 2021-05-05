using DecisionMaker;
using LeitorArquivoPokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeitorArquivoPokedex.Services
{
    public class RegistrosService
    {
        private List<LinhaArquivo> Registros;

        public RegistrosService(IList<LinhaArquivo> listaRegistros)
        {
            Registros = listaRegistros.ToList();
        }

        public void ProcessaRegistros()
        {
            DecisionMaker.DecisionMaker decisionMaker = new DecisionMaker.DecisionMaker();
            bool isUltimoRegistro = false;
            for (int counter = 0; counter < Registros.Count; counter++)
            {
                LinhaArquivo registro = Registros[counter];
                isUltimoRegistro = counter + 1 == Registros.Count;

                DecisionMaker.DTO.InfoPokemonDTO dto = new DecisionMaker.DTO.InfoPokemonDTO();
                dto.InformacoesPokemons.Add(registro);

                if (!isUltimoRegistro && registro.IdPokemon == Registros[counter + 1].IdPokemon)
                    dto.InformacoesPokemons.Add(Registros[counter + 1]);

                decisionMaker.DecideOperacaoPokedex(dto);
            }
        }
    }
}

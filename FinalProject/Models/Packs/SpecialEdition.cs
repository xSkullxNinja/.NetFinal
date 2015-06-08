using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models.Packs
{
    public class SpecialEdition
    {
        #region Properties
        #endregion
        public PokemonCard Pokemon { get; set; }
        public CardPack[] Packs { get; set; }

        public SpecialEdition(PokemonCard pokemon, CardPack[] packs)
        {
            Pokemon = pokemon;
            Packs = packs;
        }
    }
}
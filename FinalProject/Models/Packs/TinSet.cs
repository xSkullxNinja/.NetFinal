using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models.Cards
{
    public class TinSet
    {
        #region Properties
        public PokemonCard Pokemon { get; set; }
        public CardPack[] Packs { get; set; }
        #endregion
    }
}
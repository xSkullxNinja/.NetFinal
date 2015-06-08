using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models.Packs
{
    public class Collection
    {
        #region Properties
        public PokemonCard Pokemon { get; set; }
        public CardPack[] Packs { get; set; }
        #endregion
    }
}
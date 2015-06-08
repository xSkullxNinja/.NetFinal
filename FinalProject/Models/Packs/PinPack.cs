using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models.Packs
{
    public class PinPack
    {
        #region Properties
        public CardPack[] Packs { get; set; }
        public PokemonCard Pin { get; set; }
        #endregion
    }
}
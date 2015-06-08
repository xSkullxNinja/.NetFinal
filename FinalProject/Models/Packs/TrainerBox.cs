using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models.Packs
{
    public class TrainerBox
    {
        #region Properties
        public CardPack[] Packs { get; set; }
        public PokemonCard[] Energies { get; set; }
        #endregion
    }
}
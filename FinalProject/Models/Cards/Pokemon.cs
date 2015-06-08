using FinalProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Pokemon : PokemonCard
    {
        #region Properties
        public pokemonType Type { get; set; }
        public int HP { get; set; }
        public Ability PokemonAbility { get; set; }
        public Attack[] Attacks { get; set; }
        #endregion
    }
}
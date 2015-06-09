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

        public string AbilityName { get; set; }
        public string AbilityDescription { get; set; }

        public string Attack1Name { get; set; }
        public string Attack1Description { get; set; }
        public int Attack1EnergyCost { get; set; }
        public pokemonType[] Attack1EnergyTypes { get; set; }
        public int Attack1Damage { get; set; }
        
        public string Attack2Name { get; set; }
        public string Attack2Description { get; set; }
        public int Attack2EnergyCost { get; set; }
        public pokemonType[] Attack2EnergyTypes { get; set; }
        public int Attack2Damage { get; set; }
        
        public string Attack3Name { get; set; }
        public string Attack3Description { get; set; }
        public int Attack3EnergyCost { get; set; }
        public pokemonType[] Attack3EnergyTypes { get; set; }
        public int Attack3Damage { get; set; }
        #endregion
    }
}
using FinalProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Attack
    {
        #region Properties
        public string AttackName { get; set; }
        public string AttackDescription { get; set; }
        public int EnergyCost { get; set; }
        public pokemonType[] EnergyTypes { get; set; }
        public int AttackDamage { get; set; }
        #endregion
    }
}
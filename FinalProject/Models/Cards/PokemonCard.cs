using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class PokemonCard
    {
        #region Properties
        public string Image { get; set; }
        public string CardName { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        #endregion
    }
}
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.ViewModel
{
    public class CardViewModel
    {
        public List<Pokemon> pokemon { get; set; }
        public List<Energy> energy { get; set; }
        public List<Trainer> trainer { get; set; }
    }
}
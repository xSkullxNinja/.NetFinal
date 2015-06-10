using FinalProject.Models;
using FinalProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Catalog()
        {
            CardViewModel CardModel = new CardViewModel();
            List<Pokemon> pokemon = new List<Pokemon>();
            pokemon.Add(new Pokemon
            {
                CardName = "Charizard",
                HP = 120,
                AbilityName = "Energy Burn",
                AbilityDescription = "As often as you like during you turn (before your attack). you may turn all Energies attached to Charizard into " +
                        "fire Energy for the rest of the turn. This power can't be used if Charizard is Asleep, Confused, or Paralyzed.",
                Type = Enums.pokemonType.FIRE,
                Attack1Name = "Fire Spin", 
                Attack1EnergyCost = 4, 
                Attack1EnergyTypes = new Enums.pokemonType[4] { Enums.pokemonType.FIRE, Enums.pokemonType.FIRE, Enums.pokemonType.FIRE, Enums.pokemonType.FIRE }, 
                Attack1Description = "Discard 2 Energy cards attached to Charizard in order to use this attack.", 
                Attack1Damage = 100,
                Description1 = "Rare card from the Base Pokemon Card Set.",
                Description2 = "The original Most Wanted Pokemon Card.",
                Description3 = "The Card that everyone wanted.",
                Image = "C:\\Users\\Trenton Arndt\\Downloads\\CharizardBaseSet.jpg",
                Price = Convert.ToDecimal(79.99)
            });
            CardModel.pokemon = pokemon;
            List<Trainer> trainer = new List<Trainer>();
            trainer.Add(new Trainer
            {
                CardName = "Bill",
                Description = "Draw 2 Cards.", 
                Description1 = "Easy way to get cards from your deck.", 
                Description2 = "Many trainer cards can be played in one turn.", 
                Description3 = "This card can get you needed cards that you would want.",
                Image = "C:\\Users\\Trenton Arndt\\Downloads\\bill.jpg",
                Price = Convert.ToDecimal(0.50)
            });
            CardModel.trainer = trainer;
            List<Energy> energy = new List<Energy>();
            energy.Add(new Energy
            {
                CardName = "Water Energy", 
                Type = Enums.pokemonType.WATER,
                Description1 = "A card that is needed for every Pokemon Card to attack.",
                Description2 = "Basic Water Card that can be used for many things.",
                Description3 = "Pokemon Energy Card",
                Image = "C:\\Users\\Trenton Arndt\\Downloads\\basicWater.jpg",
                Price = Convert.ToDecimal(0.50)
            });
            CardModel.energy = energy;
            return View(CardModel);
        }
        public ActionResult PokemonCard(Pokemon card)
        {
            return View(card);
        }
        public ActionResult TrainerCard(Trainer card)
        {
            return View(card);
        }
        public ActionResult EnergyCard(Energy card)
        {
            return View(card);
        }
    }
}
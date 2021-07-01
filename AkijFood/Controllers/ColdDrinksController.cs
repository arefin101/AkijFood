using AkijFood.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkijFood.Repositories;
using System.Net;

namespace AkijFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColdDrinksController : ControllerBase
    {
        ColdDrinkRepository coldDrinkRepository = new ColdDrinkRepository();

        [Route(""), HttpGet]
        public IActionResult GetAll()
        {
            var coldDrinks = coldDrinkRepository.GetAll();
            return Ok(coldDrinks);
        }

        [Route("API01"), HttpPost]
        public IActionResult InsertMojo()
        {
            tblColdDrink coldDrink = new tblColdDrink();
            coldDrink.strColdDrinksName = "Mojo";
            coldDrink.numQuantity = 575;
            coldDrink.numUnitPrice = 15;
            coldDrinkRepository.Insert(coldDrink);
            return Ok(coldDrink);
        }

        [Route("API02"), HttpPost]
        public IActionResult UpdateFrutika()
        {
            var coldDrink = coldDrinkRepository.GetById(2);
            coldDrink.numUnitPrice = 35;
            coldDrinkRepository.Update(coldDrink);
            return Ok(coldDrink);
        }

        [Route("API03"), HttpDelete]
        public IActionResult DeleteSpeed()
        {
            coldDrinkRepository.Delete(3);
            return NoContent();
        }

        [Route("API04"), HttpGet]
        public IActionResult RemainingProducts()
        {
            var coldDrinks = coldDrinkRepository.GetAll();
            return Ok(coldDrinks);
        }

        [Route("API05"), HttpDelete]
        public IActionResult DeleteQunatityLess500()
        {
            var coldDrinks = coldDrinkRepository.GetAll().Where(x=>x.numQuantity<500).ToList();

            foreach (var item in coldDrinks)
            {
                int id = item.intColdDrinksId;
                coldDrinkRepository.Delete(id);
            }

            return NoContent();
        }

        [Route("API06"), HttpGet]
        public IActionResult TotalPrice()
        {
            var coldDrinks = coldDrinkRepository.GetAll();
            float TotalPrice = 0;

            foreach (var item in coldDrinks)
            {
                TotalPrice+=item.numUnitPrice;
            }

            return Ok(TotalPrice);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecipSuggestor.Models;
using RecipSuggestor.ViewModel;

namespace RecipSuggestor.Controllers
{
    public class RDBController : Controller
    {
        private readonly RecipeDBEntities19 db = new RecipeDBEntities19();
        // GET: RDB
        public ActionResult Index()
        {
            var tables = new RecipesViewModel
            {
                Rrrr = db.RecipeTabs.ToList(),
                Iiii = db.IngredientTabs.ToList(),
                RIttt = db.RITabs.ToList()
            };
            return View(tables);
        }
    }
}
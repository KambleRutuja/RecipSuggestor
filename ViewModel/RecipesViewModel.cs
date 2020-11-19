using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RecipSuggestor.Models;

namespace RecipSuggestor.ViewModel
{
    public class RecipesViewModel
    {
        public IEnumerable<RecipeTab> Rrrr { get; set; }
        public IEnumerable<IngredientTab> Iiii { get; set; }
        public IEnumerable<RITab> RIttt { get; set; }
    }
}
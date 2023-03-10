using SimpleRecipes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Entities
{
    class Recipe : IRecipe
    {
        private IIngredient[] Ingredients;
        private IStep[] Steps;

        public Recipe() { }

        public Recipe(IIngredient[] ingredients, IStep[] steps)
        {
            Ingredients = ingredients;
            Steps = steps;
        }

        public IIngredient[] GetIngredients()
        {
            return Ingredients;
        }

        public IStep[] GetSteps()
        {
            return Steps;
        }

        public void SetIngredients(IIngredient[] ingredients)
        {
            Ingredients = ingredients;
        }

        public void SetSteps(IStep[] steps)
        {
            Steps = steps;
        }
    }
}

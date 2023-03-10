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
        private float RecipeScaleFactor;

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

        public float GetRecipeScaleFactor() { return RecipeScaleFactor; }

        public void SetIngredients(IIngredient[] ingredients)
        {
            Ingredients = ingredients;
        }

        public void SetSteps(IStep[] steps)
        {
            Steps = steps;
        }

        public void SetRecipeScaleFactor(float recipeScaleFactor)
        {
            RecipeScaleFactor = recipeScaleFactor;
        }
    }
}

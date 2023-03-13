using SimpleRecipes.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Entities
{
    class Recipe : IRecipe
    {
        private string Name;
        private Collection<IIngredient> Ingredients = new Collection<IIngredient>();
        private Collection<IStep> Steps = new Collection<IStep>();
        private float RecipeScaleFactor = 1.0f;

        public Recipe()
        { 
            Name = string.Empty;
        }

        public Recipe(string name, Collection<IIngredient> ingredients, Collection<IStep> steps)
        {
            Name = name;
            Ingredients = ingredients;
            Steps = steps;
        }

        public string GetName()
        {
            return Name;
        }

        public Collection<IIngredient> GetIngredients()
        {
            return Ingredients;
        }

        public Collection<IStep> GetSteps()
        {
            return Steps;
        }

        public float GetRecipeScaleFactor() { return RecipeScaleFactor; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetIngredients(Collection<IIngredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public void SetSteps(Collection<IStep> steps)
        {
            Steps = steps;
        }

        public void SetRecipeScaleFactor(float recipeScaleFactor)
        {
            RecipeScaleFactor = recipeScaleFactor;
        }
    }
}

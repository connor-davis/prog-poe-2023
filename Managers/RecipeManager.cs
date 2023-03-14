using SimpleRecipes.Entities;
using SimpleRecipes.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Managers
{
    class RecipeManager
    {
        public RecipeManager() { }

        private Collection<IRecipe> Recipes = new Collection<IRecipe>();

        public void AddRecipe(IRecipe recipe)
        {
            Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            Recipes.Remove(recipe);
        }

        public void ClearRecipes()
        { 
            Recipes.Clear();
        }

        public void SetRecipeScaleFactor(IRecipe recipe, float recipeScaleFactor)
        {
            foreach (IRecipe storedRecipe in Recipes)
            {
                int indexOfStoredRecipe = Recipes.IndexOf(storedRecipe);

                if (storedRecipe.Equals(recipe))
                {
                    recipe.SetRecipeScaleFactor(recipeScaleFactor);

                    Recipes[indexOfStoredRecipe] = recipe;

                    return;
                }
            }
        }

        public Collection<IRecipe> GetRecipes() {
            return Recipes;
        }

        public IRecipe GetRecipe(int index)
        {
            return Recipes[index];
        }
    }
}

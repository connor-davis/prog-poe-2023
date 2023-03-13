using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Interfaces
{
    interface IRecipe
    {
        string GetName();
        Collection<IIngredient> GetIngredients();
        Collection<IStep> GetSteps();
        float GetRecipeScaleFactor();

        void SetName(string name);
        void SetIngredients(Collection<IIngredient> ingredients);
        void SetSteps(Collection<IStep> steps);
        void SetRecipeScaleFactor(float recipeScaleFactor);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Interfaces
{
    interface IRecipe
    {
        IIngredient[] GetIngredients();
        IStep[] GetSteps();

        void SetIngredients(IIngredient[] ingredients);
        void SetSteps(IStep[] steps);
    }
}

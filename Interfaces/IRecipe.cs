using System.Collections.ObjectModel;

namespace SimpleRecipes.Interfaces
{
    public interface IRecipe
    {
        string GetName();
        Collection<IIngredient> GetIngredients();
        Collection<IStep> GetSteps();
        float GetRecipeScaleFactor();
        float GetTotalCalories();

        void SetName(string name);
        void SetIngredients(Collection<IIngredient> ingredients);
        void SetSteps(Collection<IStep> steps);
        void SetRecipeScaleFactor(float recipeScaleFactor);
    }
}

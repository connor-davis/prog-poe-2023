using SimpleRecipes.Interfaces;
using System.Collections.ObjectModel;

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

        public float GetTotalCalories()
        {
            float totalCalories = 0.0f;

            foreach (var Ingredient in GetIngredients())
            {
                totalCalories = totalCalories + (Ingredient.GetNumberOfCalories() * RecipeScaleFactor);
            }

            NotifyUser notifyUser = new(Console.WriteLine);

            if (totalCalories > 300f)
            {
                notifyUser("> This recipe's calories exceed 300 calories.\n");
            }

            return totalCalories;
        }

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

        /**
         * This method will be used as a Delegate to notify the user about things
         * happening or detected in the application.
         */
        public delegate void NotifyUser(string message);
    }
}

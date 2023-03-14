using SimpleRecipes.Interfaces;
using System.Collections.ObjectModel;

namespace SimpleRecipes.Entities
{
    public class Recipe : IRecipe
    {
        private string Name;
        private Collection<IIngredient> Ingredients = new();
        private Collection<IStep> Steps = new();
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
                totalCalories += (Ingredient.GetNumberOfCalories() * RecipeScaleFactor);
            }

            NotifyIfCaloriesExceed notifyUser = new(CheckCalories);
            notifyUser("> This recipe's calories exceed 300 calories.\n", totalCalories, 300f);

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
        public delegate void NotifyIfCaloriesExceed(string message, float numberOfCalories, float maxNumberOfCalories);

        /**
         * This method will check the number of calories against the maximum
         * number of calories allowed.
         */
        public static void CheckCalories(string message, float numberOfCalories, float maxNumberOfCalories)
        {
            if (numberOfCalories > maxNumberOfCalories)
            {
                Console.WriteLine(message);
            }
        }
    }
}

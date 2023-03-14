
using SimpleRecipes.Entities;
using SimpleRecipes.Interfaces;
using System.Collections.ObjectModel;

namespace SimpleRecipes.Gui
{
    class CreateRecipeScreen : ConsoleGui
    {
        public override void Show()
        {
            ShowApplicationName();

            /**
             * First we need to initialize all the objects of the recipe.
             * We can find the global memory recipe from the Program class.
             * 
             * First we initialize a new recipe.
             */
            Recipe newRecipe = new Recipe();

            DisplayHeader("Create Recipe");

            string recipeName = GetStringInput("What is the name of the new recipe?", false);

            DisplayLightHeader("Ingredients");

            int numberOfIngredients = GetIntInput("How many ingredients will this recipe consist of? [number]");

            /**
             * Second we can initialize a new IIngredients array using the
             * number of ingredients the user wants to add to the recipe.
             */
            Collection<IIngredient> ingredients = new Collection<IIngredient>();

            for (int i = 1; i < numberOfIngredients + 1; i++)
            {
                string ingredientName = GetStringInput("What is the name of ingredient " + i + "? [word]", false);
                int ingredientQuantity = GetIntInput("What is the quantity of ingredient " + i + "? [number]");
                string ingredientUnitOfMeasurement = GetStringInput("What is the unit of measurement of ingredient " + i + "? [word, e.g. ml]", true);
                float ingredientNumberOfCalories = GetFloatInput("How many calories are in this ingredient? [number]");
                string ingredientFoodGroup = GetStringInput("What is the food group of ingredient " + i + "? [word, e.g. vegetable]", false);

                /**
                 * We can now create a new ingredient with the information gathered
                 * from the user.
                 */
                ingredients.Add(new Ingredient(ingredientName, ingredientQuantity, ingredientUnitOfMeasurement, ingredientNumberOfCalories, ingredientFoodGroup));
            }

            DisplayLightHeader("Steps");

            int numberOfSteps = GetIntInput("How many steps will this recipe consist of? [number]");

            /**
             * Second we can initialize a new IIngredients array using the
             * number of ingredients the user wants to add to the recipe.
             */
            Collection<IStep> steps = new Collection<IStep>();

            for (int i = 1; i < numberOfSteps + 1; i++)
            {
                string stepDescription = GetStringInput("What is the description of step " + i, false);

                /**
                 * We can now create a new ingredient with the information gathered
                 * from the user.
                 */
                steps.Add(new Step(stepDescription));
            }

            // Set the name of the new recipe
            newRecipe
                .SetName(recipeName);
            // Set the ingredients of the new recipe
            newRecipe
                .SetIngredients(ingredients);
            // Set the steps of the new recipe
            newRecipe
                .SetSteps(steps);

            // Add the new recipe to the collection of recipes.
            Program
                .GetRecipeManager()
                .AddRecipe(newRecipe);
        }
    }
}

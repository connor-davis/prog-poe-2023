
using SimpleRecipes.Entities;
using SimpleRecipes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            DisplayHeader("Ingredients");

            int numberOfIngredients = GetIntInput("How many ingredients will this recipe consist of? [number]");

            /**
             * Second we can initialize a new IIngredients array using the
             * number of ingredients the user wants to add to the recipe.
             */
            IIngredient[] ingredients = new IIngredient[numberOfIngredients];

            for (int i = 1; i < numberOfIngredients + 1; i++)
            {
                string ingredientName = GetStringInput("What is the name of ingredient " + i + "? [word]", false);
                int ingredientQuantity = GetIntInput("What is the quantity of ingredient " + i + "? [number]");
                string ingredientUnitOfMeasurement = GetStringInput("What is the unit of measurement of ingredient " + i + "? [word, e.g. ml]", true);

                /**
                 * We can now create a new ingredient with the information gathered
                 * from the user.
                 */
                Ingredient newIngredient = new Ingredient(ingredientName, ingredientQuantity, ingredientUnitOfMeasurement);

                ingredients[i - 1] = newIngredient;
            }

            DisplayHeader("Steps");

            int numberOfSteps = GetIntInput("How many steps will this recipe consist of? [number]");

            /**
             * Second we can initialize a new IIngredients array using the
             * number of ingredients the user wants to add to the recipe.
             */
            IStep[] steps = new IStep[numberOfSteps];

            for (int i = 1; i < numberOfSteps + 1; i++)
            {
                string stepDescription = GetStringInput("What is the description of step " + i, false);

                /**
                 * We can now create a new ingredient with the information gathered
                 * from the user.
                 */
                Step newStep = new Step(stepDescription);

                steps[i - 1] = newStep;
            }

            newRecipe.SetIngredients(ingredients);
            newRecipe.SetSteps(steps);

            Program.SetRecipe(newRecipe);
        }
    }
}


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
        public CreateRecipeScreen() { }

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

            Console.Write("How many ingredients will this recipe consist of? [number]: ");

            int numberOfIngredients = Int32.Parse(Console.ReadLine());

            /**
             * Second we can initialize a new IIngredients array using the
             * number of ingredients the user wants to add to the recipe.
             */
            IIngredient[] ingredients = new IIngredient[numberOfIngredients];

            for (int i = 1; i < numberOfIngredients + 1; i++)
            {
                Console.Write("What is the name of ingredient " + i + "? [word]: ");

                string ingredientName = Console.ReadLine();

                Console.Write("What is the quantity of ingredient " + i + "? [number]: ");

                int ingredientQuantity = Int32.Parse(Console.ReadLine());

                Console.Write("What is the unit of measurement of ingredient " + i + "? [word, e.g. ml]: ");

                string ingredientUnitOfMeasurement = Console.ReadLine();

                /**
                 * We can now create a new ingredient with the information gathered
                 * from the user.
                 */
                Ingredient newIngredient = new Ingredient(ingredientName, ingredientQuantity, ingredientUnitOfMeasurement);

                ingredients[i - 1] = newIngredient;
            }

            DisplayHeader("Steps");

            Console.Write("How many steps will this recipe consist of? [number]: ");

            int numberOfSteps = Int32.Parse(Console.ReadLine());

            /**
             * Second we can initialize a new IIngredients array using the
             * number of ingredients the user wants to add to the recipe.
             */
            IStep[] steps = new IStep[numberOfSteps];

            for (int i = 1; i < numberOfSteps + 1; i++)
            {
                Console.Write("What is the description of step " + i + ": ");

                string stepDescription = Console.ReadLine();

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

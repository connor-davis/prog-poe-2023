using SimpleRecipes.Entities;
using SimpleRecipes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Gui
{
    class DisplayRecipeScreen : ConsoleGui
    {
        public DisplayRecipeScreen() { }

        public override void Show()
        {
            ShowApplicationName();

            /**
             * Here we retrieve the recipe from the Program class
             * that is stored in memory.
             */
            Recipe recipe = (Recipe) Program.GetRecipe();

            if (recipe == null)
            {
                Console.WriteLine("There is no stored recipe. Please create one.\n");
                Console.WriteLine("Press any key to go back to the main menu.");
                Console.ReadLine();

                return;
            }

            DisplayHeader("Ingredients");

            IIngredient[] ingredients = recipe.GetIngredients();

            for (var i = 1; i < ingredients.Length + 1; i++)
            {
                if (ingredients[i - 1].GetUnitOfMeasurement() != null && ingredients[i - 1].GetUnitOfMeasurement() != "")
                {
                    Console.WriteLine(i + ". " + ingredients[i - 1].GetQuantity() * recipe.GetRecipeScaleFactor() + " " + ingredients[i - 1].GetUnitOfMeasurement() + " of " + ingredients[i - 1].GetName());
                } else
                {
                    Console.WriteLine(i + ". " + ingredients[i - 1].GetQuantity() * recipe.GetRecipeScaleFactor() + " " + ingredients[i - 1].GetName());
                }
            }

            DisplayHeader("Steps");

            IStep[] steps = recipe.GetSteps();

            for (var i = 1; i < steps.Length + 1; i++)
            {
                Console.WriteLine(i + ". " + steps[i - 1].GetStepDescription());
            }

            Console.WriteLine("\nPress any key to exit to the main menu.");
            Console.ReadLine();
        }
    }
}

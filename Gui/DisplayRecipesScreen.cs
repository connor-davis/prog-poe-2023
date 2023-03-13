using SimpleRecipes.Entities;
using SimpleRecipes.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Gui
{
    class DisplayRecipesScreen : ConsoleGui
    {
        private int currentRecipe = 0;

        public override void Show()
        {
            ShowApplicationName();

            if (Program.GetRecipeManager().GetRecipes().Count <= 0)
            {
                Console.WriteLine("There are no stored recipes. Please create one.\n");
                Console.WriteLine("Press any key to go back to the main menu.");
                Console.ReadLine();

                return;
            }

            /**
             * Here we retrieve the recipe from the Program class
             * that is stored in memory.
             */
            IRecipe Recipe = Program.GetRecipeManager().GetRecipe(currentRecipe);

            DisplayHeader(Recipe.GetName());
            DisplayLightHeader("Ingredients");

            Collection<IIngredient> Ingredients = Recipe.GetIngredients();

            for (var i = 1; i < Ingredients.Count + 1; i++)
            {
                if (Ingredients[i - 1].GetUnitOfMeasurement() != null && Ingredients[i - 1].GetUnitOfMeasurement() != "")
                {
                    Console.WriteLine(i + ". " + Ingredients[i - 1].GetQuantity() * Recipe.GetRecipeScaleFactor() + " " + Ingredients[i - 1].GetUnitOfMeasurement() + " of " + Ingredients[i - 1].GetName());
                }
                else
                {
                    Console.WriteLine(i + ". " + Ingredients[i - 1].GetQuantity() * Recipe.GetRecipeScaleFactor() + " " + Ingredients[i - 1].GetName());
                }
            }

            DisplayLightHeader("Steps");

            Collection<IStep> Steps = Recipe.GetSteps();

            for (var i = 1; i < Steps.Count + 1; i++)
            {
                Console.WriteLine(i + ". " + Steps[i - 1].GetStepDescription());
            }

            Console.WriteLine("\n1. Previous recipe");
            Console.WriteLine("2. Next recipe");
            Console.WriteLine("3. View recipe");
            Console.WriteLine("4. Go back to main menu");
            Console.WriteLine();
            Console.Write("> ");

            try
            {
                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            if (currentRecipe != 0)
                            {
                                currentRecipe = currentRecipe - 1;
                            }

                            Clear();
                            Show();

                            break;
                        }
                    case 2:
                        {
                            if (currentRecipe != Program.GetRecipeManager().GetRecipes().Count - 1)
                            {
                                currentRecipe = currentRecipe + 1;
                            }

                            Clear();
                            Show();

                            break;
                        }
                    case 3:
                        {
                            DisplayRecipeScreen displayRecipeScreen = new();

                            displayRecipeScreen.SetRecipeIndex(currentRecipe);
                            displayRecipeScreen.Show();

                            Clear();
                            Show();

                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            Clear();
                            Show();

                            break;
                        }
                }
            } catch (Exception ex)
            {
                Clear();
                Show();
            }
        }
    }
}

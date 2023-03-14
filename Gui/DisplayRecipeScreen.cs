using SimpleRecipes.Interfaces;
using System.Collections.ObjectModel;

namespace SimpleRecipes.Gui
{
    class DisplayRecipeScreen : ConsoleGui
    {
        private IRecipe? Recipe = null;

        public IRecipe GetRecipe()
        {
            return Recipe;
        }

        public void SetRecipe(IRecipe recipe)
        {
            Recipe = recipe;
        }

        public override void Show()
        {
            ShowApplicationName();

            DisplayHeader(Recipe.GetName());

            DisplayLightHeader("Ingredients");

            Collection<IIngredient> Ingredients = Recipe.GetIngredients();

            for (var i = 1; i < Ingredients.Count + 1; i++)
            {
                if (Ingredients[i - 1].GetUnitOfMeasurement() != string.Empty)
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

            Console.WriteLine();
            Console.WriteLine("Total Calories: " + Recipe.GetTotalCalories());
            Console.WriteLine();

            Console.WriteLine("1. Change the stored recipe's scale factor.");
            Console.WriteLine("2. Reset the quantities of the stored recipe back to their initial values.");
            Console.WriteLine("3. Clear the stored recipe.");
            Console.WriteLine("4. Back to recipes list.");
            Console.WriteLine();
            Console.Write("> ");

            try
            {
                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            RecipeScaleFactorScreen scaleRecipeScreen = new();

                            scaleRecipeScreen.SetRecipe(Recipe);
                            Clear();
                            scaleRecipeScreen.Show();

                            Clear();
                            Show();

                            break;
                        }
                    case 2:
                        {
                            Program.GetRecipeManager().SetRecipeScaleFactor(Recipe, 1.0f);

                            Clear();
                            Show();

                            break;
                        }
                    case 3:
                        {
                            Program.GetRecipeManager().RemoveRecipe(Recipe);

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
            }
            catch (Exception ex)
            {
                Clear();
                Show();

                return;
            }
        }
    }
}

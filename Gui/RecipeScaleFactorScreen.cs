using SimpleRecipes.Entities;
using SimpleRecipes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Gui
{
    class RecipeScaleFactorScreen : ConsoleGui
    {
        private IRecipe Recipe;

        public IRecipe GetRecipe() { return Recipe; }
        public void SetRecipe(IRecipe recipe) { Recipe = recipe; }

        public override void Show()
        {
            ShowApplicationName();

            DisplayHeader("Change The Scale of " + Recipe.GetName() + " to?");

            Console.WriteLine();
            Console.WriteLine("1. 1/2 scale");
            Console.WriteLine("2. 2x scale");
            Console.WriteLine("3. 3x scale");
            Console.WriteLine("4. Back to recipe details");
            Console.WriteLine();
            Console.Write("> ");

            try
            {
                int choice = Int32.Parse(Console.ReadLine());
            
                switch (choice)
                {
                    case 1:
                        {
                            Program.GetRecipeManager().SetRecipeScaleFactor(Recipe, 0.5f);

                            break;
                        }
                    case 2:
                        {
                            Program.GetRecipeManager().SetRecipeScaleFactor(Recipe, 2.0f);

                            break;
                        }
                    case 3:
                        {
                            Program.GetRecipeManager().SetRecipeScaleFactor(Recipe, 3.0f);

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

                return;
            }
        }
    }
}

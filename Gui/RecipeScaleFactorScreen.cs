using SimpleRecipes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Gui
{
    class RecipeScaleFactorScreen : ConsoleGui
    {
        public override void Show()
        {
            ShowApplicationName();

            DisplayHeader("Choose the scale factor from the menu below.");

            Console.WriteLine("1. Scale by half");
            Console.WriteLine("2. Scale by double");
            Console.WriteLine("3. Scale by triple");
            Console.WriteLine("4. Back to main menu.");
            Console.WriteLine();
            Console.Write("> ");

            int choice = Int32.Parse(Console.ReadLine());
            Recipe storedRecipe = (Recipe) Program.GetRecipe();

            switch (choice)
            {
                case 1:
                    {
                        storedRecipe.SetRecipeScaleFactor(0.5f);
                        Program.SetRecipe(storedRecipe);
                        break;
                    }
                case 2:
                    {
                        storedRecipe.SetRecipeScaleFactor(2.0f);
                        Program.SetRecipe(storedRecipe);
                        break;
                    }
                case 3:
                    {
                        storedRecipe.SetRecipeScaleFactor(3.0f);
                        Program.SetRecipe(storedRecipe);
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
    }
}

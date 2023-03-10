using SimpleRecipes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Gui
{
    class MainScreen : ConsoleGui
    {
        public MainScreen() { }

        public override void Show()
        {
            ShowApplicationName(); // Method provided by the ConsoleGui class.

            Console.WriteLine("Welcome back Chef. What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Create a new recipe.");
            Console.WriteLine("2. Display the stored recipe.");
            Console.WriteLine("3. Change the stored recipe's scale factor.");
            Console.WriteLine("4. Reset the quantities of the stored recipe back to their initial values.");
            Console.WriteLine("5. Clear the stored recipe.");
            Console.WriteLine("6. Close the application.");
            Console.WriteLine();
            Console.Write("> ");

            int choice = Int32.Parse(Console.ReadLine()); // Read the users menu choice from the Console.

            switch (choice)
            {
                case 1:
                    {
                        CreateRecipeScreen createRecipeScreen = new();

                        Clear(); // Method provided by the ConsoleGui class.
                        createRecipeScreen.Show();

                        Clear();
                        Show();

                        break;
                    }
                case 2:
                    {
                        DisplayRecipeScreen displayRecipeScreen = new();

                        Clear();
                        displayRecipeScreen.Show();

                        Clear();
                        Show();

                        break;
                    }
                case 3:
                    {
                        RecipeScaleFactorScreen scaleRecipeScreen = new();

                        Clear();
                        scaleRecipeScreen.Show();

                        Clear();
                        Show();
                        
                        break;
                    }
                case 4:
                    {
                        Recipe storedRecipe = (Recipe) Program.GetRecipe();

                        storedRecipe.SetRecipeScaleFactor(1.0f);
                        Program.SetRecipe(storedRecipe);

                        Clear();
                        Show();

                        break;
                    }
                case 5:
                    {
                        Program.SetRecipe(null);

                        Clear();
                        Show();

                        break;
                    }
                case 6:
                    {
                        break;
                    }
                default:
                    {
                        Clear(); // Method provided by the ConsoleGui class.
                        Show();
                        break;
                    }
            }
        }
    }
}

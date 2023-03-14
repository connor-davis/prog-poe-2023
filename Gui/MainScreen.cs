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
        public override void Show()
        {
            ShowApplicationName(); // Method provided by the ConsoleGui class.

            Console.WriteLine("Welcome back Chef. What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Create a new recipe.");
            Console.WriteLine("2. Display the stored recipes.");
            Console.WriteLine("3. Clear the stored recipes.");
            Console.WriteLine("4. Close the application.");
            Console.WriteLine();
            Console.Write("> ");

            try
            {
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
                            DisplayRecipesScreen displayRecipesScreen = new();

                            Clear();
                            displayRecipesScreen.Show();

                            Clear();
                            Show();

                            break;
                        }
                    case 3:
                        {
                            Program.GetRecipeManager().ClearRecipes();

                            Clear();
                            Show();

                            break;
                        }
                    case 4:
                        {
                            Clear();
                            break;
                        }
                    default:
                        {
                            Clear(); // Method provided by the ConsoleGui class.
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

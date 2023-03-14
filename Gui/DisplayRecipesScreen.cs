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
        private int currentPage = 1;
        
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

            DisplayHeader("Recipes - 10 per page");

            /**
             * Here we retrieve the recipe from the Program class
             * that is stored in memory.
             */
            Collection<IRecipe> Recipes = Program.GetRecipeManager().GetRecipes();

            var numberOfPages = Math.Ceiling((decimal) Recipes.Count / 10);
            var numberOfRecipesMissingForLastPage = (numberOfPages * 10) - Recipes.Count;

            for (var i = 1; i < Recipes.Count + 1; i++)
            {
                if (i > (currentPage - 1) * 5 && i < (currentPage * 5) + 1)
                {
                    Console.WriteLine(i + ". " + Recipes[i - 1].GetName() + " [" + Recipes[i - 1].GetIngredients().Count + " Ingredients] [" + Recipes[i - 1].GetSteps().Count + " Steps]");
                }
            }

            if (currentPage == numberOfPages)
            {
                for (var i = 0; i < numberOfRecipesMissingForLastPage; i++)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("> Type the number of the recipe to view.");
            Console.WriteLine("> Type [next] to view the next page of recipes.");
            Console.WriteLine("> Type [previous] to view the previous page of recipes.");
            Console.WriteLine("> Type [back] to go back to the main menu.");
            Console.WriteLine();
            Console.Write("> ");

            string choice = Console.ReadLine();

            try
            {
                int recipeNumber = Int32.Parse(choice);
                IRecipe recipeFound = Recipes[recipeNumber - 1];

                if (recipeFound != null)
                {
                    DisplayRecipeScreen displayRecipeScreen = new();

                    displayRecipeScreen.SetRecipe(recipeFound);
                    Clear();
                    displayRecipeScreen.Show();

                    Clear();
                    Show();
                } else
                {
                    ClearLine();

                    Console.WriteLine("> Please enter the number of an existing recipe.");
                    Thread.Sleep(2000);

                    Clear();
                    Show();
                }
            } catch (Exception ex)
            {
                switch (choice)
                {
                    case "next":
                        {
                            if (currentPage < numberOfPages)
                            {
                                currentPage = currentPage + 1;

                                Clear();
                                Show();

                                break;
                            }
                            else
                            {
                                ClearLine();

                                Console.WriteLine("> There are no more pages.");
                                Thread.Sleep(2000);

                                Clear();
                                Show();

                                break;
                            }
                        }
                    case "previous":
                        {
                            if (currentPage > 1)
                            {
                                currentPage = currentPage - 1;

                                Clear();
                                Show();

                                break;
                            }
                            else
                            {
                                ClearLine();

                                Console.WriteLine("> You are already on the first page.");
                                Thread.Sleep(2000);

                                Clear();
                                Show();

                                break;
                            }
                        }
                    case "back":
                        Clear();
                        break;
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
}

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
        private IRecipe? Recipe = null;

        public DisplayRecipeScreen()
        {

        }

        public IRecipe GetRecipe() {
            return Recipe;
        }

        public void SetRecipe(IRecipe recipe) {
            Recipe = recipe;
        }

        public override void Show()
        {
            ShowApplicationName();

            DisplayHeader(Recipe.GetName());

            Console.WriteLine("1. Change the stored recipe's scale factor.");
            Console.WriteLine("2. Reset the quantities of the stored recipe back to their initial values.");
            Console.WriteLine("3. Clear the stored recipe.");
            Console.WriteLine("4. Back to recipes list.");
            Console.WriteLine();
            Console.Write("> ");

            try
            {
                int choice = Int32.Parse(Console.ReadLine());
            } catch (Exception ex)
            {
                Clear();
                Show();
            }
        }
    }
}

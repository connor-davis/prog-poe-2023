using SimpleRecipes.Gui;
using SimpleRecipes.Entities;
using SimpleRecipes.Interfaces;

namespace SimpleRecipes
{
    class Program
    {
        protected Program() { }

        private static IRecipe Recipe;

        /**
         * The Main method will execute all of the functions
         * required to run this application.
         */
        static void Main(string[] args)
        {
            MainScreen mainScreen = new();

            mainScreen.Show();
        }

        public static IRecipe GetRecipe() { return Recipe; }
        public static void SetRecipe(Recipe recipe)
        {
            Recipe = recipe;
        }
    }
}
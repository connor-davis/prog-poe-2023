using SimpleRecipes.Gui;
using SimpleRecipes.Managers;

namespace SimpleRecipes
{
    class Program
    {
        public static RecipeManager RecipeManager = new();

        public Program() { }

        /**
         * The Main method will execute all of the functions
         * required to run this application.
         */
        public static void Main()
        {
            MainScreen mainScreen = new();

            mainScreen.Show();
        }

        public static RecipeManager GetRecipeManager() { return RecipeManager; }
    }
}
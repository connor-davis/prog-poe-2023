using SimpleRecipes.Gui;
using SimpleRecipes.Managers;

namespace SimpleRecipes
{
    class Program
    {
        public static RecipeManager RecipeManager;

        protected Program() { }



        /**
         * The Main method will execute all of the functions
         * required to run this application.
         */
        static void Main(string[] args)
        {
            RecipeManager = new RecipeManager();

            MainScreen mainScreen = new();

            mainScreen.Show();
        }

        public static RecipeManager GetRecipeManager() { return RecipeManager; }
    }
}
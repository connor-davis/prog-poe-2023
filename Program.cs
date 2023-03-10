using SimpleRecipes.Gui;

namespace SimpleRecipes
{
    internal class Program
    {
        /**
         * The Main method will execute all of the functions
         * required to run this application.
         */
        static void Main(string[] args)
        {
            MainScreen mainScreen = new();

            mainScreen.Show();
        }
    }
}
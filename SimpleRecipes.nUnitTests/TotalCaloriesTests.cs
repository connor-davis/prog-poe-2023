using NUnit.Framework;
using SimpleRecipes.Entities;
using SimpleRecipes.Interfaces;
using System.Collections.ObjectModel;

namespace SimpleRecipes.nUnitTests
{
    public class TotalCaloriesTests
    {
        private readonly Recipe recipe = new();

        private readonly Collection<IIngredient> ingredients = new();
        private readonly Collection<IStep> steps = new();

        [SetUp]
        public void Setup()
        {
            ingredients.Add(new Ingredient("coffee", 1, "teaspoon", 0f, "None"));
            ingredients.Add(new Ingredient("sugar", 3, "teaspoons", 48f, "Sweets"));
            ingredients.Add(new Ingredient("milk", 50, "ml", 22f, "Dairy"));
            ingredients.Add(new Ingredient("boiled water", 200, "ml", 0f, "None"));

            steps.Add(new Step("Put one teaspoon of coffee in the coffee mug"));
            steps.Add(new Step("Put three teaspoons of sugar in the coffee mug"));
            steps.Add(new Step("Pour 50 ml of milk in the coffee mug and stir"));
            steps.Add(new Step("Boil water in a kettle"));
            steps.Add(new Step("Once the water is boiled pour it in the coffee mug and stir"));

            recipe.SetIngredients(ingredients);
            recipe.SetSteps(steps);
            recipe.SetName("Coffee");
            recipe.SetRecipeScaleFactor(1f);
        }

        [Test]
        public void GetTotalCalories_EqualTest()
        {
            Console.WriteLine("Total Calories: " + recipe.GetTotalCalories());
            Assert.That(recipe.GetTotalCalories(), Is.EqualTo(70f));
        }
    }
}
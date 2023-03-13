using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleRecipes.Interfaces;

namespace SimpleRecipes.Entities
{
    class Ingredient : IIngredient
    {
        private string Name;
        private int Quantity;
        private string UnitOfMeasurement;
        private float NumberOfCalories;
        private string FoodGroup;

        public Ingredient()
        {
            Name = string.Empty;
            Quantity = 0;
            UnitOfMeasurement = string.Empty;
            NumberOfCalories = 0f;
            FoodGroup = string.Empty;
        }

        public Ingredient(string name, int quantity, string unitOfMeasurement, float numberOfCalories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            UnitOfMeasurement = unitOfMeasurement;
            NumberOfCalories = numberOfCalories;
            FoodGroup = foodGroup;
        }

        public string GetName() {
            return Name;
        }
        public int GetQuantity() {
            return Quantity;
        }
        public string GetUnitOfMeasurement() {
            return UnitOfMeasurement;
        }
        public float GetNumberOfCalories()
        {
            return NumberOfCalories;
        }
        public string GetFoodGroup()
        {
            return FoodGroup;
        }

        public void SetName(string name) {
            Name = name;
        }
        public void SetQuantity(int quantity) {
            Quantity = quantity;
        }
        public void SetUnitOfMeasurement(string unitOfMeasurement) {
            UnitOfMeasurement = unitOfMeasurement;
        }
        public void SetNumberOfCalories(float numberOfCalories)
        {
            NumberOfCalories = numberOfCalories;
        }
        public void SetFoodGroup(string foodGroup) {
            FoodGroup = foodGroup;
        }
    }
}

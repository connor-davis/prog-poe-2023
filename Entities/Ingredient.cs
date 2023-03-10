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

        public Ingredient()
        {
        }

        public Ingredient(string name, int quantity, string unitOfMeasurement)
        {
            Name = name;
            Quantity = quantity;
            UnitOfMeasurement = unitOfMeasurement;
        }

        public string GetName() { return Name; }
        public int GetQuantity() { return Quantity; }
        public string GetUnitOfMeasurement() {  return UnitOfMeasurement; }

        public void SetName(string name) {  Name = name; }
        public void SetQuantity(int quantity) {  Quantity = quantity; }
        public void SetUnitOfMeasurement(string unitOfMeasurement) {  UnitOfMeasurement = unitOfMeasurement; }
    }
}

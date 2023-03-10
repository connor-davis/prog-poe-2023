using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Interfaces
{
    interface IIngredient
    {
        string GetName();
        int GetQuantity();
        string GetUnitOfMeasurement();

        void SetName(string name);
        void SetQuantity(int quantity);
        void SetUnitOfMeasurement(string unitOfMeasurement);
    }
}

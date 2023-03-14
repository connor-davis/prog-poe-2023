namespace SimpleRecipes.Interfaces
{
    interface IIngredient
    {
        string GetName();
        int GetQuantity();
        string GetUnitOfMeasurement();
        float GetNumberOfCalories();
        string GetFoodGroup();

        void SetName(string name);
        void SetQuantity(int quantity);
        void SetUnitOfMeasurement(string unitOfMeasurement);
        void SetNumberOfCalories(float numberOfCalories);
        void SetFoodGroup(string foodGroup);
    }
}

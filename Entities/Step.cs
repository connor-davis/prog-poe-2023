using SimpleRecipes.Interfaces;

namespace SimpleRecipes.Entities
{
    class Step : IStep
    {
        private string StepDescription;

        public Step() { }

        public Step(string stepDescription)
        {
            StepDescription = stepDescription;
        }

        public string GetStepDescription()
        {
            return StepDescription;
        }

        public void SetStepDescription(string stepDescription)
        {
            StepDescription = stepDescription;
        }
    }
}

using SimpleRecipes.Interfaces;

namespace SimpleRecipes.Entities
{
    public class Step : IStep
    {
        private string StepDescription;

        public Step() 
        {
            StepDescription = string.Empty;
        }

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

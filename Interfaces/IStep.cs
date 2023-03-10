using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Interfaces
{
    interface IStep
    {
        string GetStepDescription();
        void SetStepDescription(string stepDescription);
    }
}

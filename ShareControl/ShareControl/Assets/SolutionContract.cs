using System;
using System.Collections.Generic;
using System.Text;

namespace ShareControl.Assets
{
    public abstract class SolutionContract
    {
        public abstract string SolutionName { get; set; }

        public abstract void GenerateDefaultSolutionCatalog();
    }
}

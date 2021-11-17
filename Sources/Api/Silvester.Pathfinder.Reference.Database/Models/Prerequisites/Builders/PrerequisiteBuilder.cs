using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders
{
    public class PrerequisiteBuilder
    {
        private BasePrerequisite Prerequisite { get; }

        public PrerequisiteBuilder(BasePrerequisite effect)
        {
            Prerequisite = effect;
        }

        public BasePrerequisite Build()
        {
            return Prerequisite;
        }
    }
}

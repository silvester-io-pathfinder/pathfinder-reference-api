using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class FeatPrerequisite : Prerequisite
    {
        public Guid RequiredFeatId { get; set; }
        public Feat RequiredFeat { get; set; } = default!;
    }
}

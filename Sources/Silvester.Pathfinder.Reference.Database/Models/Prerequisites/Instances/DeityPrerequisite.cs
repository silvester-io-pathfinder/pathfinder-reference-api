using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class DeityPrerequisite : Prerequisite
    {
        public Guid RequiredDeityId { get; set; }
        public Deity RequiredDeity { get; set; } = default!;
    }
}

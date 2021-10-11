using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class AncestryPrerequisite : Prerequisite
    {
        public Guid RequiredAncestryId { get; set; }
        public Ancestry RequiredAncestry { get; set; } = default!;
    }
}

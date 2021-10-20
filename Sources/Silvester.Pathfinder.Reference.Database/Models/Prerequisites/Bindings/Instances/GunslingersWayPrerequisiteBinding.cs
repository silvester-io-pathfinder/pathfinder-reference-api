using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances
{
    public class GunslingersWayPrerequisiteBinding : BasePrerequisiteBinding
    {
        public Guid GunslingersWayId { get; set; }
        public GunslingersWay GunslingersWay { get; set; } = default!;
    }
}

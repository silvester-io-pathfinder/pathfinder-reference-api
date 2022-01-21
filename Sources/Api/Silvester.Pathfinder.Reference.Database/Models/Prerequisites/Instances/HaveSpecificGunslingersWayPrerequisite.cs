using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificGunslingersWayPrerequisite : BasePrerequisite
    {
        public Guid RequiredGunsinglersWayId { get; set; }
        public GunslingersWay RequiredGunsinglersWay { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificGunslingersWay(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredGunsinglersWayId)
        {
            return builder.Add(new HaveSpecificGunslingersWayPrerequisite { Id = id, RequiredGunsinglersWayId = requiredGunsinglersWayId });
        }
    }
}

using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class FollowSpecificPhilosophyPrerequisite : BasePrerequisite
    {
        public Guid RequiredPhilosophyId { get; set; }
        public Philosophy RequiredPhilosophy { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder FollowSpecificPhilosophy(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredPhilosophyId)
        {
            return builder.Add(new FollowSpecificPhilosophyPrerequisite { Id = id, RequiredPhilosophyId = requiredPhilosophyId });
        }
    }
}

using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class FollowAnyPhilosophyPrerequisite : BasePrerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder FollowAnyPhilosophy(this BooleanPrerequisiteBuilder builder, Guid id)
        {
            return builder.Add(new FollowAnyPhilosophyPrerequisite { Id = id });
        }
    }
}

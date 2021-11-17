using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificStatPrerequisite : BasePrerequisite
    {
        public int RequiredStatValue { get; set; }

        public Guid RequiredStatId { get; set; }
        public Stat RequiredStat { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificStat(this BooleanPrerequisiteBuilder builder, Guid id, int requiredStatValue, Guid requiredStatId)
        {
            return builder.Add(new HaveSpecificStatPrerequisite { Id = id, RequiredStatValue = requiredStatValue, RequiredStatId = requiredStatId });
        }
    }
}

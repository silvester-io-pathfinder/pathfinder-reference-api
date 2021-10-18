using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificStatPrerequisite : Prerequisite
    {
        public int RequiredStatValue { get; set; }

        public Guid RequiredStatId { get; set; }
        public Stat RequiredStat { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificStat(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, int requiredStatValue, Guid requiredStatId)
        {
            return builder.Add(bindingId, new HaveSpecificStatPrerequisite { Id = id, RequiredStatValue = requiredStatValue, RequiredStatId = requiredStatId });
        }
    }
}

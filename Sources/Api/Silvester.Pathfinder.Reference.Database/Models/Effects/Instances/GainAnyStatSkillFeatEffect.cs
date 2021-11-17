using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyStatSkillFeatEffect : BaseEffect
    {
        public Guid RequiredStatId { get; set; }
        public Stat RequiredStat { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyStatSkillFeat(this BooleanEffectBuilder builder, Guid id, Guid requiredStatId)
        {
            return builder.Add(new GainAnyStatSkillFeatEffect { Id = id, RequiredStatId = requiredStatId });
        }
    }
}

using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyDailyClassFeatEffect : BaseEffect
    {
        public int Level { get; set; }

        public Guid ClassId { get; set; }
        public Class Class { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyDailyClassFeat(this BooleanEffectBuilder builder, Guid id, Guid classId, int level)
        {
            return builder.Add(new GainAnyDailyClassFeatEffect { Id = id, ClassId = classId, Level = level});
        }
    }
}


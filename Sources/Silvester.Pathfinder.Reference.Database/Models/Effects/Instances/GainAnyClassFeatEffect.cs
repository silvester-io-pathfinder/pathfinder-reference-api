using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyClassFeatEffect : BaseEffect
    {
        public int Level { get; set; }

        public Guid ClassId { get; set; }
        public Class Class { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyClassFeat(this BooleanEffectBuilder builder, Guid id, Guid classId, int level)
        {
            return builder.Add(new GainAnyClassFeatEffect { Id = id, ClassId = classId, Level = level });
        }

        public static EffectBuilder GainAnyClassFeat(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, Guid classId, int level)
        {
            EffectBuilder effect = builder
                .GainAnyClassFeat(id, classId, level);

            if (level != 1)
            {
                effect.AddPrerequisites(prerequisiteId, prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(id, Comparator.GreaterThanOrEqualTo, requiredLevel: level);
                });
            }

            return effect;
        }
    }
}

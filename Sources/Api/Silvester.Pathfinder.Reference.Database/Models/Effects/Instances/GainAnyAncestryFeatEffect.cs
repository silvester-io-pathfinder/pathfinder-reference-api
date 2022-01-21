using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyAncestryFeatEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyAncestryFeat(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainAnyAncestryFeatEffect { Id = id });
        }

        public static EffectBuilder GainAnyAncestryFeat(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int requiredLevel)
        {
            EffectBuilder effect = builder.GainAnyAncestryFeat(id);
            effect.AddPrerequisites(prerequisiteId, prerequisites => 
            {
                prerequisites.HaveSpecificLevel(id, Comparator.GreaterThanOrEqualTo, requiredLevel);
            });
            return effect;
        }
    }
}

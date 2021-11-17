using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainChosenMethodologyStatSkillFeatEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainChosenMethodologyStatSkillFeat(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainChosenMethodologyStatSkillFeatEffect { Id = id });
        }
    }
}

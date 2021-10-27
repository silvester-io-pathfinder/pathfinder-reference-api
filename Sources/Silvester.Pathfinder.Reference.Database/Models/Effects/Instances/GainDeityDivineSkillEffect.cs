using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainDeityDivineSkillEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainDeityDivineSkill(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainDeityDivineSkillEffect { Id = id });
        }
    }
}

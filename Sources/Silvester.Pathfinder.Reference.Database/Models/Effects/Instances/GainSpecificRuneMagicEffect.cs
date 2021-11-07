using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificRuneMagicEffect : BaseEffect
    {
        public Guid RuneMagicId { get; set; }
        public RuneMagic RuneMagic { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificRuneMagic(this BooleanEffectBuilder builder, Guid id, Guid runeMagicId)
        {
            return builder.Add(new GainSpecificRuneMagicEffect { Id = id, RuneMagicId = runeMagicId });
        }
    }
}

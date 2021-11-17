using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainChosenMysteryDomainSpellEffect : BaseEffect
    {
        public int Level { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainChosenMysteryDomainSpell(this BooleanEffectBuilder builder, Guid id, int level)
        {
            return builder.Add(new GainChosenMysteryDomainSpellEffect { Id = id, Level = level});
        }
    }
}

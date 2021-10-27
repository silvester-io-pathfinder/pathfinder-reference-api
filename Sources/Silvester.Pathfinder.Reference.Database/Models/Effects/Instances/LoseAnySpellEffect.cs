using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class LoseAnySpellEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder LoseAnySpell(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int requiredLevel)
        {
            return builder.LoseAnySpell(id, prerequisiteId, Comparator.GreaterThanOrEqualTo, requiredLevel);
        }

        public static EffectBuilder LoseAnySpell(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, Comparator comparator, int requiredLevel)
        {
            EffectBuilder effect = builder.LoseAnySpell(id);
            effect.AddPrerequisites(prerequisiteId, prerequisites =>
            {
                prerequisites.HaveSpecificLevel(id, comparator, requiredLevel: 2);
            });

            return effect;
        }

        public static EffectBuilder LoseAnySpell(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new LoseAnySpellEffect { Id = id });
        }
    }
}

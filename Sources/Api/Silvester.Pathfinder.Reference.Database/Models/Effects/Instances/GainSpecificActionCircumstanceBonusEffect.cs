using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificActionCircumstanceBonusEffect : BaseEffect
    {
        public string? Addendum { get; set; }
        public int Bonus { get; set; }

        public Guid ActionId { get; set; }
        public Models.Entities.Action Action{ get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificActionCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid actionId, int bonus, string? addendum = null)
        {
            return builder.Add(new GainSpecificActionCircumstanceBonusEffect { Id = id, ActionId = actionId, Bonus = bonus, Addendum = addendum });
        }
    }
}

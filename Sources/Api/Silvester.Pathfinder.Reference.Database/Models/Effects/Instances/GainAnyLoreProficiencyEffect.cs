using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyLoreProficiencyEffect : BaseEffect
    {
        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyLoreProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, string? restrictions = null)
        {
            return builder.Add(new GainAnyLoreProficiencyEffect { Id = id, ProficiencyId = proficiencyId, Restrictions = restrictions });
        }
    }
}

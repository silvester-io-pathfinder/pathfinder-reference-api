using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificLoreCategoryProficiencyEffect : BaseEffect
    {
        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid LoreCategoryId { get; set; }
        public LoreCategory LoreCategory { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificLoreCategoryProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, Guid loreCategoryId, string? restrictions = null)
        {
            return builder.Add(new GainSpecificLoreCategoryProficiencyEffect { Id = id, ProficiencyId = proficiencyId, LoreCategoryId = loreCategoryId, Restrictions = restrictions });
        }
    }
}

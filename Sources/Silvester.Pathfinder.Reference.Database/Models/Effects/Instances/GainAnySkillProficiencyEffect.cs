using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnySkillProficiencyEffect : BaseEffect
    {
        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnySkillProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, string? restrictions = null)
        {
            return builder.Add(new GainAnySkillProficiencyEffect { Id = id, ProficiencyId = proficiencyId, Restrictions = restrictions });
        }
    }
}

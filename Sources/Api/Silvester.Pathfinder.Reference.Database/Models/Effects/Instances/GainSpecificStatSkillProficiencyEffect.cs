using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificStatSkillProficiencyEffect : BaseEffect
    {
        public Guid StatId { get; set; }
        public Stat Stat { get; set; } = default!;

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificStatSkillProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, Guid statId)
        {
            return builder.Add(new GainSpecificStatSkillProficiencyEffect { Id = id, ProficiencyId = proficiencyId,  StatId = statId });
        }
    }
}


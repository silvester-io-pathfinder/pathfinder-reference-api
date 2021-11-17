using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainChosenSkillProficiencyEffect : BaseEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainChosenSkillProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId)
        {
            return builder.Add(new GainChosenSkillProficiencyEffect { Id = id, ProficiencyId = proficiencyId});
        }
    }
}


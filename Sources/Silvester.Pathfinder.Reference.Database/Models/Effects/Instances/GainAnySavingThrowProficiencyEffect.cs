using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnySavingThrowProficiencyEffect : BaseEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnySavingThrowProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId)
        {
            return builder.Add(new GainAnySavingThrowProficiencyEffect { Id = id, ProficiencyId = proficiencyId });
        }
    }
}

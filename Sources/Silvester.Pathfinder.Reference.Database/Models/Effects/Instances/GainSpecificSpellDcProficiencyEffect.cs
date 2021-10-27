using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSpellDcProficiencyEffect : BaseEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSpellDcProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId)
        {
            return builder.Add(new GainSpecificSpellDcProficiencyEffect { Id = id, ProficiencyId = proficiencyId });
        }
    }
}

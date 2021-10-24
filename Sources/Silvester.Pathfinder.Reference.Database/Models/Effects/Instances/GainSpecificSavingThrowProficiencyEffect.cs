using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSavingThrowProficiencyEffect : BaseEffect
    {
        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSavingThrowProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, Guid savingThrowStatId)
        {
            return builder.Add(new GainSpecificSavingThrowProficiencyEffect { Id = id, ProficiencyId = proficiencyId, SavingThrowStatId = savingThrowStatId });
        }
    }
}

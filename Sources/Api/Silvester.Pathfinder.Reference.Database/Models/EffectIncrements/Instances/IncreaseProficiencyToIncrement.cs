using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances
{
    public class IncreaseProficiencyToIncrement : EffectIncrement
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class EffectIncrementsBuilderExtensions
    {
        public static EffectIncrementsBuilder IncreaseProficiencyTo(this EffectIncrementsBuilder builder, Guid id, Guid proficiencyId, EffectIncrementTrigger trigger)
        {
            return builder.Add(new IncreaseProficiencyToIncrement { Id = id, ProficiencyId = proficiencyId, Trigger = trigger });
        }
    }
}

using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificLoreProficiencyEffect : BaseEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid LoreId { get; set; }
        public Lore Lore { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificLoreProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, Guid loreId)
        {
            return builder.Add(new GainSpecificLoreProficiencyEffect { Id = id, ProficiencyId = proficiencyId, LoreId = loreId });
        }
    }
}

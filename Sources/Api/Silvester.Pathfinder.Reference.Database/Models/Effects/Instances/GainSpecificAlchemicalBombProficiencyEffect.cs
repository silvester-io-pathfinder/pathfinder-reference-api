using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificAlchemicalBombProficiencyEffect : BaseEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificAlchemicalBombProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId)
        {
            return builder.Add(new GainSpecificAlchemicalBombProficiencyEffect { Id = id, ProficiencyId = proficiencyId });
        }
    }
}

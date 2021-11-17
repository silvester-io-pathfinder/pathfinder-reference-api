using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSingularExpertiseEffect : BaseEffect
    {
        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;

        public Guid HighestProficiencyId { get; set; }
        public Proficiency HighestProficiency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSingularExpertise(this BooleanEffectBuilder builder, Guid id, Guid weaponGroupId, Guid highestProficiencyId)
        {
            return builder.Add(new GainSingularExpertiseEffect { Id = id, HighestProficiencyId = highestProficiencyId, WeaponGroupId = weaponGroupId });
        }
    }
}

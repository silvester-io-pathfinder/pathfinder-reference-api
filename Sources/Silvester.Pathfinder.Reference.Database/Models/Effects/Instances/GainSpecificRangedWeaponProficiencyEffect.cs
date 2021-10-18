using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificRangedWeaponProficiencyEffect : Effect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid RangedWeaponId { get; set; }
        public RangedWeapon RangedWeapon { get; set; } = default!;
    }
}

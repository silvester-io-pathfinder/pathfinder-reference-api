using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificMeleeWeaponProficiencyEffect : Effect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid MeleeWeaponId { get; set; }
        public MeleeWeapon MeleeWeapon { get; set; } = default!;
    }
}

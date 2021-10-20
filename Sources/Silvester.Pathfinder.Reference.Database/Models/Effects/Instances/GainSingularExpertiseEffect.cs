using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSingularExpertiseEffect : Effect
    {
        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;

        public Guid HighestProficiencyId { get; set; }
        public Proficiency HighestProficiency { get; set; } = default!;
    }
}

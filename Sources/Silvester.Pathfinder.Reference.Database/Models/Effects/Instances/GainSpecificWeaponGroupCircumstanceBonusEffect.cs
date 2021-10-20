using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificWeaponGroupCircumstanceBonusEffect : Effect
    {
        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;

        public int Bonus { get; set; }
        public RollType RollType { get; set; }
    }
}

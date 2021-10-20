using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificWeaponCategorySpecializationEffect : Effect
    {
        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }
}

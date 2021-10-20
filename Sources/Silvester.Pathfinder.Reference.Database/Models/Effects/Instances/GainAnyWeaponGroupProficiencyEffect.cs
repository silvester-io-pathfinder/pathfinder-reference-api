using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    /// <summary>
    /// Choose a weapon group. Your proficiency rank increases to the designated proficiency for the designated weapon category.
    /// </summary>
    public class GainAnyWeaponGroupProficiencyEffect : Effect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }
}

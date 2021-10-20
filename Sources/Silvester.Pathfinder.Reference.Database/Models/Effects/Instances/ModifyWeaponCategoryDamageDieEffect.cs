using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class ModifyWeaponCategoryDamageDieEffect : Effect
    {
        public int Modifier { get; set; }
        public ModifierType ModifierType { get; set; }

        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }
}

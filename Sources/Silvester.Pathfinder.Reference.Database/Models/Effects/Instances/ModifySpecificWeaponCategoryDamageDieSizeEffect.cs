using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifySpecificWeaponCategoryDamageDieSizeEffect : BaseEffect
    {
        public int Modifier { get; set; }
        public ModifierType ModifierType { get; set; }

        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifySpecificWeaponCategoryDamageDieSize(this BooleanEffectBuilder builder, Guid id, Guid weaponCategoryId, ModifierType modifierType, int modifier)
        {
            return builder.Add(new ModifySpecificWeaponCategoryDamageDieSizeEffect { Id = id, WeaponCategoryId = weaponCategoryId, ModifierType = modifierType, Modifier = modifier });
        }
    }
}

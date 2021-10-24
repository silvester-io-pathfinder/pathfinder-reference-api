using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances
{
    public class AddWeaponCategoryIncrement : EffectIncrement
    {
        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }

    public static partial class EffectIncrementsBuilderExtensions
    {
        public static EffectIncrementsBuilder AddWeaponCategory(this EffectIncrementsBuilder builder, Guid id, Guid weaponCategoryId, EffectIncrementTrigger trigger)
        {
            return builder.Add(new AddWeaponCategoryIncrement { Id = id, WeaponCategoryId = weaponCategoryId, Trigger = trigger });
        }
    }
}

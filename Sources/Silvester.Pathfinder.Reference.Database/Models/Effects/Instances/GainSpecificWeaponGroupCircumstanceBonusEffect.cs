using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificWeaponGroupCircumstanceBonusEffect : BaseEffect
    {
        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;

        public int Bonus { get; set; }
        public RollType RollType { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificWeaponGroupCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid weaponGroupId, int bonus, RollType rollType)
        {
            return builder.Add(new GainSpecificWeaponGroupCircumstanceBonusEffect { Id = id, WeaponGroupId = weaponGroupId, Bonus = bonus, RollType = RollType });
        }
    }
}

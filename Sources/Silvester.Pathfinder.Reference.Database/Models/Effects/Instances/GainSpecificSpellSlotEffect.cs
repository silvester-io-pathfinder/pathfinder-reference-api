using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{

    public class GainSpecificSpellSlotEffect : BaseEffect
    {
        public int Amount { get; set; }
        public int Level { get; set; }
        public bool IsSpendingPreventable { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSpellSlot(this BooleanEffectBuilder builder, Guid id, int amount, int spellSlotLevel, bool isSpendingPreventable)
        {
            return builder.Add(new GainSpecificSpellSlotEffect { Id = id, Amount = amount, Level = spellSlotLevel, IsSpendingPreventable = isSpendingPreventable });
        }

        public static EffectBuilder GainSpecificSpellSlot(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int requiredLevel, int spellSlotLevel, int amount, int increaseTo, int atLevel, bool isSpendingPreventable = true)
        {
            return builder.GainSpecificSpellSlot(id, amount, spellSlotLevel, isSpendingPreventable)
                .AddPrerequisites(prerequisiteId, prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(id, Comparator.GreaterThanOrEqualTo, requiredLevel);
                })
                .AddIncrements(increments =>
                {
                    increments.IncreaseAmountTo(id, amount: increaseTo, new LevelTrigger { Id = id, Level = atLevel });
                });
        }

        public static EffectBuilder GainSpecificSpellSlot(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int requiredLevel, int spellSlotLevel, int amount, bool isSpendingPreventable = true)
        {
            return builder.GainSpecificSpellSlot(id, Comparator.GreaterThanOrEqualTo, requiredLevel, spellSlotLevel, amount, isSpendingPreventable);
        }

        public static EffectBuilder GainSpecificSpellSlot(this BooleanEffectBuilder builder, Guid id, Comparator comparator, int requiredLevel, int spellSlotLevel, int amount, bool isSpendingPreventable = true)
        {
            return builder.GainSpecificSpellSlot(id, amount, spellSlotLevel, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(id, comparator, requiredLevel);
                });
        }
    }
}

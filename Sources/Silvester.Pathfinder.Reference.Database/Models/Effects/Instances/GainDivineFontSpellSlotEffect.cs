using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainDivineFontSpellSlotEffect : BaseEffect
    {
        public int Level { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainDivineFontSpellSlot(this BooleanEffectBuilder builder, Guid id, int spellSlotLevel)
        {
            return builder.Add(new GainDivineFontSpellSlotEffect { Id = id, Level = spellSlotLevel});
        }

        public static void GainDivineFontSpellSlot(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int spellSlotLevel, int exactRequiredLevel)
        {
            builder
                .GainDivineFontSpellSlot(id, spellSlotLevel)
                .AddPrerequisites(prerequisiteId, prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(id, Comparator.EqualTo, exactRequiredLevel);
                });
        }
    }
}

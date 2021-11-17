using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificRarityAnyLanguageEffect : BaseEffect
    {
        public Comparator Comparator { get; set; }

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificRarityAnyLanguage(this BooleanEffectBuilder builder, Guid id, Comparator comparator, Guid rarityId)
        {
            return builder.Add(new GainSpecificRarityAnyLanguageEffect { Id = id, Comparator = comparator, RarityId = rarityId });
        }
    }
}

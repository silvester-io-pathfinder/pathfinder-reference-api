using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificRarityHeritageEffect : BaseEffect
    {
        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificRarityHeritage(this BooleanEffectBuilder builder, Guid id, Guid rarityId)
        {
            return builder.Add(new GainSpecificRarityHeritageEffect { Id = id, RarityId = rarityId});
        }
    }
}

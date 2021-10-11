using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class HeritageRarityEffect : Effect
    {
        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;
    }
}

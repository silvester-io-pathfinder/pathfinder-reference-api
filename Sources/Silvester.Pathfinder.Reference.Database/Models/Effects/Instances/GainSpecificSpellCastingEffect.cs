using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificSpellCastingEffect : Effect
    {
        public Guid MagicTraditionId { get; set; }
        public MagicTradition MagicTradition { get; set; } = default!;
    }
}

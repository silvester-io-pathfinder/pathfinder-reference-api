using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class InnateSpellEffect : Effect
    {
        public int Level { get; set; }

        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;

        public Guid MagicTraditionId { get; set; }
        public MagicTradition MagicTradition { get; set; } = default!;
    }
}

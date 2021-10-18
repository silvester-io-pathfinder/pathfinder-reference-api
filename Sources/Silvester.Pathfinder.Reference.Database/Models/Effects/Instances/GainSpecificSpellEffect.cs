using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificSpellEffect : Effect
    {
        public string? Restrictions { get; set; }

        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;
    }
}

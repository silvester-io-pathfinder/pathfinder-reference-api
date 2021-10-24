using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSpellEffect : BaseEffect
    {
        public string? Restrictions { get; set; }

        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSpell(this BooleanEffectBuilder builder, Guid id, Guid spellId, string? restrictions = null)
        {
            return builder.Add(new GainSpecificSpellEffect { Id = id, SpellId = spellId, Restrictions = restrictions });
        }
    }
}

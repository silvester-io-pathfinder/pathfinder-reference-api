using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificInnateSpellEffect : BaseEffect
    {
        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;
        
        public Guid MagicTraditionId{ get; set; }
        public MagicTradition MagicTradition { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificInnateSpell(this BooleanEffectBuilder builder, Guid id, Guid spellId, Guid magicTraditionId)
        {
            return builder.Add(new GainSpecificInnateSpellEffect { Id = id, SpellId = spellId, MagicTraditionId = magicTraditionId });
        }
    }
}

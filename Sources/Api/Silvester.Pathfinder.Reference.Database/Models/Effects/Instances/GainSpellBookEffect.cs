using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpellBookEffect : BaseEffect
    {
        public int CantripAmount { get; set; }
        public int SpellAmount { get; set; }
        public int AddSpellsPerLevel { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpellBook(this BooleanEffectBuilder builder, Guid id, int cantripAmount, int spellAmount, int addSpellsPerLevel)
        {
            return builder.Add(new GainSpellBookEffect { Id = id, CantripAmount = cantripAmount, SpellAmount = spellAmount, AddSpellsPerLevel = addSpellsPerLevel});
        }
    }
}

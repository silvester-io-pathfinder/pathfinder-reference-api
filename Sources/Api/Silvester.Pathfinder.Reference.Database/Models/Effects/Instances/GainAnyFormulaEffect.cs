using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyFormulaEffect : BaseEffect
    {
        public int Level { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyFormula(this BooleanEffectBuilder builder, Guid id, int level)
        {
            return builder.Add(new GainAnyFormulaEffect { Id = id, Level = level});
        }
    }
}

using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyAlchemicalPoisonFormulaEffect : BaseEffect
    {
        public int Level { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyAlchemicalPoisonFormula(this BooleanEffectBuilder builder, Guid id, int level)
        {
            return builder.Add(new GainAnyAlchemicalPoisonFormulaEffect { Id = id, Level = level });
        }
    }
}

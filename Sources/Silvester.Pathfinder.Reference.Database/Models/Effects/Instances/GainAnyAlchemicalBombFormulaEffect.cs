using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyAlchemicalBombFormulaEffect : BaseEffect
    {
        public int Level { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyAlchemicalBombFormula(this BooleanEffectBuilder builder, Guid id, int level)
        {
            return builder.Add(new GainAnyAlchemicalBombFormulaEffect { Id = id, Level = level });
        }
    }
}

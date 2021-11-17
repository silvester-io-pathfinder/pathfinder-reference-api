using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificElixirFormulaEffect : BaseEffect
    {
        public Guid AlchemicalElixirId { get; set; }
        public AlchemicalElixir AlchemicalElixir { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificElixirFormula(this BooleanEffectBuilder builder, Guid id, Guid alchemicalElixirId, Guid potencyId)
        {
            return builder.Add(new GainSpecificElixirFormulaEffect { Id = id, AlchemicalElixirId = alchemicalElixirId, PotencyId = potencyId });
        }
    }
}

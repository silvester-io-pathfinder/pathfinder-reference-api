using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificElixirFormulaEffect : Effect
    {
        public Guid AlchemicalElixirId { get; set; }
        public AlchemicalElixir AlchemicalElixir { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;
    }
}

using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class DamageResistanceEffect : Effect
    {
        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;
    }
}

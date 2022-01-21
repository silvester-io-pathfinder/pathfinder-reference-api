using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects
{
    public class BooleanEffect : BaseEffect
    {
        public string? Addendum { get; set; }

        public BooleanOperator Operator { get; set; }

        public ICollection<BooleanEffectBinding> Entries { get; set; } = new List<BooleanEffectBinding>();
    }

    public class BooleanEffectBinding : BaseEntity
    {
        public Guid BooleanEffectId { get; set; }
        public BooleanEffect BooleanEffect { get; set; } = default!;

        public Guid EffectId { get; set; }
        public BaseEffect Effect { get; set; } = default!;
    }
}

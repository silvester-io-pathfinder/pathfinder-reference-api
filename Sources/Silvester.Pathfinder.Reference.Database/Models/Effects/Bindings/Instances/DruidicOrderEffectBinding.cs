using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class DruidicOrderEffectBinding : BaseEffectBinding
    {
        public Guid DruidicOrderId { get; set; }
        public DruidicOrder DruidicOrder { get; set; } = default!;
    }
}

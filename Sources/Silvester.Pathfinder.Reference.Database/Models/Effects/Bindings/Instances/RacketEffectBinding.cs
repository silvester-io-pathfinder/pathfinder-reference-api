using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class RacketEffectBinding : BaseEffectBinding
    {
        public Guid RacketId { get; set; }
        public Racket Racket { get; set; } = default!;
    }
}

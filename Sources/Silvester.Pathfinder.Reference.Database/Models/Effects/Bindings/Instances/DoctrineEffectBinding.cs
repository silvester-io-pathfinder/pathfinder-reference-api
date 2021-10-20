using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class DoctrineEffectBinding : BaseEffectBinding
    {
        public Guid DoctrineId { get; set; }
        public Doctrine Doctrine { get; set; } = default!;
    }
}

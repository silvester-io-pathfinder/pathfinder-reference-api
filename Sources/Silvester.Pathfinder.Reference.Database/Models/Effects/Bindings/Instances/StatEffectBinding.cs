using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class StatEffectBinding : BaseEntity
    {
        public Guid EffectId { get; set; }
        public Effect Effect { get; set; } = default!;
        
        public Guid StatId { get; set; }
        public Stat Stat { get; set; } = default!;
    }
}

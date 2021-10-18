using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class CauseEffectBinding : BaseEffectBinding
    {
        public Guid CauseId { get; set; }
        public Cause Cause { get; set; } = default!;
    }
}

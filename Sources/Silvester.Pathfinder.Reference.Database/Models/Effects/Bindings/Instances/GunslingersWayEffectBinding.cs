using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class GunslingersWayEffectBinding : BaseEffectBinding
    {
        public Guid GunslingersWayId { get; set; }
        public GunslingersWay GunslingersWay { get; set; } = default!;
    }
}

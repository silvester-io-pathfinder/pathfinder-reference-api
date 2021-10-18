using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class MuseEffectBinding : BaseEffectBinding
    {
        public Guid MuseId { get; set; }
        public Muse Muse { get; set; } = default!;
    }
}

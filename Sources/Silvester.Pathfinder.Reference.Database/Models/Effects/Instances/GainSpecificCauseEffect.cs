using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificCauseEffect : Effect
    {
        public Guid CauseId { get; set; }
        public Cause Cause { get; set; } = default!;
    }
}

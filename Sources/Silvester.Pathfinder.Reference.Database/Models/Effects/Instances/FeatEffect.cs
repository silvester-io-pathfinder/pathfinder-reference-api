using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class FeatEffect : Effect
    {
        public string? Restrictions { get; set; }

        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;
    }
}

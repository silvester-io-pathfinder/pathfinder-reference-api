using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class DisableFeatPrerequisitesEffect : Effect
    {
        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;
    }
}


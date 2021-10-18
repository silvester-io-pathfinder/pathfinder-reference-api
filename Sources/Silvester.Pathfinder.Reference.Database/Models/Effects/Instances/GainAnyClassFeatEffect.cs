using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainAnyClassFeatEffect : Effect
    {
        public int Level { get; set; }

        public Guid ClassId { get; set; }
        public Class Class { get; set; } = default!;
    }
}

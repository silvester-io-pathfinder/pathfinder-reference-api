using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificKeyAbilityOptionEffect : Effect
    {
        public Guid StatId { get; set; }
        public Stat Stat { get; set; } = default!;
    }
}


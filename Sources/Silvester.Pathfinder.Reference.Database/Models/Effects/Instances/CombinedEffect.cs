using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class CombinedEffect : Effect
    {
        public string? Addendum { get; set; }

        public ICollection<Effect> Entries { get; set; } = new List<Effect>();
    }
}

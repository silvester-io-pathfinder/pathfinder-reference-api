using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class SenseEffect : Effect
    {
        public string? Range { get; set; }

        public Guid SenseId { get; set; }
        public Sense Sense { get; set; } = default!;
    }
}

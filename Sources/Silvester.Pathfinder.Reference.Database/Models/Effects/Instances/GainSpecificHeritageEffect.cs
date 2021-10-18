using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificHeritageEffect : Effect
    {
        public Guid HeritageId { get; set; }
        public Heritage Heritage { get; set; } = default!;
    }
}

using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class HeritageEffect : Effect
    {
        public Guid HeritageId { get; set; }
        public Heritage Heritage { get; set; } = default!;
    }
}

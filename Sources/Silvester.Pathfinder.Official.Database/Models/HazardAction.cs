using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardAction : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Trigger{ get; set; } = default!;

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid HazardId { get; set; }
        public Hazard Hazard { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        public ICollection<HazardActionEffect> Effects { get; set; } = new List<HazardActionEffect>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
    }
}

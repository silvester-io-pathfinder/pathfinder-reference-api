using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ICollection<Trait> Traits = new List<Trait>();
        public ICollection<HazardActionEffect> Effects = new List<HazardActionEffect>();
        public ICollection<HazardActionEffectBlock> EffectDetails { get; set; } = default!;
    }

    public class HazardActionEffectBlock : BaseEntity
    {
        public Guid HazardActionId { get; set; }
        public HazardAction HazardAction { get; set; } = default!;

        public string Text { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardReactionDetailBlock : BaseEntity
    {
        public Guid HazardReactionId { get; set; }
        public HazardReaction HazardReaction { get; set; } = default!;

        public string Text { get; set; } = default!;
    }
}

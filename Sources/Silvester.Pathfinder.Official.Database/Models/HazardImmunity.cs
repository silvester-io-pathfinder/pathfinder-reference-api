using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardImmunity : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid HazardId { get; set; }
        public Hazard Hazard { get; set; } = default!;
    }
}

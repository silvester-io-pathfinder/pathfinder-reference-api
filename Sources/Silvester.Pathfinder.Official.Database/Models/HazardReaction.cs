using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardReaction : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Trigger{ get; set; } = default!;

        public string Effect { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardType : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Hazard> Hazards { get; set; } = new List<Hazard>();
    }
}

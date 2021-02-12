using Silvester.Pathfinder.Official.Database;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class PlaneCategory : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Plane> Planes { get; set; } = new List<Plane>();
    }
}

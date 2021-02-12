using Silvester.Pathfinder.Official.Database;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class RaceSize : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int Space { get; set; }

        public int HeightReach { get; set; }

        public int BreadthReach { get; set; }

        public ICollection<Race> Races { get; set; } = new List<Race>();
    }
}

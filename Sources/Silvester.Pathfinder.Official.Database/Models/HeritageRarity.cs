using Silvester.Pathfinder.Official.Database;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HeritageRarity : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Heritage> Heritages { get; set; } = new List<Heritage>();
    }
}

using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Heritage : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid RarityId { get; set; }
        public HeritageRarity Rarity { get; set; } = default!;

        public ICollection<Race> Races { get; set; } = new List<Race>();
    }
}

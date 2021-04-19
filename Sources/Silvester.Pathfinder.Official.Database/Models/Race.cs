using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Race : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int BaseSpeed { get; set; }
        
        public int BaseHealth { get; set; }
        
        public Guid SizeId { get; set; }
        public RaceSize Size { get; set; } = default!;

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public ICollection<Language> Languages { get; set; } = new List<Language>();

        public ICollection<RaceTrait> RaceTraits { get; set; } = new List<RaceTrait>();

        public ICollection<Heritage> Heritages { get; set; } = new List<Heritage>();
    }
}

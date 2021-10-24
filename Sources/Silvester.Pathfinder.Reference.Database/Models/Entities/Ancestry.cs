using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Ancestry : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int BaseSpeed { get; set; }
        
        public int BaseHealth { get; set; }
        
        public Guid SizeId { get; set; }
        public AncestrySize Size { get; set; } = default!;

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public ICollection<Language> Languages { get; set; } = new List<Language>();

        public ICollection<Trait> AncestryTraits { get; set; } = new List<Trait>();

        public ICollection<Heritage> Heritages { get; set; } = new List<Heritage>();
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}

using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Language : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid TypeId { get; set; }

        public LanguageType Type { get; set; } = default!;

        public ICollection<Ancestry> Ancestries { get; set; } = new List<Ancestry>();

        public ICollection<Creature> Creatures { get; set; } = new List<Creature>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}

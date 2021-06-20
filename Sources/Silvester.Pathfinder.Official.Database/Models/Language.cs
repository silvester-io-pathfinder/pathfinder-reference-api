using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Language : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid TypeId { get; set; }

        public LanguageType Type { get; set; } = default!;

        public ICollection<Race> Races { get; set; } = new List<Race>();

        public ICollection<Creature> Creatures { get; set; } = new List<Creature>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}

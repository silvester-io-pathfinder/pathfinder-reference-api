using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Language : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid TypeId { get; set; }

        public LanguageType Type { get; set; } = default!;

        public ICollection<Creature> Creatures { get; set; } = new List<Creature>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}

using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

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

    public class LanguageSearchConfigurator : SearchableEntityConfigurator<Language>
    {
        public override Expression<Func<Language, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

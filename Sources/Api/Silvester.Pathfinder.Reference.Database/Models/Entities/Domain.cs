using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Domain : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();

        public ICollection<Mystery> Mysteries { get; set; } = new List<Mystery>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DomainSearchConfigurator : SearchableEntityConfigurator<Domain>
    {
        public override Expression<Func<Domain, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}

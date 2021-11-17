using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Microsoft.EntityFrameworkCore;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class DamageType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DamageTypeSearchConfigurator : SearchableEntityConfigurator<DamageType>
    {
        public override Expression<Func<DamageType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

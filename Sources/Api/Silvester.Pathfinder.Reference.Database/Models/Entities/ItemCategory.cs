using NpgsqlTypes;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ItemCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int PageNumber { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ItemCategorySearchConfigurator : SearchableEntityConfigurator<ItemCategory>
    {
        public override Expression<Func<ItemCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}

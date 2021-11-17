using NpgsqlTypes;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class LoreCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public virtual string Name { get; set; } = default!;
        public string Examples { get; set; } = default!;
        public string Description { get; set; } = default!;

        public Guid StatModifierId { get; set; }
        public Stat StatModifier { get; set; } = default!;
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class LoreCategorySearchConfigurator : SearchableEntityConfigurator<LoreCategory>
    {
        public override Expression<Func<LoreCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

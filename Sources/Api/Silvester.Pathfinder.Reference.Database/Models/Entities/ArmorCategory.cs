using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ArmorCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Armor> Armors { get; set; } = new List<Armor>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ArmorCategoryConfigurator : SearchableEntityConfigurator<ArmorCategory>
    {
        public override Expression<Func<ArmorCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

using NpgsqlTypes;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Microsoft.EntityFrameworkCore;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ConditionCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Condition> Conditions { get; set; } = new List<Condition>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ConditionCategorySearchConfigurator : SearchableEntityConfigurator<ConditionCategory>
    {
        public override Expression<Func<ConditionCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

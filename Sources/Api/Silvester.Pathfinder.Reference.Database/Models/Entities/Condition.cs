using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Microsoft.EntityFrameworkCore;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Condition : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid? SourcePageId { get; set; }
        public SourcePage? SourcePage { get; set; } = default!;

        public Guid? ConditionCategoryId { get; set; }
        public ConditionCategory? ConditionCategory { get; set; } = default!;

        public Guid? OverridesConditionId { get; set; }
        public Condition? OverridesCondition { get; set; }

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ConditionSearchConfigurator : SearchableEntityConfigurator<Condition>
    {
        public override Expression<Func<Condition, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

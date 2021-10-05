using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemGrades
{
    public class SearchConfigurator : SearchableEntityConfigurator<ItemGrade>
    {
        public override Expression<Func<ItemGrade, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

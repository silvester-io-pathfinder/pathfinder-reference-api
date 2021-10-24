using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes
{
    public class SearchConfigurator : SearchableEntityConfigurator<Class>
    {
        public override Expression<Func<Class, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description, e.WhileExploring };
        }
    }
}

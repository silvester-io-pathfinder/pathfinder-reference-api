using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds
{
    public class SearchConfigurator : SearchableEntityConfigurator<Background>
    {
        public override Expression<Func<Background, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

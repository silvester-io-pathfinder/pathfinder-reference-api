using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards
{
    public class SearchConfigurator : SearchableEntityConfigurator<HarrowCard>
    {
        public override Expression<Func<HarrowCard, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}

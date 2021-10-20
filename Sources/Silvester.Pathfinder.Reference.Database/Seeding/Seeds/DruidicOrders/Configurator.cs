using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DruidicOrders
{
    public class SearchConfigurator : SearchableEntityConfigurator<DruidicOrder>
    {
        public override Expression<Func<DruidicOrder, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description};
        }
    }
}

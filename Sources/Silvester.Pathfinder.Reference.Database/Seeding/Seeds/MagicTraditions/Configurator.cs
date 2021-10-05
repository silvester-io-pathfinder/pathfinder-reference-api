using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MagicTraditions
{
    public class SearchConfigurator : SearchableEntityConfigurator<MagicTradition>
    {
        public override Expression<Func<MagicTradition, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}

using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats
{
    public class SearchConfigurator : SearchableEntityConfigurator<Feat>
    {
        public override Expression<Func<Feat, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Special, e.Trigger };
        }
    }
}

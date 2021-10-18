using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DivineAllies
{
    public class SearchConfigurator : SearchableEntityConfigurator<DivineAlly>
    {
        public override Expression<Func<DivineAlly, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}

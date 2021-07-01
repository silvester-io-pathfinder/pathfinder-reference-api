using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves
{
    public class SearchConfigurator : SearchableEntityConfigurator<Stave>
    {
        public override Expression<Func<Stave, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage, e.CraftingRequirements, e.Activate };
        }
    }
}

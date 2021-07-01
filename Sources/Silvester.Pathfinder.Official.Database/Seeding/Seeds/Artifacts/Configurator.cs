using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts
{
    public class SearchConfigurator : SearchableEntityConfigurator<Artifact>
    {
        public override Expression<Func<Artifact, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage, e.Destruction };
        }
    }
}

using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts
{
    public class SearchConfigurator : SearchableEntityConfigurator<Artifact>
    {
        public override Expression<Func<Artifact, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage, e.Destruction };
        }
    }
}

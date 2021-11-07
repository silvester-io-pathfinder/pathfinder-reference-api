using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats
{
    public class SearchConfigurator : SearchableEntityConfigurator<Feat>
    {
        public override Expression<Func<Feat, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

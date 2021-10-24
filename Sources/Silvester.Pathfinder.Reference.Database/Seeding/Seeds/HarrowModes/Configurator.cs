using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowModes
{
    public class SearchConfigurator : SearchableEntityConfigurator<HarrowMode>
    {
        public override Expression<Func<HarrowMode, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name};
        }
    }
}

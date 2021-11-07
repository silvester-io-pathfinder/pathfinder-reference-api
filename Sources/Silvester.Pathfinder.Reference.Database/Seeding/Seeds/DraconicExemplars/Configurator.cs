using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DraconicExemplars
{
    public class SearchConfigurator : SearchableEntityConfigurator<DraconicExemplar>
    {
        public override Expression<Func<DraconicExemplar, object?>> GetSearchProperties()
        {
            return (e) => new { e.Dragon };
        }
    }
}

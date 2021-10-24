using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SpellTypes
{
    public class SearchConfigurator : SearchableEntityConfigurator<SpellType>
    {
        public override Expression<Func<SpellType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}

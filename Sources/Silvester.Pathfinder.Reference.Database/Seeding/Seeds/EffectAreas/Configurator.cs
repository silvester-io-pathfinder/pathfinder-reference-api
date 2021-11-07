using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.EffectAreas
{
    public class SearchConfigurator : SearchableEntityConfigurator<EffectArea>
    {
        public override Expression<Func<EffectArea, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

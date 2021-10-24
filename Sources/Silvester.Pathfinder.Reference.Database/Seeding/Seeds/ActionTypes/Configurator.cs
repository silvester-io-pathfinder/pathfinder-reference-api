using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes
{
    public class Configurator : SearchableEntityConfigurator<ActionType>
    {
        public override Expression<Func<ActionType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

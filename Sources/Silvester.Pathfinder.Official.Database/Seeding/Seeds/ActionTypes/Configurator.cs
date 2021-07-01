using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes
{
    public class Configurator : SearchableEntityConfigurator<ActionType>
    {
        public override Expression<Func<ActionType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

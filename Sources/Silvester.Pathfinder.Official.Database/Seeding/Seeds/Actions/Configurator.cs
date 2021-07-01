using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions
{
    public class Configurator : SearchableEntityConfigurator<Models.Action>
    {
        public override Expression<Func<Models.Action, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Requirements, e.Trigger};
        }
    }
}
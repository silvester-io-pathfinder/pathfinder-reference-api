using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions
{
    public class Configurator : SearchableEntityConfigurator<Models.Entities.Action>
    {
        public override Expression<Func<Models.Entities.Action, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Requirements, e.Trigger};
        }
    }
}
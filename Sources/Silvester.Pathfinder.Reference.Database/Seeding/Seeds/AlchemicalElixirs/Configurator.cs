using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs
{
    public class Configurator : SearchableEntityConfigurator<AlchemicalElixir>
    {
        public override Expression<Func<AlchemicalElixir, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage, e.Drawback, e.Benefit };
        }
    }
}

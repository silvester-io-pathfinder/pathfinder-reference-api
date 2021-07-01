using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools
{
    public class Configurator : SearchableEntityConfigurator<AlchemicalTool>
    {
        public override Expression<Func<AlchemicalTool, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.ActivationAddendum, e.Usage };
        }
    }
}

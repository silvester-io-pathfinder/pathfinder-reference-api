using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalTools
{
    public class Configurator : SearchableEntityConfigurator<AlchemicalTool>
    {
        public override Expression<Func<AlchemicalTool, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.ActivationAddendum, e.Usage };
        }
    }
}

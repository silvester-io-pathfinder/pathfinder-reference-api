using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs
{
    public class Configurator : SearchableEntityConfigurator<AlchemicalBomb>
    {
        public override Expression<Func<AlchemicalBomb, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage};
        }
    }
}

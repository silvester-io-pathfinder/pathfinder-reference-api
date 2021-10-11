using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears
{
    public class Configurator : SearchableEntityConfigurator<AdventuringGear>
    {
        public override Expression<Func<AdventuringGear, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

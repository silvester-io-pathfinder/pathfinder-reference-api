using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Ammunitions
{
    public class Configurator : SearchableEntityConfigurator<Ammunition>
    {
        public override Expression<Func<Ammunition, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description};
        }
    }
}

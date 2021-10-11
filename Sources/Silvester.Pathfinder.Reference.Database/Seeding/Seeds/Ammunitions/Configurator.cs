using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ammunitions
{
    public class Configurator : SearchableEntityConfigurator<Ammunition>
    {
        public override Expression<Func<Ammunition, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description};
        }
    }
}

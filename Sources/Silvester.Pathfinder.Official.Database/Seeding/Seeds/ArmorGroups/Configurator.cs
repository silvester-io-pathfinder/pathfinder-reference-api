using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups
{
    public class Configurator : SearchableEntityConfigurator<ArmorGroup>
    {
        public override Expression<Func<ArmorGroup, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.ArmorSpecializationEffect };
        }
    }
}

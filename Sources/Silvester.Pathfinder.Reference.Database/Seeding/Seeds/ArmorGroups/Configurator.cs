using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorGroups
{
    public class Configurator : SearchableEntityConfigurator<ArmorGroup>
    {
        public override Expression<Func<ArmorGroup, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.ArmorSpecializationEffect };
        }
    }
}

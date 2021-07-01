using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorCategories
{
    public class Configurator : SearchableEntityConfigurator<ArmorCategory>
    {
        public override Expression<Func<ArmorCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

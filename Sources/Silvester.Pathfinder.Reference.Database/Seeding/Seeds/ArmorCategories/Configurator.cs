using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorCategories
{
    public class Configurator : SearchableEntityConfigurator<ArmorCategory>
    {
        public override Expression<Func<ArmorCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalPoisons
{
    public class Configurator : SearchableEntityConfigurator<AlchemicalPoison>
    {
        public override Expression<Func<AlchemicalPoison, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage };
        }
    }
}

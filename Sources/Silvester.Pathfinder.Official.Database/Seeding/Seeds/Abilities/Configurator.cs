using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Abilities
{
    public class Configurator : SearchableEntityConfigurator<Ability>
    {
        public override Expression<Func<Ability, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities
{
    public class Configurator : SearchableEntityConfigurator<Ability>
    {
        public override Expression<Func<Ability, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
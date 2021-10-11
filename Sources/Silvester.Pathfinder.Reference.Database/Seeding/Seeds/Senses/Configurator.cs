using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses
{
    public class Configurator : SearchableEntityConfigurator<Sense>
    {
        public override Expression<Func<Sense, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments
{
    public class Configurator : SearchableEntityConfigurator<Alignment>
    {
        public override Expression<Func<Alignment, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description};
        }
    }
}

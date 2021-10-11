using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Alignments
{
    public class Configurator : SearchableEntityConfigurator<Alignment>
    {
        public override Expression<Func<Alignment, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description};
        }
    }
}

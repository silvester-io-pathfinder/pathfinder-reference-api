using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Doctrines
{
    public class Configurator : SearchableEntityConfigurator<Doctrine>
    {
        public override Expression<Func<Doctrine, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description};
        }
    }
}
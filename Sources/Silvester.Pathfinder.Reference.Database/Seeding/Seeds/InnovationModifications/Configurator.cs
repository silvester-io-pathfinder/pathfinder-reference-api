using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications
{
    public class SearchConfigurator : SearchableEntityConfigurator<InnovationModification>
    {
        public override Expression<Func<InnovationModification, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description};
        }
    }
}

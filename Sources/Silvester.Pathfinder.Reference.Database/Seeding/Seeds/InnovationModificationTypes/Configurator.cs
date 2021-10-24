using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModificationTypes
{
    public class SearchConfigurator : SearchableEntityConfigurator<InnovationModificationType>
    {
        public override Expression<Func<InnovationModificationType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name};
        }
    }
}

using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Eidolons
{
    public class SearchConfigurator : SearchableEntityConfigurator<Eidolon>
    {
        public override Expression<Func<Eidolon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }

    public class AbilitySearchConfigurator : SearchableEntityConfigurator<EidolonAbility>
    {
        public override Expression<Func<EidolonAbility, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }

    public class VariantSearchConfigurator : SearchableEntityConfigurator<EidolonVariant>
    {
        public override Expression<Func<EidolonVariant, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}

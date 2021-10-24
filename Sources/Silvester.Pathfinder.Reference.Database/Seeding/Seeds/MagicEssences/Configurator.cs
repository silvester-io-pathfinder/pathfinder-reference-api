using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MagicEssences
{
    public class SearchConfigurator : SearchableEntityConfigurator<MagicEssence>
    {
        public override Expression<Func<MagicEssence, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}

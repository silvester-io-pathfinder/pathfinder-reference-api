using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines
{
    public class SearchConfigurator : SearchableEntityConfigurator<Bloodline>
    {
        public override Expression<Func<Bloodline, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.BloodMagic };
        }
    }
}

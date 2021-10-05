using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MagicSchools
{
    public class SearchConfigurator : SearchableEntityConfigurator<MagicSchool>
    {
        public override Expression<Func<MagicSchool, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description, e.Abbreviation };
        }
    }
}

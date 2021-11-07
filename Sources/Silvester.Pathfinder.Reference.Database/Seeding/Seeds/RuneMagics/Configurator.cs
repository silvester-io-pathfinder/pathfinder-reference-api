using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RuneMagics
{
    public class SearchConfigurator : SearchableEntityConfigurator<RuneMagic>
    {
        public override Expression<Func<RuneMagic, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}

using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SwashbucklerStyles
{
    public class SearchConfigurator : SearchableEntityConfigurator<SwashbucklersStyle>
    {
        public override Expression<Func<SwashbucklersStyle, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}

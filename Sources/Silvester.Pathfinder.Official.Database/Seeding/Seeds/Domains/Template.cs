using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains
{
    public abstract class Template : EntityTemplate<Domain>
    {
        protected override Domain GetEntity(ModelBuilder builder)
        {
            Domain domain = GetDomain();
            return domain;
        }

        protected abstract Domain GetDomain();
    }
}

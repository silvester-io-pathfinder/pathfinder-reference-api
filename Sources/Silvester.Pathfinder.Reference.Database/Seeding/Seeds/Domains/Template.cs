using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains
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

using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources
{
    public abstract class Template : EntityTemplate<Source>
    {
        protected override Source GetEntity(ModelBuilder builder)
        {
            Source source = GetSource();
            return source;
        }

        protected abstract Source GetSource();
    }
}

using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources
{
    public abstract class AbstractSourceTemplate : EntityTemplate<Source>
    {
        protected override Source GetEntity(ModelBuilder builder)
        {
            Source source = GetSource();
            return source;
        }

        protected abstract Source GetSource();
    }
}

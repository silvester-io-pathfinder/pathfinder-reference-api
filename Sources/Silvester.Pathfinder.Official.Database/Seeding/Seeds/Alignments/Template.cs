using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments
{
    public abstract class Template : EntityTemplate<Alignment>
    {
        protected override Alignment GetEntity(ModelBuilder builder)
        {
            Alignment alignment = GetAlignment();
            return alignment;
        }

        protected abstract Alignment GetAlignment();
    }
}

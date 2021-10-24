using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Alignments
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

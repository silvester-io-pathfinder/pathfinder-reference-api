using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores
{
    public abstract class Template : EntityTemplate<Lore>
    {
        protected override Lore GetEntity(ModelBuilder builder)
        {
            Lore lore = GetLore();
            return lore;
        }

        protected abstract Lore GetLore();
    }
}

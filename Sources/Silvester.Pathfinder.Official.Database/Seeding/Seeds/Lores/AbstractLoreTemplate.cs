using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores
{
    public abstract class AbstractLoreTemplate : EntityTemplate<Lore>
    {
        protected override Lore GetEntity(ModelBuilder builder)
        {
            Lore lore = GetLore();
            return lore;
        }

        protected abstract Lore GetLore();
    }
}

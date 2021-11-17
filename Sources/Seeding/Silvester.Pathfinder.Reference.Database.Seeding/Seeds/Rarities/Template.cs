using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rarities
{
    public abstract class Template : EntityTemplate<Rarity>
    {
        protected override Rarity GetEntity(ISeedBuilder builder)
        {
            Rarity rarity = GetAncestryRarity();
            return rarity;
        }

        protected abstract Rarity GetAncestryRarity();
    }
}

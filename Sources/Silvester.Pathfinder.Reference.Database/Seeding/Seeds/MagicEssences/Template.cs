using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MagicEssences
{
    public abstract class Template : EntityTemplate<MagicEssence>
    {
        protected override MagicEssence GetEntity(ModelBuilder builder)
        {
            MagicEssence essence = GetMagicEssence();
            return essence;
        }

        protected abstract MagicEssence GetMagicEssence();
    }
}

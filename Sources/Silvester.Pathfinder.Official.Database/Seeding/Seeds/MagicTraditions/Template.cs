using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicTraditions
{
    public abstract class Template : EntityTemplate<MagicTradition>
    {
        protected override MagicTradition GetEntity(ModelBuilder builder)
        {
            MagicTradition tradition = GetMagicTradition();
            return tradition;
        }

        protected abstract MagicTradition GetMagicTradition();
    }
}

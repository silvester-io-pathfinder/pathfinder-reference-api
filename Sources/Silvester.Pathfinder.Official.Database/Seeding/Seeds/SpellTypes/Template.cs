using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SpellTypes
{
    public abstract class Template : EntityTemplate<SpellType>
    {
        protected override SpellType GetEntity(ModelBuilder builder)
        {
            SpellType type = GetSpellType();
            return type;
        }

        public abstract SpellType GetSpellType();
    }
}

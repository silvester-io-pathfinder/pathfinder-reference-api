using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SpellTypes
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

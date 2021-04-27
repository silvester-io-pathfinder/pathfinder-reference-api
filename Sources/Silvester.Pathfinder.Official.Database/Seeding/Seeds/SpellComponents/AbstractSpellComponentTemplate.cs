using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SpellComponents
{
    public abstract class AbstractSpellComponentTemplate : EntityTemplate<SpellComponent>
    {
        protected override SpellComponent GetEntity(ModelBuilder builder)
        {
            SpellComponent component = GetSpellComponent();
            return component;
        }

        public abstract SpellComponent GetSpellComponent();
    }
}

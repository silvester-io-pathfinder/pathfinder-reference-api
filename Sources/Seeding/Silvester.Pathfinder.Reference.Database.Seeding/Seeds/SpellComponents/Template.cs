using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SpellComponents
{
    public abstract class Template : EntityTemplate<SpellComponent>
    {
        protected override SpellComponent GetEntity(ISeedBuilder builder)
        {
            SpellComponent component = GetSpellComponent();
            return component;
        }

        public abstract SpellComponent GetSpellComponent();
    }
}

using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Library : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("f3e8b6c2-238f-4354-aa4f-f638398e851e");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Library"
            };
        }
    }
}

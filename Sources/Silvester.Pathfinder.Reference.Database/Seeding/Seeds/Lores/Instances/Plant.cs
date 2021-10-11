using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Plant : Template
    {
        public static readonly Guid ID = Guid.Parse("a6db36f5-7999-46c1-b970-2f3ff6266eff");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Plant"
            };
        }
    }
}

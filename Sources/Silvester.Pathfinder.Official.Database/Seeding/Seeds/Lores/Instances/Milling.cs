using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Milling : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("72e8509a-c5b4-46be-9988-607f9786626b");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Milling"
            };
        }
    }
}

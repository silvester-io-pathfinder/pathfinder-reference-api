using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Tanning : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("c5ef590a-1eb9-43a4-a1e6-1521d9d47614");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Tanning"
            };
        }
    }
}

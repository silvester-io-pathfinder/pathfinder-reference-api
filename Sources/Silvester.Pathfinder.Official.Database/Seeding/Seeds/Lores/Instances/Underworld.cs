using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Underworld : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("e8ca8373-046b-4a64-8d17-ddcdcf56f869");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Underworld"
            };
        }
    }
}

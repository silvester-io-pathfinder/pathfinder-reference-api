using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Sonic : Template
    {
        public static readonly Guid ID = Guid.Parse("dabcd532-c08d-4612-bc51-a64ac6b2fa90");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Sonic"
            };
        }
    }
}

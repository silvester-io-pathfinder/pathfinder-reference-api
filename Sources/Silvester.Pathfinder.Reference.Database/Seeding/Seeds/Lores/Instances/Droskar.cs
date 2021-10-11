using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Droskar : Template
    {
        public static readonly Guid ID = Guid.Parse("7558c631-1e62-47e7-9cbb-3ec88d6da579");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Droskar"
            };
        }
    }
}

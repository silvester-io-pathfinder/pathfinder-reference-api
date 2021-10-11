using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Cartography : Template
    {
        public static readonly Guid ID = Guid.Parse("e9b948b2-6ed9-4ee8-898a-2e02fd68f27c");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Cartography"
            };
        }
    }
}

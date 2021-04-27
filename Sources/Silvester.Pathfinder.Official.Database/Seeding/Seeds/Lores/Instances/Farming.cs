using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Farming : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("ecd24e93-d6b6-46a4-8866-b4292df19c11");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Farming"
            };
        }
    }
}

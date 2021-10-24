using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Curse : Template
    {
        public static readonly Guid ID = Guid.Parse("125133bd-c062-4cb7-8603-dac0e638d755");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Curse"
            };
        }
    }
}

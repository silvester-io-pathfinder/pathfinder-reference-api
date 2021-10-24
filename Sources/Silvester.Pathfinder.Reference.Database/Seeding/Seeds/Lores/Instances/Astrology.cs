using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Astrology : Template
    {
        public static readonly Guid ID = Guid.Parse("11488e0e-26d4-4932-8fb8-524427d88fb5");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Astrology"
            };
        }
    }
}

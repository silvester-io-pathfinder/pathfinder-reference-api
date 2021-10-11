using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Alcohol : Template
    {
        public static readonly Guid ID = Guid.Parse("9eec7265-bf5a-4776-ab81-964a115861e9");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Alcohol"
            };
        }
    }
}
